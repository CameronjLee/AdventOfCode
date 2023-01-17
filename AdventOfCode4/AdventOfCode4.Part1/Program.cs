// .NET
using System;
using System.IO;
using System.Linq;

using AdventOfCode4;


namespace AdventOfCode4
{
    class Program
    {
        private static readonly char[] Delimiters = { '-', ',' };

        static void Main(string[] args)
        {
            // Get the input path
            string inputPath = args.Single();

            // Get the number of assignment pairs where one assignment contains the other
            int totalNumberWorkingSameArea = File.ReadLines(inputPath)
                .Where(DoesOneAssignmentContainTheOther)
                .Count();

            // Write the result to the console
            Console.WriteLine(totalNumberWorkingSameArea);
        }

        static bool DoesOneAssignmentContainTheOther(string line)
        {
            // Convert the string line into an int array
            int[] assignmentPair = line.Split(Delimiters).Select(int.Parse).ToArray();

            // Check if either assignment contains the other
            return assignmentPair[0] <= assignmentPair[2] && assignmentPair[1] >= assignmentPair[3] ||
                assignmentPair[0] >= assignmentPair[2] && assignmentPair[1] <= assignmentPair[3];
        }
    }
}
