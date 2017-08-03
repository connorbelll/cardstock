﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using CardStockXam.Scoring;

namespace CardStockXam
{
    class Genetic
    {
        private static int repetitions = 3;
        private static int numKept = 3;//10;
        private static double crossoverRate = .4;
        private static double mutationRate = .4;
        private static int numMutations = 2;
        private static int minimumChildren = 6;//(int) Math.Floor(numKept * 1.5);

        private static bool crossingOver = false;
        private static bool mutating = true;
        private static bool testing = false;
        private static bool printingMods = true;

        private static GeneticFiler filer = new GeneticFiler();
        private static Generator gen = new Generator(filer, numMutations, printingMods);
        private static Random rnd = new Random();


        public static void Main(string[] args) {
            filer.FixInit();
            if (testing) {
                Test();
            }
            else {
                filer.Start(repetitions);
                GA();
            }
        }

        private static void GA(){
            for (int rep = 0; rep < repetitions; rep++){
                filer.newIter();
                gen.transcript = "";
                List<string> fileNames = filer.OnlyExtension(filer.GetFiles(filer.Pool()), ".gdl");

                foreach (var parent1 in fileNames){
                    if (crossingOver){
                        foreach (var parent2 in fileNames){
                            if (parent1 != parent2){
                                if (rnd.NextDouble() > crossoverRate){
                                    gen.Crossover(parent1, parent2);
                                }
                            }
                        }
                    }
                    if (mutating) {
                        if (rnd.NextDouble() > mutationRate) { 
                            gen.Mutate(parent1);
                        }
                    }
                }
                string[] newFiles = filer.GetFiles(filer.Intermediate());
                int numFiles = newFiles.Count();
                while (numFiles < minimumChildren){ // if not enough files created, create more
                    var parent1 = fileNames[rnd.Next(fileNames.Count())];
                    if (crossingOver && mutating) {
                        if (rnd.Next(2) == 0){
                            var parent2 = fileNames[rnd.Next(fileNames.Count())];
                            while (parent2 == parent1){
                                parent2 = fileNames[rnd.Next(fileNames.Count())];
                            }
                            gen.Crossover(parent1, parent2);
                        }
                        else{
                            gen.Mutate(parent1);
                        }
                    }
                    else if (crossingOver){
                        var parent2 = fileNames[rnd.Next(fileNames.Count())];
                        while (parent2 == parent1){
                            parent2 = fileNames[rnd.Next(fileNames.Count())];
                        }
                        gen.Crossover(parent1, parent2);
                    }
                    else if (mutating){
                        gen.Mutate(parent1);
                    }
                    else { Debug.WriteLine("You must mutate or crossover"); break; }
                    numFiles++;
                }
                filer.WriteTranscript(gen.transcript);
                string transcript = "";


                // Scoring
                newFiles = filer.GetFullPathFiles(filer.Intermediate());
                double[] scores = new double[newFiles.Count()];
                for (int i = 0; i < newFiles.Count(); i++) { // get scores
                    Scorer s = new Scorer(newFiles[i].Substring(0, newFiles[i].Length - 4));
                    scores[i] = s.Score();
                    filer.WriteTranscript(s.text);
                    var text = "File " + newFiles[i] + "'s score is " + scores[i];
                    Debug.WriteLine(text);
                    transcript += text + "\n";
                }
                var tup = Tournament(scores, newFiles);
                string[] keep = tup.Item1;
                double[] keepScores = tup.Item2;
                transcript += "Keeping files:\n";
                for (int i = 0; i < keep.Count(); i++) { 
                    Debug.WriteLine(keep[i]);
                    transcript += "    " + keep[i] + " with score " + keepScores[i] + "\n";
                }
                filer.WriteTranscript(transcript);
                // Save keep
                if (rep + 1 == repetitions) {
                    filer.moveAllFiles(filer.Intermediate(), "Gamepool/Final", true);
                }
                else{
                    filer.moveAllFiles(filer.Intermediate(), filer.NextPool(), true, newFiles);// keep);
                }   
            }
            Console.WriteLine("Complete.");
            Console.Read();
        }
   


        // Selection algorithms...

        private static Tuple<string[], double[]> Tournament(double[] scores, string[] files)
        {
            string[] toKeep = new string[numKept];
            double[] keptScores = new double[numKept];
            var count = scores.Count();

            if (count < numKept) { throw new ArgumentOutOfRangeException(); }

            for (int i = 0; i < numKept; i++)
            {
                var ind1 = rnd.Next(count);
                var ind2 = rnd.Next(count);
                int ind;
                if (scores[ind1] > scores[ind2]) { ind = ind1; }
                else { ind = ind2; }
                if (toKeep.Contains(files[ind])){
                    i--;
                }
                else {
                    toKeep[i] = files[ind];
                    keptScores[i] = scores[ind];
                }
            }
            return new Tuple<string[], double[]>(toKeep, keptScores);
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

        private static void Test(){
            var files = filer.GetFullPathFiles(filer.Initial());
            for (int i = 0; i < files.Count(); i++){
                Scorer s = new Scorer(files[i].Substring(0, files[i].Length - 4), true);
                Console.WriteLine("File " + files[i] + "'s score is " + s.Score());
            }
            Console.ReadLine();
        }

    }
}
