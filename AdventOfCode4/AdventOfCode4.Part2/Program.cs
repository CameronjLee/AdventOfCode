using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"../../../../input/AOC4 input.txt";
            int containedWithinPair = 0;

            // Reads file and parses to int. Checks whether ints are any ints are contained within eachother
            foreach (string line in File.ReadLines(inputPath))
            {
                char[] delimeters = { '-', ',' };
                string[] elfAreaStrings = line.Split(delimeters);
                List<int> elfAreaInts = new List<int>();
                for (int i = 0; i < elfAreaStrings.Length; i++)
                {
                    elfAreaInts.Add(Int32.Parse(elfAreaStrings[i]));
                }

                if (elfAreaInts[2] <= elfAreaInts[0] && elfAreaInts[0] <= elfAreaInts[3])
                {
                    containedWithinPair++;
                }
                else if (elfAreaInts[2] <= elfAreaInts[1] && elfAreaInts[1] <= elfAreaInts[3])
                {
                    containedWithinPair++;
                }
                else if (elfAreaInts[0] <= elfAreaInts[2] && elfAreaInts[2] <= elfAreaInts[1])
                {
                    containedWithinPair++;
                }

                //Console.WriteLine(containedWithinPair);
            }
        }
    }
}