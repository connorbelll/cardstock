//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CardLanguage.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public partial class CardLanguageLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, BOOLOP=50, COMPOP=51, EQOP=52, 
		UNOP=53, INTNUM=54, OPEN=55, CLOSE=56, WS=57, ANY=58;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"BOOLOP", "COMPOP", "EQOP", "UNOP", "INTNUM", "OPEN", "CLOSE", "WS", "ANY"
	};


	public CardLanguageLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'stage'", "'game'", "'player'", "'team'", "'end'", "'comp'", "'choice'", 
		"'create'", "'loc'", "'Stack'", "'List'", "'Queue'", "'Memory'", "'sto'", 
		"'initialize'", "'players'", "'alternate'", "'sequential'", "'permdeck'", 
		"'points'", "'set'", "'next'", "'current'", "'inc'", "'dec'", "'move'", 
		"'all'", "'copy'", "'turn'", "'over'", "'pass'", "'remove'", "'shuffle'", 
		"'top'", "'bottom'", "'any'", "'owner'", "'where'", "'cardatt'", "'this'", 
		"'*'", "'-'", "'%'", "'//'", "'size'", "'max'", "'using'", "'union'", 
		"'sum'", null, null, null, "'not'", null, "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "BOOLOP", "COMPOP", "EQOP", "UNOP", "INTNUM", "OPEN", "CLOSE", 
		"WS", "ANY"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CardLanguage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2<\x1B3\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE"+
		"\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17"+
		"\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18"+
		"\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B"+
		"\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F"+
		"\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3\"\x3"+
		"\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3$\x3$\x3$\x3$\x3$\x3"+
		"$\x3$\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3&\x3&\x3&\x3\'\x3\'\x3\'\x3\'\x3\'"+
		"\x3\'\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3)\x3)\x3)\x3)\x3)\x3*\x3*\x3+"+
		"\x3+\x3,\x3,\x3-\x3-\x3-\x3.\x3.\x3.\x3.\x3.\x3/\x3/\x3/\x3/\x3\x30\x3"+
		"\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3"+
		"\x31\x3\x32\x3\x32\x3\x32\x3\x32\x3\x33\x3\x33\x3\x33\x3\x33\x3\x33\x5"+
		"\x33\x192\n\x33\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34\x5\x34\x199\n\x34\x3"+
		"\x35\x3\x35\x3\x35\x3\x35\x5\x35\x19F\n\x35\x3\x36\x3\x36\x3\x36\x3\x36"+
		"\x3\x37\x3\x37\x3\x38\x3\x38\x3\x39\x3\x39\x3:\x6:\x1AC\n:\r:\xE:\x1AD"+
		"\x3:\x3:\x3;\x3;\x2\x2<\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v"+
		"\x15\f\x17\r\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+"+
		"\x17-\x18/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\""+
		"\x43#\x45$G%I&K\'M(O)Q*S+U,W-Y.[/]\x30_\x31\x61\x32\x63\x33\x65\x34g\x35"+
		"i\x36k\x37m\x38o\x39q:s;u<\x3\x2\x5\x4\x2>>@@\x3\x2\x32;\x5\x2\v\f\xF"+
		"\xF\"\"\x1B7\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t"+
		"\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11"+
		"\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2"+
		"\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2"+
		"\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2"+
		"\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31"+
		"\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2"+
		"\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2"+
		"\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2"+
		"\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3"+
		"\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2"+
		"\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2\x61\x3\x2\x2\x2"+
		"\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2\x2\x2i\x3\x2\x2\x2"+
		"\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x2q\x3\x2\x2\x2\x2s\x3"+
		"\x2\x2\x2\x2u\x3\x2\x2\x2\x3w\x3\x2\x2\x2\x5}\x3\x2\x2\x2\a\x82\x3\x2"+
		"\x2\x2\t\x89\x3\x2\x2\x2\v\x8E\x3\x2\x2\x2\r\x92\x3\x2\x2\x2\xF\x97\x3"+
		"\x2\x2\x2\x11\x9E\x3\x2\x2\x2\x13\xA5\x3\x2\x2\x2\x15\xA9\x3\x2\x2\x2"+
		"\x17\xAF\x3\x2\x2\x2\x19\xB4\x3\x2\x2\x2\x1B\xBA\x3\x2\x2\x2\x1D\xC1\x3"+
		"\x2\x2\x2\x1F\xC5\x3\x2\x2\x2!\xD0\x3\x2\x2\x2#\xD8\x3\x2\x2\x2%\xE2\x3"+
		"\x2\x2\x2\'\xED\x3\x2\x2\x2)\xF6\x3\x2\x2\x2+\xFD\x3\x2\x2\x2-\x101\x3"+
		"\x2\x2\x2/\x106\x3\x2\x2\x2\x31\x10E\x3\x2\x2\x2\x33\x112\x3\x2\x2\x2"+
		"\x35\x116\x3\x2\x2\x2\x37\x11B\x3\x2\x2\x2\x39\x11F\x3\x2\x2\x2;\x124"+
		"\x3\x2\x2\x2=\x129\x3\x2\x2\x2?\x12E\x3\x2\x2\x2\x41\x133\x3\x2\x2\x2"+
		"\x43\x13A\x3\x2\x2\x2\x45\x142\x3\x2\x2\x2G\x146\x3\x2\x2\x2I\x14D\x3"+
		"\x2\x2\x2K\x151\x3\x2\x2\x2M\x157\x3\x2\x2\x2O\x15D\x3\x2\x2\x2Q\x165"+
		"\x3\x2\x2\x2S\x16A\x3\x2\x2\x2U\x16C\x3\x2\x2\x2W\x16E\x3\x2\x2\x2Y\x170"+
		"\x3\x2\x2\x2[\x173\x3\x2\x2\x2]\x178\x3\x2\x2\x2_\x17C\x3\x2\x2\x2\x61"+
		"\x182\x3\x2\x2\x2\x63\x188\x3\x2\x2\x2\x65\x191\x3\x2\x2\x2g\x198\x3\x2"+
		"\x2\x2i\x19E\x3\x2\x2\x2k\x1A0\x3\x2\x2\x2m\x1A4\x3\x2\x2\x2o\x1A6\x3"+
		"\x2\x2\x2q\x1A8\x3\x2\x2\x2s\x1AB\x3\x2\x2\x2u\x1B1\x3\x2\x2\x2wx\au\x2"+
		"\x2xy\av\x2\x2yz\a\x63\x2\x2z{\ai\x2\x2{|\ag\x2\x2|\x4\x3\x2\x2\x2}~\a"+
		"i\x2\x2~\x7F\a\x63\x2\x2\x7F\x80\ao\x2\x2\x80\x81\ag\x2\x2\x81\x6\x3\x2"+
		"\x2\x2\x82\x83\ar\x2\x2\x83\x84\an\x2\x2\x84\x85\a\x63\x2\x2\x85\x86\a"+
		"{\x2\x2\x86\x87\ag\x2\x2\x87\x88\at\x2\x2\x88\b\x3\x2\x2\x2\x89\x8A\a"+
		"v\x2\x2\x8A\x8B\ag\x2\x2\x8B\x8C\a\x63\x2\x2\x8C\x8D\ao\x2\x2\x8D\n\x3"+
		"\x2\x2\x2\x8E\x8F\ag\x2\x2\x8F\x90\ap\x2\x2\x90\x91\a\x66\x2\x2\x91\f"+
		"\x3\x2\x2\x2\x92\x93\a\x65\x2\x2\x93\x94\aq\x2\x2\x94\x95\ao\x2\x2\x95"+
		"\x96\ar\x2\x2\x96\xE\x3\x2\x2\x2\x97\x98\a\x65\x2\x2\x98\x99\aj\x2\x2"+
		"\x99\x9A\aq\x2\x2\x9A\x9B\ak\x2\x2\x9B\x9C\a\x65\x2\x2\x9C\x9D\ag\x2\x2"+
		"\x9D\x10\x3\x2\x2\x2\x9E\x9F\a\x65\x2\x2\x9F\xA0\at\x2\x2\xA0\xA1\ag\x2"+
		"\x2\xA1\xA2\a\x63\x2\x2\xA2\xA3\av\x2\x2\xA3\xA4\ag\x2\x2\xA4\x12\x3\x2"+
		"\x2\x2\xA5\xA6\an\x2\x2\xA6\xA7\aq\x2\x2\xA7\xA8\a\x65\x2\x2\xA8\x14\x3"+
		"\x2\x2\x2\xA9\xAA\aU\x2\x2\xAA\xAB\av\x2\x2\xAB\xAC\a\x63\x2\x2\xAC\xAD"+
		"\a\x65\x2\x2\xAD\xAE\am\x2\x2\xAE\x16\x3\x2\x2\x2\xAF\xB0\aN\x2\x2\xB0"+
		"\xB1\ak\x2\x2\xB1\xB2\au\x2\x2\xB2\xB3\av\x2\x2\xB3\x18\x3\x2\x2\x2\xB4"+
		"\xB5\aS\x2\x2\xB5\xB6\aw\x2\x2\xB6\xB7\ag\x2\x2\xB7\xB8\aw\x2\x2\xB8\xB9"+
		"\ag\x2\x2\xB9\x1A\x3\x2\x2\x2\xBA\xBB\aO\x2\x2\xBB\xBC\ag\x2\x2\xBC\xBD"+
		"\ao\x2\x2\xBD\xBE\aq\x2\x2\xBE\xBF\at\x2\x2\xBF\xC0\a{\x2\x2\xC0\x1C\x3"+
		"\x2\x2\x2\xC1\xC2\au\x2\x2\xC2\xC3\av\x2\x2\xC3\xC4\aq\x2\x2\xC4\x1E\x3"+
		"\x2\x2\x2\xC5\xC6\ak\x2\x2\xC6\xC7\ap\x2\x2\xC7\xC8\ak\x2\x2\xC8\xC9\a"+
		"v\x2\x2\xC9\xCA\ak\x2\x2\xCA\xCB\a\x63\x2\x2\xCB\xCC\an\x2\x2\xCC\xCD"+
		"\ak\x2\x2\xCD\xCE\a|\x2\x2\xCE\xCF\ag\x2\x2\xCF \x3\x2\x2\x2\xD0\xD1\a"+
		"r\x2\x2\xD1\xD2\an\x2\x2\xD2\xD3\a\x63\x2\x2\xD3\xD4\a{\x2\x2\xD4\xD5"+
		"\ag\x2\x2\xD5\xD6\at\x2\x2\xD6\xD7\au\x2\x2\xD7\"\x3\x2\x2\x2\xD8\xD9"+
		"\a\x63\x2\x2\xD9\xDA\an\x2\x2\xDA\xDB\av\x2\x2\xDB\xDC\ag\x2\x2\xDC\xDD"+
		"\at\x2\x2\xDD\xDE\ap\x2\x2\xDE\xDF\a\x63\x2\x2\xDF\xE0\av\x2\x2\xE0\xE1"+
		"\ag\x2\x2\xE1$\x3\x2\x2\x2\xE2\xE3\au\x2\x2\xE3\xE4\ag\x2\x2\xE4\xE5\a"+
		"s\x2\x2\xE5\xE6\aw\x2\x2\xE6\xE7\ag\x2\x2\xE7\xE8\ap\x2\x2\xE8\xE9\av"+
		"\x2\x2\xE9\xEA\ak\x2\x2\xEA\xEB\a\x63\x2\x2\xEB\xEC\an\x2\x2\xEC&\x3\x2"+
		"\x2\x2\xED\xEE\ar\x2\x2\xEE\xEF\ag\x2\x2\xEF\xF0\at\x2\x2\xF0\xF1\ao\x2"+
		"\x2\xF1\xF2\a\x66\x2\x2\xF2\xF3\ag\x2\x2\xF3\xF4\a\x65\x2\x2\xF4\xF5\a"+
		"m\x2\x2\xF5(\x3\x2\x2\x2\xF6\xF7\ar\x2\x2\xF7\xF8\aq\x2\x2\xF8\xF9\ak"+
		"\x2\x2\xF9\xFA\ap\x2\x2\xFA\xFB\av\x2\x2\xFB\xFC\au\x2\x2\xFC*\x3\x2\x2"+
		"\x2\xFD\xFE\au\x2\x2\xFE\xFF\ag\x2\x2\xFF\x100\av\x2\x2\x100,\x3\x2\x2"+
		"\x2\x101\x102\ap\x2\x2\x102\x103\ag\x2\x2\x103\x104\az\x2\x2\x104\x105"+
		"\av\x2\x2\x105.\x3\x2\x2\x2\x106\x107\a\x65\x2\x2\x107\x108\aw\x2\x2\x108"+
		"\x109\at\x2\x2\x109\x10A\at\x2\x2\x10A\x10B\ag\x2\x2\x10B\x10C\ap\x2\x2"+
		"\x10C\x10D\av\x2\x2\x10D\x30\x3\x2\x2\x2\x10E\x10F\ak\x2\x2\x10F\x110"+
		"\ap\x2\x2\x110\x111\a\x65\x2\x2\x111\x32\x3\x2\x2\x2\x112\x113\a\x66\x2"+
		"\x2\x113\x114\ag\x2\x2\x114\x115\a\x65\x2\x2\x115\x34\x3\x2\x2\x2\x116"+
		"\x117\ao\x2\x2\x117\x118\aq\x2\x2\x118\x119\ax\x2\x2\x119\x11A\ag\x2\x2"+
		"\x11A\x36\x3\x2\x2\x2\x11B\x11C\a\x63\x2\x2\x11C\x11D\an\x2\x2\x11D\x11E"+
		"\an\x2\x2\x11E\x38\x3\x2\x2\x2\x11F\x120\a\x65\x2\x2\x120\x121\aq\x2\x2"+
		"\x121\x122\ar\x2\x2\x122\x123\a{\x2\x2\x123:\x3\x2\x2\x2\x124\x125\av"+
		"\x2\x2\x125\x126\aw\x2\x2\x126\x127\at\x2\x2\x127\x128\ap\x2\x2\x128<"+
		"\x3\x2\x2\x2\x129\x12A\aq\x2\x2\x12A\x12B\ax\x2\x2\x12B\x12C\ag\x2\x2"+
		"\x12C\x12D\at\x2\x2\x12D>\x3\x2\x2\x2\x12E\x12F\ar\x2\x2\x12F\x130\a\x63"+
		"\x2\x2\x130\x131\au\x2\x2\x131\x132\au\x2\x2\x132@\x3\x2\x2\x2\x133\x134"+
		"\at\x2\x2\x134\x135\ag\x2\x2\x135\x136\ao\x2\x2\x136\x137\aq\x2\x2\x137"+
		"\x138\ax\x2\x2\x138\x139\ag\x2\x2\x139\x42\x3\x2\x2\x2\x13A\x13B\au\x2"+
		"\x2\x13B\x13C\aj\x2\x2\x13C\x13D\aw\x2\x2\x13D\x13E\ah\x2\x2\x13E\x13F"+
		"\ah\x2\x2\x13F\x140\an\x2\x2\x140\x141\ag\x2\x2\x141\x44\x3\x2\x2\x2\x142"+
		"\x143\av\x2\x2\x143\x144\aq\x2\x2\x144\x145\ar\x2\x2\x145\x46\x3\x2\x2"+
		"\x2\x146\x147\a\x64\x2\x2\x147\x148\aq\x2\x2\x148\x149\av\x2\x2\x149\x14A"+
		"\av\x2\x2\x14A\x14B\aq\x2\x2\x14B\x14C\ao\x2\x2\x14CH\x3\x2\x2\x2\x14D"+
		"\x14E\a\x63\x2\x2\x14E\x14F\ap\x2\x2\x14F\x150\a{\x2\x2\x150J\x3\x2\x2"+
		"\x2\x151\x152\aq\x2\x2\x152\x153\ay\x2\x2\x153\x154\ap\x2\x2\x154\x155"+
		"\ag\x2\x2\x155\x156\at\x2\x2\x156L\x3\x2\x2\x2\x157\x158\ay\x2\x2\x158"+
		"\x159\aj\x2\x2\x159\x15A\ag\x2\x2\x15A\x15B\at\x2\x2\x15B\x15C\ag\x2\x2"+
		"\x15CN\x3\x2\x2\x2\x15D\x15E\a\x65\x2\x2\x15E\x15F\a\x63\x2\x2\x15F\x160"+
		"\at\x2\x2\x160\x161\a\x66\x2\x2\x161\x162\a\x63\x2\x2\x162\x163\av\x2"+
		"\x2\x163\x164\av\x2\x2\x164P\x3\x2\x2\x2\x165\x166\av\x2\x2\x166\x167"+
		"\aj\x2\x2\x167\x168\ak\x2\x2\x168\x169\au\x2\x2\x169R\x3\x2\x2\x2\x16A"+
		"\x16B\a,\x2\x2\x16BT\x3\x2\x2\x2\x16C\x16D\a/\x2\x2\x16DV\x3\x2\x2\x2"+
		"\x16E\x16F\a\'\x2\x2\x16FX\x3\x2\x2\x2\x170\x171\a\x31\x2\x2\x171\x172"+
		"\a\x31\x2\x2\x172Z\x3\x2\x2\x2\x173\x174\au\x2\x2\x174\x175\ak\x2\x2\x175"+
		"\x176\a|\x2\x2\x176\x177\ag\x2\x2\x177\\\x3\x2\x2\x2\x178\x179\ao\x2\x2"+
		"\x179\x17A\a\x63\x2\x2\x17A\x17B\az\x2\x2\x17B^\x3\x2\x2\x2\x17C\x17D"+
		"\aw\x2\x2\x17D\x17E\au\x2\x2\x17E\x17F\ak\x2\x2\x17F\x180\ap\x2\x2\x180"+
		"\x181\ai\x2\x2\x181`\x3\x2\x2\x2\x182\x183\aw\x2\x2\x183\x184\ap\x2\x2"+
		"\x184\x185\ak\x2\x2\x185\x186\aq\x2\x2\x186\x187\ap\x2\x2\x187\x62\x3"+
		"\x2\x2\x2\x188\x189\au\x2\x2\x189\x18A\aw\x2\x2\x18A\x18B\ao\x2\x2\x18B"+
		"\x64\x3\x2\x2\x2\x18C\x18D\a\x63\x2\x2\x18D\x18E\ap\x2\x2\x18E\x192\a"+
		"\x66\x2\x2\x18F\x190\aq\x2\x2\x190\x192\at\x2\x2\x191\x18C\x3\x2\x2\x2"+
		"\x191\x18F\x3\x2\x2\x2\x192\x66\x3\x2\x2\x2\x193\x199\t\x2\x2\x2\x194"+
		"\x195\a@\x2\x2\x195\x199\a?\x2\x2\x196\x197\a>\x2\x2\x197\x199\a?\x2\x2"+
		"\x198\x193\x3\x2\x2\x2\x198\x194\x3\x2\x2\x2\x198\x196\x3\x2\x2\x2\x199"+
		"h\x3\x2\x2\x2\x19A\x19B\a#\x2\x2\x19B\x19F\a?\x2\x2\x19C\x19D\a?\x2\x2"+
		"\x19D\x19F\a?\x2\x2\x19E\x19A\x3\x2\x2\x2\x19E\x19C\x3\x2\x2\x2\x19Fj"+
		"\x3\x2\x2\x2\x1A0\x1A1\ap\x2\x2\x1A1\x1A2\aq\x2\x2\x1A2\x1A3\av\x2\x2"+
		"\x1A3l\x3\x2\x2\x2\x1A4\x1A5\t\x3\x2\x2\x1A5n\x3\x2\x2\x2\x1A6\x1A7\a"+
		"*\x2\x2\x1A7p\x3\x2\x2\x2\x1A8\x1A9\a+\x2\x2\x1A9r\x3\x2\x2\x2\x1AA\x1AC"+
		"\t\x4\x2\x2\x1AB\x1AA\x3\x2\x2\x2\x1AC\x1AD\x3\x2\x2\x2\x1AD\x1AB\x3\x2"+
		"\x2\x2\x1AD\x1AE\x3\x2\x2\x2\x1AE\x1AF\x3\x2\x2\x2\x1AF\x1B0\b:\x2\x2"+
		"\x1B0t\x3\x2\x2\x2\x1B1\x1B2\v\x2\x2\x2\x1B2v\x3\x2\x2\x2\a\x2\x191\x198"+
		"\x19E\x1AD\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}