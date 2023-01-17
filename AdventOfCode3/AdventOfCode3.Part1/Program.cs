using System;
using System.IO;
using System.Linq;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args.Single();
            int totalPriorityOfItems = 0;
            foreach (string line in File.ReadLines(filePath))
            {
                // adds to totalPriority for all the duplicated priority values
                totalPriorityOfItems += GetPriority(line);
                
                Console.WriteLine(totalPriorityOfItems);
                
            }
        }

        static int GetPriority(string line)
        {
            // splits input strings in half for two compartments
            string compartment1 = line.Substring(0, (line.Length / 2));
            string compartment2 = line.Substring((line.Length / 2), (line.Length / 2));

            int priorityOfDuplicateItem = 0;

            // finds the value that is present in both compartments
            char duplicateItem = compartment1.Intersect(compartment2).Single();

            // takes char and gives it numerical value from 1 -52 for a-Z
            if (char.IsLower(duplicateItem))
            {
                priorityOfDuplicateItem = duplicateItem - 'a' + 1;
            }
            else if (char.IsUpper(duplicateItem))
            {
                priorityOfDuplicateItem = duplicateItem - 'A' + 27;
            }

            Console.WriteLine(duplicateItem);
            Console.WriteLine(priorityOfDuplicateItem);

            return priorityOfDuplicateItem;
        }
    }
}
