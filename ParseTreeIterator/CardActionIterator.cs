using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using Antlr4.Runtime.Tree;
using CardEngine;

namespace ParseTreeIterator
{
	public class CardActionIterator{
		public static GameActionCollection ProcessCopy(CardLanguageParser.CopyactionContext copy){
			var ret = new GameActionCollection();
			if (copy.ChildCount == 4){
				//Explicit Repeat
				var count = copy.GetChild(3).GetText();
				if (count == "all"){//copy all
					//forbidden for now
				}
				else{//copy x number of times
					var explicitCount = int.Parse(count);
					for (int i = 0; i < explicitCount; ++i){
						 
					}
				}
			}
			else{
				//Do once
				var cardOne = CardIterator.ProcessCard(copy.card(0));
				var cardTwo = CardIterator.ProcessCard(copy.card(1));
				foreach (var card1 in cardOne){
					foreach (var card2 in cardTwo){
						ret.Add(new FancyCardMoveAction(card1,card2));
					}
				}
			}
			return ret;
		}
		public static GameActionCollection ProcessMove(CardLanguageParser.MoveactionContext move){
			var ret = new GameActionCollection();
			if (move.ChildCount == 4){
				//Explicit Repeat
				var count = move.GetChild(3).GetText();
				if (count == "all"){//copy all
					//forbidden for now
				}
				else{//copy x number of times
					var explicitCount = int.Parse(count);
					for (int i = 0; i < explicitCount; ++i){
						 
					}
				}
			}
			else{
				//Do once
				var cardOne = CardIterator.ProcessCard(move.card(0));
				var cardTwo = CardIterator.ProcessCard(move.card(1));
				foreach (var card1 in cardOne){
					foreach (var card2 in cardTwo){
						ret.Add(new FancyCardCopyAction(card1.Get(),card2));
					}
				}
				
			}
			return ret;
		}
		
	}
}