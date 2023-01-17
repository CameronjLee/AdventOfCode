// .NET
using System;
using System.IO;
using System.Linq;


namespace AdventOfCode4
{
    class Program
    {
        private static readonly char[] Delimiters = { '-', ',' };
        static void Main(string[] args)
        {
            // Get the input path
            string inputPath = args.Single();

            // Get the number of assignment pairs where there is any overlap
            var totalOverlappingAreas = File.ReadLines(inputPath)
                .Where(DoAnyAssignmentsOverlap)
                .Count();

            // Write result to console
            Console.WriteLine(totalOverlappingAreas);
            
        }

        static bool DoAnyAssignmentsOverlap(string line)
        {
            // Convert the string line into an int array
            int[] assignmentPair = line.Split(Delimiters).Select(int.Parse).ToArray();

            // Check if there is any overlap between assignment pairs
            return (assignmentPair[2] <= assignmentPair[0] && assignmentPair[0] <= assignmentPair[3]
                || assignmentPair[2] <= assignmentPair[1] && assignmentPair[1] <= assignmentPair[3]
                || assignmentPair[0] <= assignmentPair[2] && assignmentPair[2] <= assignmentPair[1]);
            
        }
    }
}