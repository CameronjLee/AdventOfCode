using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args.Single();

            int totalPriorityOfItems = 0;
            List<string> groupOfElvesItems = new List<string>();
            
            foreach (string line in File.ReadLines(filePath))
            {
                // appends elves into group
                groupOfElvesItems.Add(line);
                if (groupOfElvesItems.Count == 3)
                {
                    totalPriorityOfItems += GetPriority(groupOfElvesItems);
                    groupOfElvesItems.Clear();
                }
                Console.WriteLine(totalPriorityOfItems);
            }
        }

        static int GetPriority(List<string> groupOfElvesItems)
        {
            int priorityOfBadge;
            // finds what values are duplicated in the first two lines
            var elfIntersection1 = groupOfElvesItems[0].Intersect(groupOfElvesItems[1]);

            // finds single value present in all 3 lines
            char badgeItem = elfIntersection1.Intersect(groupOfElvesItems[2]).Single();

            // takes char and gives it numerical value from 1 -52 for a-Z
            if (char.IsLower(badgeItem))
            {
                priorityOfBadge = badgeItem - 'a' + 1;
            }
            else
            {
                priorityOfBadge = badgeItem - 'A' + 27;
            }
            return priorityOfBadge;
            
        }
    }
}
