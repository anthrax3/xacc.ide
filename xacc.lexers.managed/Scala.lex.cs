using Xacc.Languages.CSLex;
using Xacc.ComponentModel;
using System.Drawing;
using LexerBase = Xacc.Languages.CSLex.Language<Xacc.Languages.CSLex.Yytoken>.LexerBase;
namespace Xacc.Languages
{
  sealed class ScalaLang : CSLex.Language<CSLex.Yytoken>
  {
	  public override string Name {get {return "Scala"; } }
	  public override string[] Extensions {get { return new string[]{"scala"}; } }
	  LexerBase lexer = new ScalaLexer();
	  protected override LexerBase Lexer
	  {
		  get {return lexer;}
	  }
  }
}
//NOTE: comments are not allowed except in code blocks


sealed class ScalaLexer : LexerBase {

	public ScalaLexer () {
	YY_BOL = 256;
	YY_EOF = 257;

	}

	const int ML_COMMENT = 1;
	const int YYINITIAL = 0;
	static readonly int[] yy_state_dtrans = {
		0, 		25
	};
	static readonly int[] yy_acpt = {
0,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
0,4,4,4,0,4,4,4,0,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,
4,4,4,4,4,4,4,4,4,4,4,4	};
	static readonly int[] yy_cmap = unpackFromString(
1,258,
"39:9,35,33,39:21,35,39,34,39,50,39:2,37,39:2,52,39:2,4,36,51,38:10,39:2,3,1" +
",2,39:2,42,43,45,49:5,41,49:2,44,49:3,47,49,48,40,46,10,49:5,39:4,5,39,12,2" +
"8,13,23,16,25,15,19,8,29,14,26,24,7,21,11,32,20,17,9,6,27,30,31,18,22,39:13" +
"3,0:2")[0];

	static readonly int[] yy_rmap = {
0,1,2,1,1,3,1,4,5,6,1,3,1,7,1,8,1,9,1,3,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,9,30,4,31,32,33,5,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87
,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,3,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158};

