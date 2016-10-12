﻿using CardGames;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime;

namespace CardStockXam
{
    class Genetic
    {
        private static int repetitions = 2;
        private static int numKept = 2;//10;
        private static double crossoverRate = .4;
        private static double mutationRate = .4;
        private static int numMutations = 2;
        private static int minimumChildren = 2;//(int) Math.Floor(numKept * 1.5);
        private static Random rnd = new Random();


        public static void Main(string[] args){
            string newPool = "Gamepool\\Pool0";
            var pool = newPool;
            string intermediate = "Gamepool\\Intermediate0";
            deleteAllOldFiles();
            moveAllFiles("Gamepool\\Initial", newPool, true);
            
            for (int rep = 0; rep < repetitions; rep++){
                pool = newPool;
                newPool = "Gamepool\\Pool" + (rep + 1);
                intermediate = "Gamepool\\Intermediate" + rep;
                Directory.CreateDirectory(pool);
                Directory.CreateDirectory(intermediate);
                string[] fileNames = Directory.GetFiles(pool);

                foreach (var parent1 in fileNames){
                    foreach (var parent2 in fileNames){
                        if (parent1 != parent2){
                            if (rnd.NextDouble() > crossoverRate){
                                Crossover(parent1, parent2, intermediate);
                            }
                        }
                    }
                    if (rnd.NextDouble() > mutationRate) { 
                        Mutate(parent1, intermediate);
                    }
                }
                string[] newFiles = Directory.GetFiles(intermediate);
                Console.WriteLine("Created files in " + intermediate + ":");
                foreach (string filename in newFiles){
                    Console.WriteLine(filename);
                }
                int numFiles = newFiles.Count();
                while (numFiles < minimumChildren){ // if not enough files created, create more
                    var parent1 = fileNames[rnd.Next(fileNames.Count())];
                    if (rnd.Next(2) == 0){
                        var parent2 = fileNames[rnd.Next(fileNames.Count())];
                        while (parent2 == parent1){
                            parent2 = fileNames[rnd.Next(fileNames.Count())];
                        }
                        Crossover(parent1, parent2, intermediate);
                    }
                    else{
                        Mutate(parent1, intermediate);
                    }
                    numFiles++;
                }
                newFiles = Directory.GetFiles(intermediate);
                
                // Scoring
                double[] scores = new double[newFiles.Count()];
                for (int i = 0; i < newFiles.Count(); i++) { // get scores
                    newFiles[i] = Path.GetFullPath(newFiles[i]);
                    Scorer s = new Scorer(newFiles[i].Substring(0, newFiles[i].Length - 4));
                    scores[i] = s.Score();
                    i++;
                }
                string[] keep = GetTop(scores, newFiles);

                // Save toKeep
                if (rep + 1 == repetitions) {
                    moveAllFiles(intermediate, "Gamepool/Final", true);
                }
                else{
                    moveAllFiles(intermediate, newPool, true, newFiles);// keep);
                }   
            }
        }

        private static void Crossover(string parent1, string parent2, string folder)
        {
            folder += "/";
            var parser1 = OpenParser(parent1);
            var parser2 = OpenParser(parent2);
            bool unchanged = true;
            Type tree = null;
            while (unchanged){
                var x = rnd.Next();
                if (x < .2){
                    tree = typeof(RecycleParser.StageContext);
                }
                else if (.2 < x  && x < .4){
                    tree = typeof(RecycleParser.MultiactionContext);
                }
                else if (.4 < x && x < .6) {
                    tree = typeof(RecycleParser.Multiaction2Context);
                }
                else if (.6 < x && x < .8){
                    tree = typeof(RecycleParser.DeckContext);
                }
                else {
                    tree = typeof(RecycleParser.SetupContext);
                }
                var possible1 = f2(parser1.game(), new List<int>(), tree);
                var possible2 = f2(parser2.game(), new List<int>(), tree);
                if (possible1.Count > 0 && possible2.Count > 0){
                    unchanged = false;
                    var tree1 = possible1[rnd.Next() * (possible1.Count - 1)];
                    var tree2 = possible2[rnd.Next() * (possible2.Count - 1)];
                    var tup1 = GetSubTree(tree1);
                    var tup2 = GetSubTree(tree2);
                    tup1.Item1.GetChild(tree1[tree1.Count - 1]) = tup2.Item2;
                }
                // take corresponding elements and switch them
                // ex switch moves or scoring or end conditions
            }


            var child1 = parser1.game().GetText();// TODO
            var child2 = parser2.game().GetText();
            Console.WriteLine("child1: " + child1);
            string child1Name = GetName(parent1, parent2);
            string child2Name = GetName(parent2, parent1);

            MakeFile(child1, folder + child1Name);
            MakeFile(child2, folder + child2Name);
        }

        private static Tuple<IParseTree, IParseTree> GetSubTree(List<int> path){

        }

