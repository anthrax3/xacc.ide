using Xacc.Languages.CSLex;
#pragma warning disable 162
using Xacc.ComponentModel;
using System.Drawing;
using LexerBase = Xacc.Languages.CSLex.Language<Xacc.Languages.CSLex.Yytoken>.LexerBase;
namespace Xacc.Languages
{
  sealed class XmlLanguage : CSLex.Language<CSLex.Yytoken>
  {
	  public override string Name {get {return "XML"; } }
	  public override string[] Extensions {get { return new string[]{"xml","html","xsl"}; } }
	  protected override LexerBase GetLexer() { return new XmlLexer(); } 
	  public override bool MatchLine(string startline)
    {
      return startline.StartsWith("<");
    }
    protected internal override string[] CommentLines(string[] lines)
    {
      lines[0] = "<!--" + lines[0];
      lines[lines.Length - 1] = lines[lines.Length - 1] + "-->";
      return lines;
    }
  }
}
//NOTE: comments are not allowed except in code blocks


sealed class XmlLexer : LexerBase {

	public XmlLexer () {
	YY_BOL = 65536;
	YY_EOF = 65537;

	}

	const int starttag = 3;
	const int comment = 1;
	const int attr = 10;
	const int pp = 8;
	const int cdata = 5;
	const int YYINITIAL = 0;
	const int endtag = 4;
	const int script = 6;
	const int mlstr = 9;
	const int intag = 2;
	const int scriptstart = 7;
	readonly int[] yy_state_dtrans = {
		0, 		69, 		71, 		72, 		73, 		74, 		76, 		84, 		87, 		88, 		89
	};
	readonly int[] yy_acpt = {
0,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,0,4,4,4,4,4,
4,4,4,4,0,4,4,4,4,0,4,4,0,4,4,0,
4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
0,0,0,0,0,0,0,0,0,0,0,4,4,4,4	};
	readonly int[] yy_cmap = unpackFromString(
1,65538,
"9:9,1,2,9:2,7,9:18,1,4,21,19,9,8,29,22,9:5,5,19,18,20:11,31,3,16,6,17,9,13," +
"30,11,12,30:15,14,30:6,10,9,15,9,19,9,30:2,24,30:5,26,30:6,27,30,25,23,28,3" +
"0:6,9:65413,0:2")[0];

	readonly int[] yy_rmap = {
0,1,2,1,3,1,4,1,1,1,1,1,5,6,1,1,7,1,1,1,8,8,1,1,9,10,11,1,12,1,1,13,1,1,1,14,15,1,16,1,17,18,1,19,20,21,22,22,23,22,24,25,17,26,27,1,28,1,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,34,36,56,57,58,18,59,60,61,62,63};

