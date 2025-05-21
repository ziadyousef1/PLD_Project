using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;
using com.calitha.goldparser;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }
    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF           =  0, // (EOF)
        SYMBOL_ERROR         =  1, // (Error)
        SYMBOL_WHITESPACE    =  2, // Whitespace
        SYMBOL_MINUS         =  3, // '-'
        SYMBOL_LPAREN        =  4, // '('
        SYMBOL_RPAREN        =  5, // ')'
        SYMBOL_TIMES         =  6, // '*'
        SYMBOL_DIV           =  7, // '/'
        SYMBOL_PLUS          =  8, // '+'
        SYMBOL_EQ            =  9, // '='
        SYMBOL_ELSE          = 10, // else
        SYMBOL_IDENTIFIER    = 11, // Identifier
        SYMBOL_IF            = 12, // if
        SYMBOL_LET           = 13, // let
        SYMBOL_NEWLINE       = 14, // NewLine
        SYMBOL_NUMBER        = 15, // Number
        SYMBOL_PRINT         = 16, // print
        SYMBOL_STRINGLITERAL = 17, // StringLiteral
        SYMBOL_WHILE         = 18, // while
        SYMBOL_EXPRESSION    = 19, // <Expression>
        SYMBOL_FACTOR        = 20, // <Factor>
        SYMBOL_PROGRAM       = 21, // <Program>
        SYMBOL_STATEMENT     = 22, // <Statement>
        SYMBOL_STATEMENTLIST = 23, // <StatementList>
        SYMBOL_TERM          = 24  // <Term>
    };

    enum RuleConstants : int
    {
        RULE_PROGRAM                             =  0, // <Program> ::= <StatementList>
        RULE_STATEMENTLIST                       =  1, // <StatementList> ::= 
        RULE_STATEMENTLIST2                      =  2, // <StatementList> ::= <StatementList> <Statement>
        RULE_STATEMENTLIST3                      =  3, // <StatementList> ::= <Statement>
        RULE_STATEMENT_LET_IDENTIFIER_EQ_NEWLINE =  4, // <Statement> ::= let Identifier '=' <Expression> NewLine
        RULE_STATEMENT_IF_NEWLINE                =  5, // <Statement> ::= if <Expression> NewLine <StatementList>
        RULE_STATEMENT_IF_NEWLINE_ELSE_NEWLINE   =  6, // <Statement> ::= if <Expression> NewLine <StatementList> else NewLine <StatementList>
        RULE_STATEMENT_WHILE_NEWLINE             =  7, // <Statement> ::= while <Expression> NewLine <StatementList>
        RULE_STATEMENT_PRINT_NEWLINE             =  8, // <Statement> ::= print <Expression> NewLine
        RULE_EXPRESSION_PLUS                     =  9, // <Expression> ::= <Expression> '+' <Term>
        RULE_EXPRESSION_MINUS                    = 10, // <Expression> ::= <Expression> '-' <Term>
        RULE_EXPRESSION                          = 11, // <Expression> ::= <Term>
        RULE_TERM_TIMES                          = 12, // <Term> ::= <Term> '*' <Factor>
        RULE_TERM_DIV                            = 13, // <Term> ::= <Term> '/' <Factor>
        RULE_TERM                                = 14, // <Term> ::= <Factor>
        RULE_FACTOR_IDENTIFIER                   = 15, // <Factor> ::= Identifier
        RULE_FACTOR_NUMBER                       = 16, // <Factor> ::= Number
        RULE_FACTOR_STRINGLITERAL                = 17, // <Factor> ::= StringLiteral
        RULE_FACTOR_LPAREN_RPAREN                = 18  // <Factor> ::= '(' <Expression> ')'
    };

    public class MyParser
    {
        private LALRParser parser;
        private readonly ListBox listBox;
        private readonly ListBox listBox2;

        public MyParser(string filename,ListBox listBox,ListBox listBox2)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
            this.listBox = listBox;
            this.listBox2 = listBox2;
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
            parser.OnTokenRead  += new LALRParser.TokenReadHandler(TokenReadEvent);
        }

        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {

           string info = args.Token.Text +"\t \t" + args.Token.Symbol.Name;
            listBox2.Items.Add(info);

        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSE :
                //else
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER :
                //Identifier
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF :
                //if
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LET :
                //let
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                //NewLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NUMBER :
                //Number
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRINT :
                //print
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRINGLITERAL :
                //StringLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE :
                //while
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FACTOR :
                //<Factor>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM :
                //<Program>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENT :
                //<Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENTLIST :
                //<StatementList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TERM :
                //<Term>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_PROGRAM :
                //<Program> ::= <StatementList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST :
                //<StatementList> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST2 :
                //<StatementList> ::= <StatementList> <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTLIST3 :
                //<StatementList> ::= <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_LET_IDENTIFIER_EQ_NEWLINE :
                //<Statement> ::= let Identifier '=' <Expression> NewLine
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_IF_NEWLINE :
                //<Statement> ::= if <Expression> NewLine <StatementList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_IF_NEWLINE_ELSE_NEWLINE :
                //<Statement> ::= if <Expression> NewLine <StatementList> else NewLine <StatementList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_WHILE_NEWLINE :
                //<Statement> ::= while <Expression> NewLine <StatementList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_PRINT_NEWLINE :
                //<Statement> ::= print <Expression> NewLine
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_PLUS :
                //<Expression> ::= <Expression> '+' <Term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_MINUS :
                //<Expression> ::= <Expression> '-' <Term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_TIMES :
                //<Term> ::= <Term> '*' <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_DIV :
                //<Term> ::= <Term> '/' <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM :
                //<Term> ::= <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_IDENTIFIER :
                //<Factor> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_NUMBER :
                //<Factor> ::= Number
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_STRINGLITERAL :
                //<Factor> ::= StringLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_LPAREN_RPAREN :
                //<Factor> ::= '(' <Expression> ')'
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }


        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '" + args.UnexpectedToken.ToString() + "in line :" + args.UnexpectedToken.Location.LineNr;
            listBox.Items.Add(message);
            string message2 = "Expected Token: " + args.ExpectedTokens.ToString();
            listBox.Items.Add(message2);
            //todo: Report message to UI?
        }

    }