        private static Tuple<IParseTree, IParseTree, bool> FindSubTree(RecycleParser parser, Type treeType){
            List<IParseTree> nodes = new List<IParseTree>();
            nodes.Add(parser.game());
            List<IParseTree> parents = new List<IParseTree>();
            List<IParseTree> all = new List<IParseTree>();
            while (nodes.Count > 0) {
                IParseTree current = nodes[0];
                nodes.RemoveAt(0);
                for (int i = 0; i < current.ChildCount; i++) {
                    var child = current.GetChild(i);
                    if (child.GetType() == treeType){
                        parents.Add(current);
                        all.Add(child);
                    }
                    nodes.Add(child);
                }
            }
            if (all.Count == 0){
                return new Tuple<IParseTree, IParseTree, bool>(null, null, false);
            }
            int index = rnd.Next() * (all.Count-1);
            return new Tuple<IParseTree, IParseTree, bool>(parents[index], all[index], true);
        }

        private static List<List<int>> f2(IParseTree t, List<int> l, Type treeType){
            List<List<int>> allPaths = new List<List<int>>();
            for(int i = 0; i < t.ChildCount; i++) {
                var child = t.GetChild(i);
                List<int> newl = new List<int>(l);
                if (child.GetType() == treeType)
                {
                    l.Add(i);
                    allPaths.Add(l);
                }
                var temp = f2(child, newl, treeType);
                foreach (var item in temp){
                    allPaths.Add(item);
                }
            }
            return allPaths;
        }

        private static void Mutate(string parent, string folder)
        {
            folder += "/";
            // perform mutation
                // choose numMutations random mutations or random permutations
                // to mutate:
                    // randomly choose an atom
                    // perform a random change on that atom
            // save to file in intermediate

            string childName = Trim(parent) + "M.gdl";
            string child = parent.ToString();
            MakeFile(child, folder + childName);
        }

        private static void MakeFile(string file, string name){
            if (File.Exists(name))
            {
                name.Insert(name.Length - 4, "1");
            }
            File.WriteAllText(name, file);
            Console.WriteLine("Wrote file " + name);
        }

        private static string[] GetTop(double[] scores, string[] files)
        {
            int[] indexes = TopScoreIndexes(scores, numKept);
            string[] keep = new string[indexes.Count()];
            for (int k = 0; k < indexes.Count(); k++)
            {
                keep[k] = files[indexes[k]];
            }
            return keep;
        }

        private static RecycleParser OpenParser(string file){
            AntlrInputStream stream = new AntlrInputStream(file);
            ITokenSource lexer = new RecycleLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            return new RecycleParser(tokens);
        }

        private static string GetName(string parent1, string parent2){
            var name1 = Trim(parent1);
            var name2 = Trim(parent2);
            name1 = name1.Substring(0, name1.Length / 2);
            name2 = name2.Substring(name2.Length / 2, name2.Length / 2);
            return name1 + name2 + ".gdl";
        }

        private static string Trim(string s){
            var paths = s.Split('\\');
            s = paths[paths.Count() - 1];
            s = s.Split('.')[0];
            return s;
        }

        private static int[] TopScoreIndexes(double[] ar, int num)
        {
            int[] ret = new int[num];
            double lower = GetNthBiggest(ar, num);
            int idx = 0;
            for (int i = 0; i < ar.Count(); i++){ 
                if (ar[i] >= lower)
                {
                    ret[idx] = i;
                    idx++;
                }
            }
            return ret;
        }

        private static double GetNthBiggest(double[] array, int n)
        {
            var comparer = Comparer<int>.Create((x, y) => array[x].CompareTo(array[y])); 
            var highestIndices = new SortedSet<int>(comparer);
            for (var i = 0; i < array.Length; i++)
            {
                var entry = array[i];
                if (highestIndices.Count < n) highestIndices.Add(i);
                else if (array[highestIndices.Min] < entry)
                {
                    highestIndices.Remove(highestIndices.Min);
                    highestIndices.Add(i);
                }
            }

            return highestIndices.Min;
        }


        public static void moveAllFiles(string start, string end, bool copy = false, string[] files = null)
        {
            if (!Directory.Exists(end)) { Directory.CreateDirectory(end); }
            if (files == null) { files = Directory.GetFiles(start); }

            foreach (string s in files){
                var fileName = Path.GetFileName(s);
                var destFile = Path.Combine(end, fileName);
                if (copy){
                    File.Copy(s, destFile, true);
                }
                else {
                    File.Move(s, destFile);
                }
            }
        }

        private static void deleteFiles(string folder){
            string[] toRemove = Directory.GetFiles(folder);

            foreach (string s in toRemove)
            {
                File.Delete(s);
            }
        }

        private static void deleteAllOldFiles(){
            var folders = Directory.GetDirectories("Gamepool");
            foreach (var folder in folders){
                Console.WriteLine(folder);
                if (folder.Contains("Pool") || folder.Contains("Intermediate")){
                    Console.WriteLine("^deleting");
                    DeleteDirectory(folder);
                }
            }
        }

        public static void DeleteDirectory(string targetDir)
        {
            deleteFiles(targetDir);
            Directory.Delete(targetDir, false);
        }
    }
}