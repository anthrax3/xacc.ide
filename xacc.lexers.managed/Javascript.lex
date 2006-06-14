%{
#include "gram_Javascript.h"
%}

%option 8bit
%option noyywrap
%option nostdinit
%option never-interactive
%option outfile="gram_Javascript.c"

types    (Undefined|Null|Boolean|String|Number|Object|Array)
objectatts  (ReadOnly|DontEnum|DontDelete|Internal)
basetype (null|true|false)
keyword  {basetype}|(break|case|catch|continue|default|delete|do|else|finally|for|function|if|in|instanceof|new|prototype|return|switch|throw|this|try|typeof|var|void|while|with)
reserved {reserved2}|(abstract|class|const|debugger|enum|export|extends|final|goto|implements|interface|native|package|private|protected|public|static|super|synchronized|throws|transient|volatile)
reserved2 (int|byte|boolean|char|long|float|double|short)

operator [\~\!\%\^\*\(\)\-\+\=\[\]\|\\\:\;\,\.\/\?\&\<\>]
comment_start          "/*"
comment_end            "*"+"/"

line_comment           "//".*

white_space            [ \t]
new_line               \n

preprocessor           ^{white_space}*#{white_space}*

dec_digit              [0-9]
hex_digit              [0-9A-Fa-f]
int_suffix             [UuLl]|[Uu][Ll]|[Ll][Uu]
dec_literal            {dec_digit}+{int_suffix}?
hex_literal            0[xX]{hex_digit}+{int_suffix}?
integer_literal        {dec_literal}|{hex_literal}

real_suffix            [FfDdMm]
sign                   [+\-]
exponent_part          [eE]{sign}?{dec_digit}+
whole_real1            {dec_digit}+{exponent_part}{real_suffix}?
whole_real2            {dec_digit}+{real_suffix}
part_real              {dec_digit}*\.{dec_digit}+{exponent_part}?{real_suffix}?
real_literal           {whole_real1}|{whole_real2}|{part_real}

single_char            [^\\\']
simple_esc_seq         \\[\'\\0abfnrtv/]
uni_esc_seq1           \\u{hex_digit}{4}
uni_esc_seq2           \\U{hex_digit}{8}
uni_esc_seq            {uni_esc_seq1}|{uni_esc_seq2}
hex_esc_seq            \\x{hex_digit}{1,4}
character              {single_char}|{simple_esc_seq}|{hex_esc_seq}|{uni_esc_seq}
character_literal      \'{character}*\'

single_string_char     [^\\\"]
reg_string_char        {single_string_char}|{simple_esc_seq}|\\\"|{hex_esc_seq}|{uni_esc_seq}
regular_string         \"{reg_string_char}*\"
quote_esc_seq          \"\"
string_literal         {regular_string}

single_re_char         [^\\/ \t\n]
single_re_char2        [^\\/ \*\t\n]
re_esc_seq             \\[\\\?/\.\$\^\(\)\{\}\*\+\-\|sbrntWwDdS\[\],]|{re_esc_seq2}|{hex_esc_seq}
re_esc_seq2            \\{dec_digit}+
re_string_char         {single_re_char}|{re_esc_seq}
re_string_char2        {single_re_char2}|{re_esc_seq}
re_string              "/"{re_string_char2}{re_string_char}*"/"[gim]*

letter_char            [A-Za-z]
ident_char             {dec_digit}|{letter_char}|"_"|"@"
identifier             ({letter_char}|"_"|"$"){ident_char}*
at_identifier          \@{identifier}
ws_identifier          {identifier}({white_space}+{identifier})*

rank_specifier         "["{white_space}*(","{white_space}*)*"]"

%x ML_COMMENT

%%

{white_space}+        { ; }
                      
{comment_start}       { ENTER(ML_COMMENT); RETURN4(COMMENT); }

<ML_COMMENT>
{
{new_line}            { RETURN4(NEWLINE); }
[^*\n]*               { RETURN4(COMMENT); }
"*"+[^*/\n]*          { RETURN4(COMMENT); }
{comment_end}         { EXIT(); RETURN4(COMMENT); }
}

{line_comment}        { RETURN4(COMMENT); }

{types}               { RETURN4(TYPE); } 
{keyword}             { RETURN4(KW); } 
{reserved}            { RETURN4(ERROR); } 
                      
{integer_literal}     { RETURN4(NUMBER); }
{real_literal}        { RETURN4(NUMBER); }
{character_literal}   { RETURN4(STRING); }
{string_literal}      { RETURN4(STRING); }
{re_string}           { RETURN4(OTHER); }

{operator}            { RETURN4(OP); }                     

{identifier}          { RETURN4(PLAIN); }

{new_line}            { RETURN4(NEWLINE);}
.                     { RETURN4(PLAIN); }
%%