	static readonly int[,] yy_nxt = {
{1,2,18,22,18,3,26,28,30,32,26,61,130,64,151,151,66,101,104,151,132,134,151,34,106,36,151,38,151,151,68,151,151,18,40,42,4,44,46,18,136,48,50,153,102,168,70,72,151,151,18,52,18},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,3,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,7,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,8,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,-1,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9},
{-1,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,-1,13,-1,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,16,-1},
{-1,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,-1,6,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17,17},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,12,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21},
{-1,-1,-1,-1,3,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,57,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,11,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{1,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,14,13,7,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,13,15},
{-1,-1,-1,-1,-1,5,5,59,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,41,5,5,5,5,5,59,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,63,5,5,5,5,5,5,5,5,5,20,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,24,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,129,19,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,65,67,27,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,19,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,29,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,60,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,108,5,5,5,109,5,5,5,5,5,5,5,5,31,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,33,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,-1,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,11,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,24,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,11,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,35,5,5,5,5,5,5,5,5,5,5,5,5,111,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,9,10},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,23,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,11,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,11,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,19,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,11,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,37,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,92,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,150,5,5,5,5,5,5,5,152,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,11,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,39,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,69,5,5,5,5,5,5,71,5,5,5,5,5,5,100,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,41,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,73,5,5,5,5,154,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,43,5,5,5,5,5,5,5,5,5,5,5,78,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,74,5,5,5,5,5,5,5,5,5,5,110,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,79,5,5,5,5,5,5,5,41,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,76,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,45,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,77,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,41,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,47,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,24,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,49,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,45,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,20,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,47,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,43,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,31,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,51,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,53,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,41,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,62,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,37,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,51,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,51,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,54,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,37,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,55,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,56,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,41,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,41,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,43,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,58,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,43,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,41,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,45,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,80,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,103,5,5,5,5,5,5,5,5,5,133,5,172,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,75,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,81,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,105,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,82,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,107,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,79,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,83,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,73,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,84,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,85,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,86,5,5,5,5,143,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,87,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,88,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,89,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,90,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,91,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,93,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,94,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,95,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,96,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,59,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,90,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,97,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,98,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,88,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,99,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,88,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,112,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,131,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,162,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,113,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,135,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,114,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,163,137,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,115,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,157,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,138,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,116,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,117,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,118,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,119,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,120,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,121,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,122,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,123,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,124,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,125,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,126,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,127,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,128,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,139,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,140,5,5,5,5,5,5,5,5,5,5,5,5,164,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,155,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,141,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,142,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,144,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,145,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,146,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,147,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,148,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,149,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,156,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,158,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,159,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,160,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,161,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,165,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,167,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,166,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,5,5,5,5,5,5,169,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,5,5,5,5,5,5,170,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1},
{-1,-1,-1,-1,-1,5,5,171,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,-1,-1,-1,-1,-1,5,-1,5,5,5,5,5,5,5,5,5,5,5,-1,-1}};

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
					throw (new System.Exception("Lexical Error: Unmatched Input."));
				}
				else {
					yy_anchor = yy_acpt[yy_last_accept_state];
					if (0 != (YY_END & yy_anchor)) {
						yy_move_end();
					}
					yy_to_mark();
					switch (yy_last_accept_state) {
					case 8: 
                 {return Number();}
						break;
					case 4: 
                                              {return Operator();}
						break;
					case 10: 
               {ENTER(ML_COMMENT); return Comment();}
						break;
					case 13: 
                       {return Comment();}
						break;
					case 1: 

						break;
					case 16: 
                {EXIT(); return Comment();}
						break;
					case 15: 
               {return Comment();}
						break;
					case 2: case 18: case 22: case 26: case 28: case 30: case 32: case 34: 
					case 36: case 38: case 40: case 42: case 44: case 46: case 48: case 50: 
					case 52: case 61: case 64: case 66: case 68: case 70: case 72: case 101: 
					case 102: case 104: case 106: case 130: case 132: case 134: case 136: case 151: 
					case 153: case 168: 
               {return Preprocessor();}
						break;
					case 9: 
                   {return Comment();}
						break;
					case 7: 
      {;}
						break;
					case 5: case 20: case 24: case 27: case 29: case 31: case 33: case 35: 
					case 37: case 39: case 41: case 43: case 45: case 47: case 49: case 51: 
					case 53: case 54: case 55: case 56: case 57: case 58: case 59: case 62: 
					case 63: case 65: case 67: case 69: case 71: case 73: case 74: case 75: 
					case 76: case 77: case 78: case 79: case 80: case 81: case 82: case 83: 
					case 84: case 85: case 86: case 87: case 88: case 89: case 90: case 91: 
					case 92: case 93: case 94: case 95: case 96: case 97: case 98: case 99: 
					case 100: case 103: case 105: case 107: case 108: case 109: case 110: case 111: 
					case 112: case 113: case 114: case 115: case 116: case 117: case 118: case 119: 
					case 120: case 121: case 122: case 123: case 124: case 125: case 126: case 127: 
					case 128: case 129: case 131: case 133: case 135: case 137: case 138: case 139: 
					case 140: case 141: case 142: case 143: case 144: case 145: case 146: case 147: 
					case 148: case 149: case 150: case 152: case 154: case 155: case 156: case 157: 
					case 158: case 159: case 160: case 161: case 162: case 163: case 164: case 165: 
					case 166: case 167: case 169: case 170: case 171: case 172: 
                                 {return Identifier();}
						break;
					case 12: 
                    {return Character();}
						break;
					case 3: case 19: case 23: 
                                                                                                                                                                                                                                                                                                                                                                                 {return Keyword();}
						break;
					case 11: case 60: 
                                                                                {return Type();}
						break;
					case 14: 
  {return NewLine();}
						break;
					case 6: 
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
