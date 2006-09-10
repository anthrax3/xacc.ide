// Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005
// (see accompanying GPPGcopyright.rtf)


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace gpcc
{
  public class CodeGenerator
  {
    public Grammar grammar;

    public void Generate(List<State> states, Grammar grammar)
    {
      this.grammar = grammar;

      GenerateCopyright();

      GenerateUsingHeader();

      if (grammar.Namespace != null)
      {
        Console.WriteLine("namespace {0}", grammar.Namespace);
        Console.WriteLine("{");
      }

      GenerateTokens(grammar.terminals);

      GenerateClassHeader(grammar.ParserName);
      InsertCode(grammar.prologCode);
      GenerateInitializeMethod(states, grammar.productions, grammar.nonTerminals);
      GenerateActionMethod(grammar.productions);
      GenerateToStringMethod();
      InsertCode(grammar.epilogCode);
      GenerateClassFooter();

      if (grammar.Namespace != null)
        Console.WriteLine("}");
    }


    private void GenerateCopyright()
    {
      Console.WriteLine("// This code was generated by the Gardens Point Parser Generator");
      Console.WriteLine("// Copyright (c) Wayne Kelly, QUT 2005");
      Console.WriteLine("// (see accompanying GPPGcopyright.rtf)");
      Console.WriteLine();
      Console.WriteLine();
    }

    private void GenerateUsingHeader()
    {
      Console.WriteLine("using System;");
      Console.WriteLine("using System.Collections.Generic;");
      Console.WriteLine("using System.Text;");
      Console.WriteLine("using Xacc.Build;");
      Console.WriteLine("using Xacc.CodeModel;");
      Console.WriteLine("using Xacc.ComponentModel;");
      Console.WriteLine("using Xacc.Languages.CSLex;");
      Console.WriteLine("using gppg;");
      foreach (string use in grammar.use)
      {
        Console.WriteLine("using {0};", use);
      }
      Console.WriteLine();
    }

    private void GenerateTokens(Dictionary<string, Terminal> terminals)
    {
      Console.Write("{0} enum {1} {{", grammar.Visibility, grammar.TokenName);
      Console.Write("IGNORE = -1");
      bool first = false;
      foreach (Terminal terminal in terminals.Values)
        if (terminal.symbolic)
        {
          if (!first)
            Console.Write(",");
          Console.Write("{0}={1}", terminal.ToString(), terminal.num);
          first = false;
        }

      Console.WriteLine("};");
      Console.WriteLine();

      Console.WriteLine("public abstract class LexerBase<T> : Xacc.Languages.CSLex.Language<T>.LexerBase where T : struct, Xacc.ComponentModel.IToken");
      Console.WriteLine("{");
      foreach (Terminal terminal in grammar.terminals.Values)
      {
        if (terminal.symbolic)
        {
          Console.WriteLine("public const int {0}={1};", terminal.ToString(), terminal.num);
        }
      }
      Console.WriteLine("}");
    }

    private string GenerateValueType()
    {
      if (grammar.unionType != null)
      {
        Console.WriteLine("{0} struct {1} : Xacc.ComponentModel.IToken", grammar.Visibility, grammar.ValueTypeName);
        InsertCode(grammar.unionType);
        return grammar.ValueTypeName;
      }
      else
        return "int";
    }


    private void GenerateClassHeader(string name)
    {
      Console.WriteLine("{2} partial class {0}: ShiftReduceParser<{1}>", name, GenerateValueType(), grammar.Visibility);
      Console.WriteLine("{");
    }


    private void GenerateClassFooter()
    {
      Console.WriteLine("}");
    }


    private void GenerateInitializeMethod(
  List<State> states,
  List<Production> productions,
  Dictionary<string, NonTerminal> nonTerminals)
    {
      Console.WriteLine("  protected override void Initialize()");
      Console.WriteLine("  {");

      Console.WriteLine("    this.errToken = (int){0}.error;", grammar.TokenName);
      Console.WriteLine("    this.eofToken = (int){0}.EOF;", grammar.TokenName);

      Console.WriteLine();
#if DEBUG
      Console.WriteLine("    stringstates=new string[{0}];", states.Count);
      Console.WriteLine("    stringrules=new string[{0}];", productions.Count + 1);
#endif
      Console.WriteLine("    states=new State[{0}];", states.Count);

      int state_nr = 0;
      foreach (State state in states)
        GenerateState(state_nr++, state);

      Console.WriteLine();

      Console.WriteLine("    rules=new Rule[{0}];", productions.Count + 1);
      foreach (Production production in productions)
        GenerateRule(production);

      Console.WriteLine();


      Console.Write("    nonTerminals = new string[] {\"\", ");
      int length = 37;
      foreach (NonTerminal nonTerminal in nonTerminals.Values)
      {
        string ss = String.Format("\"{0}\", ", nonTerminal.ToString());
        length += ss.Length;
        Console.Write(ss);
        if (length > 70)
        {
          Console.WriteLine();
          Console.Write("      ");
          length = 0;
        }
      }
      Console.WriteLine("};");

      Console.WriteLine("  }");

      Console.WriteLine();
    }


    private void GenerateState(int state_nr, State state)
    {
#if DEBUG
      Console.WriteLine("stringstates[{0}] = @\"{1}\";", state_nr, state.GetDebug());
#endif
      Console.Write("    AddState({0},new State(", state_nr);

      int defaultAction = GetDefaultAction(state);
      if (defaultAction != 0)
        Console.Write(defaultAction);
      else
      {
        Console.Write("new int[]{");
        bool first = true;
        foreach (KeyValuePair<Terminal, ParserAction> transition in state.parseTable)
        {
          if (!first)
            Console.Write(",");
          Console.Write("{0},{1}", transition.Key.num, transition.Value.ToNum());
          first = false;
        }
        Console.Write("}");
      }

      if (state.nonTerminalTransitions.Count > 0)
      {
        Console.Write(",new int[]{");
        bool first = true;
        foreach (Transition transition in state.nonTerminalTransitions.Values)
        {
          if (!first)
            Console.Write(",");
          Console.Write("{0},{1}", transition.A.num, transition.next.num);
          first = false;
        }
        Console.Write("}");
      }

      if (state.conflictTable.Count > 0)
      {
        Console.Write(",new int[]{");
        bool first = true;
        foreach (KeyValuePair<Terminal, ParserAction> transition in state.conflictTable)
        {
          if (!first)
            Console.Write(",");
          Console.Write("{0},{1}", transition.Key.num, transition.Value.ToNum());
          first = false;
        }
        Console.Write("}");
      }

      Console.WriteLine("));");
    }


    private int GetDefaultAction(State state)
    {
      IEnumerator<ParserAction> enumerator = state.parseTable.Values.GetEnumerator();
      enumerator.MoveNext();
      int defaultAction = enumerator.Current.ToNum();

      if (defaultAction > 0)
        return 0; // can't have default shift action

      foreach (KeyValuePair<Terminal, ParserAction> transition in state.parseTable)
        if (transition.Value.ToNum() != defaultAction)
          return 0;

      return defaultAction;
    }


    private void GenerateRule(Production production)
    {
#if DEBUG
      Console.WriteLine("stringrules[{0}] = @\"{1}\";", production.num, production);
#endif
      Console.Write("    rules[{0}]=new Rule({1}, new int[]{{", production.num, production.lhs.num);
      bool first = true;
      foreach (Symbol sym in production.rhs)
      {
        if (!first)
          Console.Write(",");
        else
          first = false;
        Console.Write("{0}", sym.num);
      }
      Console.WriteLine("});");
    }


    private void GenerateActionMethod(List<Production> productions)
    {
      Console.WriteLine("  protected override void DoAction(int action)");
      Console.WriteLine("  {");
      Console.WriteLine("    switch (action)");
      Console.WriteLine("    {");
      foreach (Production production in productions)
      {
        if (production.semanticAction != null)
        {
          Console.WriteLine("      case {0}: // {1}", production.num, production.ToString());
          production.semanticAction.GenerateCode(this);
          if (GPCG.LINES)
          {
            Console.WriteLine("#line hidden");
          }
          Console.WriteLine("        break;");
        }
      }
      Console.WriteLine("    }");
      Console.WriteLine("  }");
      Console.WriteLine();
    }


    private void GenerateToStringMethod()
    {
      Console.WriteLine("  protected override string TerminalToString(int terminal)");
      Console.WriteLine("  {");
      Console.WriteLine("    if (((Tokens)terminal).ToString() != terminal.ToString())");
      Console.WriteLine("      return ((Tokens)terminal).ToString();");
      Console.WriteLine("    else");
      Console.WriteLine("      return CharToString((char)terminal);");
      Console.WriteLine("  }");

      Console.WriteLine();
    }


    private void InsertCode(string code)
    {
      if (code != null)
      {
        StringReader reader = new StringReader(code);
        while (true)
        {
          string line = reader.ReadLine();
          if (line == null)
            break;
          Console.WriteLine("{0}", line);
        }
        if (GPCG.LINES)
        {
          Console.WriteLine("#line default");
        }
      }
    }
  }
}







