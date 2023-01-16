// .NET
using System;
using System.IO;

namespace AdventOfCode1
{
    internal static class Program
    {
        private static void Main()
        {
            const string inputPath = @"../../../../Input/AOC1 input.txt";
            int highestElfCalorieCount = 0;
            int elfCalorieCount = 0;

            // Loop through lines in the file
            foreach (string line in File.ReadLines(inputPath))
            {
                if (string.IsNullOrEmpty(line))
                {
                    if (highestElfCalorieCount < elfCalorieCount)
                    {
                        highestElfCalorieCount = elfCalorieCount;
                    }
                    elfCalorieCount = 0;
                    continue;
                }
                elfCalorieCount += int.Parse(line);
                Console.WriteLine(elfCalorieCount);
                Console.WriteLine(highestElfCalorieCount);
            }
        }
    }
}