	readonly int[,] yy_nxt = {
{1,2,3,4,5,5,5,-1,5,5,5,6,6,6,6,5,5,5,5,6,5,5,5,6,6,6,6,6,6,46,6,5},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,2,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,45,-1,-1,-1,7,-1,-1,-1,-1,-1,-1,-1,-1,55,8,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,6,-1,-1,-1,-1,-1,6,6,6,6,-1,-1,-1,-1,6,6,-1,-1,6,6,6,6,6,6,-1,6,-1},
{-1,12,-1,12,12,-1,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12},
{-1,-1,-1,-1,-1,70,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,16,-1,-1,-1,-1,-1,16,16,16,16,-1,-1,-1,-1,16,16,-1,-1,16,16,16,16,16,16,-1,16,-1},
{-1,-1,-1,-1,-1,20,-1,-1,-1,-1,-1,20,20,20,20,-1,-1,-1,-1,20,20,-1,-1,20,20,20,20,20,20,-1,20,-1},
{-1,-1,-1,-1,-1,24,-1,-1,-1,-1,-1,24,24,24,24,-1,-1,-1,-1,24,24,-1,-1,24,24,24,24,24,24,-1,24,-1},
{-1,25,-1,25,25,25,25,25,25,25,25,25,25,25,25,-1,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,75,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,57,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,57,77,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,31,-1,-1,-1,-1,-1,31,31,31,31,-1,-1,-1,-1,31,31,-1,-1,31,31,31,31,31,31,-1,31,-1},
{-1,35,-1,35,35,35,35,35,-1,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35},
{-1,-1,-1,-1,-1,-1,37,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,38,-1,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,-1,38,38,38,38,38,38,38,38,38,38},
{-1,-1,-1,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,-1,40,40,40,40,40,40,40,40,40,40},
{-1,90,-1,90,90,90,90,90,90,90,90,90,90,90,90,90,90,90,90,90,90,42,90,90,90,90,90,90,90,90,90,90},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,43,43,43,43,-1,-1,-1,-1,-1,-1,-1,-1,43,43,43,43,43,43,-1,43,9},
{-1,44,-1,12,12,-1,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12},
{-1,-1,-1,-1,-1,53,-1,-1,-1,-1,58,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,43,43,43,43,-1,-1,-1,-1,-1,-1,-1,-1,43,43,43,43,43,43,-1,43,-1},
{-1,-1,-1,-1,-1,20,-1,-1,-1,-1,-1,20,20,20,20,-1,-1,-1,-1,20,20,-1,-1,20,20,20,20,20,21,-1,20,-1},
{-1,-1,-1,-1,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50},
{-1,91,91,51,51,51,51,51,51,51,51,51,51,51,51,51,51,51,51,51,51,91,52,51,51,51,51,51,51,51,51,51},
{-1,-1,-1,-1,-1,10,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,54,-1,25,25,25,25,25,25,25,25,25,25,25,25,-1,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25},
{-1,-1,-1,-1,-1,-1,18,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,61,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,59,-1,35,35,35,35,35,-1,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35},
{-1,-1,-1,-1,-1,-1,33,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,64,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,62,-1,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,-1,38,38,38,38,38,38,38,38,38,38},
{-1,85,-1,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,85,34,85,85,85,85,85,85,85,85,85,85},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,66,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,86,34,86,86,86,86,86,86,86,86,86},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,67,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,68,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,11,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{1,44,3,12,12,13,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12},
{-1,-1,-1,-1,-1,-1,14,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{1,2,3,5,5,5,15,-1,5,5,5,16,16,16,16,5,17,56,56,16,5,5,5,16,16,16,16,16,16,46,16,5},
{1,2,3,19,19,19,19,-1,19,19,19,20,20,20,20,19,19,19,19,20,19,19,19,95,20,20,20,20,20,47,20,19},
{1,2,3,22,22,22,23,-1,22,22,22,24,24,24,24,22,22,22,22,24,22,22,22,24,24,24,24,24,24,49,24,22},
{1,54,3,25,25,25,25,25,25,25,25,25,25,25,25,26,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25,25},
{-1,-1,-1,-1,-1,-1,27,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{1,2,3,28,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50},
{-1,77,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,78,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,79,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,80,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,81,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,82,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,83,-1,-1,-1},
{-1,83,-1,-1,-1,-1,29,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{1,2,3,5,5,5,30,-1,5,5,5,31,31,31,31,5,32,60,60,31,5,63,65,31,31,31,31,31,31,46,31,5},
{1,59,3,35,35,35,35,35,36,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35,35},
{1,62,3,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,38,39,38,38,38,38,38,38,38,38,38,38},
{1,2,3,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,41,51,40,40,40,40,40,40,40,40,40},
{-1,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,91,42,91,91,91,91,91,91,91,91,91},
{-1,-1,-1,-1,-1,20,-1,-1,-1,-1,-1,20,20,20,20,-1,-1,-1,-1,20,20,-1,-1,20,20,20,20,48,20,-1,20,-1},
{-1,-1,-1,-1,-1,20,-1,-1,-1,-1,-1,20,20,20,20,-1,-1,-1,-1,20,20,-1,-1,20,20,20,92,20,20,-1,20,-1},
{-1,-1,-1,-1,-1,20,-1,-1,-1,-1,-1,20,20,20,20,-1,-1,-1,-1,20,20,-1,-1,20,20,93,20,20,20,-1,20,-1},
{-1,-1,-1,-1,-1,20,-1,-1,-1,-1,-1,20,20,20,20,-1,-1,-1,-1,20,20,-1,-1,20,94,20,20,20,20,-1,20,-1}};

	public override IToken lex ()
 {
		int yy_lookahead;
		int yy_anchor = YY_NO_ANCHOR;
		int yy_state = yy_state_dtrans[yy_lexical_state];
		int yy_next_state = YY_NO_STATE;
		int yy_last_accept_state = YY_NO_STATE;
		bool yy_initial = true;
		int yy_this_accept;

		yy_mark_start();
		yy_this_accept = yy_acpt[yy_state];
		if (YY_NOT_ACCEPT != yy_this_accept) {
			yy_last_accept_state = yy_state;
			yy_mark_end();
		}
		while (true) {
			if (yy_initial && yy_at_bol) yy_lookahead = YY_BOL;
			else yy_lookahead = yy_advance();
			yy_next_state = YY_F;
			yy_next_state = yy_nxt[yy_rmap[yy_state],yy_cmap[yy_lookahead]];
			if (YY_EOF == yy_lookahead && true == yy_initial) {
				return Yytoken.EOF;
			}
			if (YY_F != yy_next_state) {
				yy_state = yy_next_state;
				yy_initial = false;
				yy_this_accept = yy_acpt[yy_state];
				if (YY_NOT_ACCEPT != yy_this_accept) {
					yy_last_accept_state = yy_state;
					yy_mark_end();
				}
			}
			else {
				if (YY_NO_STATE == yy_last_accept_state) {
					return Error();
				}
				else {
					yy_anchor = yy_acpt[yy_last_accept_state];
					if (0 != (YY_END & yy_anchor)) {
						yy_move_end();
					}
					yy_to_mark();
					switch (yy_last_accept_state) {
					case 36: 
     {return Custom(KnownColor.Black, KnownColor.Yellow); }
						break;
					case 12: 
                {return DocComment();}
						break;
					case 2: case 44: case 54: case 59: case 62: 
      {;}
						break;
					case 14: 
              {EXIT(); return Comment();}
						break;
					case 31: 
                                             {return Number();}
						break;
					case 33: 
                      {EXIT(); return Keyword();}
						break;
					case 29: 
                                         {EXIT(); return Keyword();}
						break;
					case 26: 
        {return Plain(); }
						break;
					case 20: case 48: case 92: case 93: case 94: case 95: 
                                          {EXIT(); ENTER(intag); return Keyword();}
						break;
					case 6: 
                                           {return Identifier();}
						break;
					case 4: case 45: case 55: 
                        {ENTER(starttag); return Keyword();}
						break;
					case 8: 
               {ENTER(endtag); return Keyword();}
						break;
					case 7: 
               {ENTER(pp); return Keyword(); }
						break;
					case 41: 
          {ENTER(mlstr); return String();}
						break;
					case 42: case 52: 
                                      {EXIT(); return String();}
						break;
					case 15: 
          {EXIT(); return Keyword();}
						break;
					case 19: case 47: 
           {return Error(); }
						break;
					case 22: case 49: 
         {return Error(); }
						break;
					case 21: 
                  {EXIT(); ENTER(scriptstart); return Keyword();}
						break;
					case 5: case 46: case 56: case 60: case 63: case 65: 
 {return Plain(); }
						break;
					case 32: 
                {return Operator();}
						break;
					case 37: 
        {EXIT(); return Keyword();}
						break;
					case 16: 
                                       {return Number();}
						break;
					case 38: 
               {return String();}
						break;
					case 1: 

						break;
					case 18: 
                {EXIT(); return Keyword();}
						break;
					case 25: 
               {return Plain(); }
						break;
					case 10: 
                 {ENTER(comment); return Comment();}
						break;
					case 11: 
                      {ENTER(cdata); return Other(); }
						break;
					case 9: 
            {return Other(); }
						break;
					case 27: 
            {EXIT(); return Other();}
						break;
					case 40: case 51: 
                 {EXIT(); return String(); }
						break;
					case 13: 
           {return DocComment(); }
						break;
					case 3: 
  {return NewLine();}
						break;
					case 24: 
                                        {return Keyword();}
						break;
					case 17: 
          {ENTER(attr); return Operator();}
						break;
					case 30: 
                {EXIT(); ENTER(script); return Keyword();}
						break;
					case 35: 
           {return Custom(KnownColor.Black, KnownColor.Yellow); }
						break;
					case 28: case 50: case 57: 
                                {return Plain();}
						break;
					case 23: 
           {EXIT(); return Keyword();}
						break;
					case 39: 
           {EXIT(); EXIT(); return String();}
						break;
					case 34: 
                                             {return String();}
						break;
					default:
						yy_error(YY_E_INTERNAL,false);break;
					}
					yy_initial = true;
					yy_state = yy_state_dtrans[yy_lexical_state];
					yy_next_state = YY_NO_STATE;
					yy_last_accept_state = YY_NO_STATE;
					yy_mark_start();
					yy_this_accept = yy_acpt[yy_state];
					if (YY_NOT_ACCEPT != yy_this_accept) {
						yy_last_accept_state = yy_state;
						yy_mark_end();
					}
				}
			}
		}
	}
}
