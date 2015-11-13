using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using Antlr4.Runtime.Tree;
using ParseTreeIterator;
public class ParseEngine{
        StringBuilder builder = new StringBuilder();
	public ParseEngine(){

		Debug.AutoFlush = true;

		var regex = new Regex ("(;;)(.*?)(\n)");


		var fileName = "Spades";

		var f = File.ReadAllText ("games/" + fileName + ".gdl");
		var file = f;
		//Console.WriteLine(file);
		file = regex.Replace (file, "\n");
		//Console.WriteLine(file);
		AntlrInputStream stream = new AntlrInputStream (file);
		ITokenSource lexer = new RecycleLexer (stream);
		ITokenStream tokens = new CommonTokenStream (lexer);
		var parser = new RecycleParser (tokens);
        
		parser.BuildParseTree = true;
		var tree = parser.game ();
		//Recurse(tree);
                
		//Console.Write(tree.ToStringTree());
		builder.Append ("graph tree{");
		builder.AppendLine ("NODE0 [label=\"Stage\" style=filled fillcolor=\"red\"]");
		DOTMaker (tree, "NODE0");
		builder.Append ("}");
		//var fs = File.Create("games/" + fileName + ".gv");
		var bytes = Encoding.UTF8.GetBytes (builder.ToString ());
		//fs.Write(bytes,0,bytes.Length);
		//fs.Close();
		//Console.WriteLine(tree);
		TimeSpan minTime = TimeSpan.MaxValue;
		TimeSpan maxTime = TimeSpan.MinValue;
		TimeSpan totalTime = new TimeSpan(0);
		int[] teamWins = new int[3];
		for (int i = 0; i < 500; ++i) {
			CardEngine.CardGame.Instance = new CardEngine.CardGame ();

			// Here for timing estimates right now
			Stopwatch time = new Stopwatch ();
			time.Start ();

			StageIterator.ProcessGame (tree);
			if (CardEngine.CardGame.Instance.teams [0].teamStorage ["SCORE"] > CardEngine.CardGame.Instance.teams [1].teamStorage ["SCORE"]) {
				teamWins [0]++;
			}
			if (CardEngine.CardGame.Instance.teams [1].teamStorage ["SCORE"] > CardEngine.CardGame.Instance.teams [0].teamStorage ["SCORE"]) {
				teamWins [1]++;
			}
			if (CardEngine.CardGame.Instance.teams [1].teamStorage ["SCORE"] == CardEngine.CardGame.Instance.teams [0].teamStorage ["SCORE"]) {
				teamWins [2]++;
			}
			foreach (var player in CardEngine.CardGame.Instance.players) {
				Debug.WriteLine ("Green bin:");
				foreach (var green in player.cardBins["GREEN"].AllCards()) {
					Debug.WriteLine (green);
				}
			}
			//Console.Write(Analytics.StageCount.Instance);
			//Console.Write(Analytics.BranchingFactor.Instance);
			//Console.Write(Analytics.StorageValues.Instance);
			var binCounts = Analytics.BinCounts.Instance.DictRep ();
			foreach (var key in binCounts.Keys) {
				Debug.WriteLine (key);
				foreach (var str in binCounts[key]) {
					Debug.Write (str + ", ");
				}
						
				Debug.Write ("\n");
			}
			time.Stop ();
			//Analytics.AnalyticsNetworking.PostResults();
			if (time.Elapsed < minTime) {
				minTime = time.Elapsed;
			}
			if (time.Elapsed > maxTime) {
				maxTime = time.Elapsed;
			}
			totalTime += time.Elapsed;
			//Console.WriteLine ("Elapsed:" + time.Elapsed);
		}
		Console.WriteLine ("Min:" + minTime);
		Console.WriteLine ("Max:" + maxTime);
		Console.WriteLine ("Avg:" + totalTime.TotalSeconds / 100.0);
		Console.WriteLine ("Team 1: " + teamWins [0] + " Team 2: " + teamWins [1] + " Ties: " + teamWins[2]);

	}
    public void DOTMaker(IParseTree node, string nodeName){
                
		for (int i = 0; i < node.ChildCount; ++i) {
			var dontCreate = false;
			var newNodeName = nodeName + "_" + i;
			var contextName = node.GetChild (i).GetType ().ToString ().Replace ("RecycleParser+", "").Replace ("Context", "");
			if (node.GetChild (i).ChildCount > 0 && contextName == "Int") {
				var text = node.GetChild (i).GetText ();
				int myi = 0;
				while (myi < text.Length && Char.IsDigit (text [myi])) {
					myi++;
				} 
				if (myi != text.Length) {
					builder.AppendLine (newNodeName + " [label=\"" + node.GetChild (i).GetType ().ToString ().Replace ("RecycleParser+", "").Replace ("Context", "") + "\" ]");
					DOTMaker (node.GetChild (i), newNodeName);                             
				} else {
					builder.AppendLine (newNodeName + " [label=\"" + node.GetChild (i).GetText () + "\" style=filled fillcolor=\"lightblue\"]");  
				}                         
			} else if (node.GetChild (i).ChildCount > 0 && contextName != "Namegr" && contextName != "Name" && contextName != "Trueany") {
				var extra = "";
				if (contextName == "Stage") {
					extra = " style=filled fillcolor=\"red\"";
				} else if (contextName == "Computermoves") {
					extra = " style=filled shape=box fillcolor=\"yellow\"";
				} else if (contextName == "Playermoves") {
					extra = " style=filled shape=diamond fillcolor=\"orange\"";
				}
				builder.AppendLine (newNodeName + " [label=\"" + node.GetChild (i).GetType ().ToString ().Replace ("RecycleParser+", "").Replace ("Context", "") + "\" " + extra + "]");
				DOTMaker (node.GetChild (i), newNodeName);                             
			} else if (node.GetChild (i).ChildCount > 0) {
				builder.AppendLine (newNodeName + " [fillcolor=\"green\" style=filled label=\"" + node.GetChild (i).GetText () + "\"]");
			} else if (node.GetChild (i).GetText () == "(" || node.GetChild (i).GetText () == ")" || node.GetChild (i).GetText () == "," ||
			                              node.GetChild (i).GetText () == "end" || node.GetChild (i).GetText () == "stage" || node.GetChild (i).GetText () == "comp" ||
			                              node.GetChild (i).GetText () == "create" || node.GetChild (i).GetText () == "sto" || node.GetChild (i).GetText () == "loc" ||
			                              node.GetChild (i).GetText () == "initialize" || node.GetChild (i).GetText () == "move" || node.GetChild (i).GetText () == "copy" ||
			                              node.GetChild (i).GetText () == "inc" || node.GetChild (i).GetText () == "dec" || node.GetChild (i).GetText () == "shuffle" ||
			                              node.GetChild (i).GetText () == "remove" ||
			                              node.GetChild (i).GetText () == "choice") {
				dontCreate = true;
			} else {
				builder.AppendLine (newNodeName + " [label=\"" + node.GetChild (i).GetText () + "\"]");
				//DOTMaker(node.GetChild(i),newNodeName);
			}
			if (!dontCreate) {
				builder.AppendLine (nodeName + " -- " + newNodeName);
			}
		}
	}
/*        public void Recurse(RecycleParser.BodyContext con){
                Recurse(con.childNode());
        }
        public void Recurse(RecycleParser.ChildNodeContext con){
                Console.Write("{ ");
                if (con.ChildCount == 4){
                        Recurse((RecycleParser.ChildNodeContext)con.children[1]);
                        Recurse((RecycleParser.ChildNodeContext)con.children[3]);
                }
                else if (con.ChildCount == 3){
                        Recurse((RecycleParser.ChildNodeContext)con.children[1]);
                }
                else{
                        Console.Write(con.GetText());
                }
                Console.Write(" }");
        }
        */
}