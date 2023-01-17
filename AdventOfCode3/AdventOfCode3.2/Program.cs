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
            char badgeItem;
            int priorityOfBadge;
            List<string> groupOfElves = new List<string>();
            
            foreach (string line in File.ReadLines(filePath))
            {
                // appends elves into group
                groupOfElves.Add(line);
                if (groupOfElves.Count == 3)
                {
                    // finds what values are duplicated in each pair of lines
                    var elfIntersection1 = groupOfElves[0].Intersect(groupOfElves[1]);
                    var elfIntersection2 = groupOfElves[0].Intersect(groupOfElves[2]);

                    // finds single value present in all 3 lines
                    badgeItem = elfIntersection1.Intersect(elfIntersection2).Single();

                    // takes char and gives it numerical value from 1 -52 for a-Z
                    if (char.IsLower(badgeItem))
                    {
                        priorityOfBadge = badgeItem - 'a' + 1;
                    }
                    else 
                    {
                        priorityOfBadge = badgeItem - 'A' + 27;
                    }

                    // adds to totalPriority for all the duplicated priority values
                    totalPriorityOfItems += priorityOfBadge;

                    groupOfElves.Clear();

                    Console.WriteLine(badgeItem);
                    Console.WriteLine(priorityOfBadge);
                }
                Console.WriteLine(totalPriorityOfItems);
            }
        }
    }
}
