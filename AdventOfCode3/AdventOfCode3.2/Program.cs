using System;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"../../../../Input/AOC3 input.txt";
            int totalPriorityOfItems = 0;
            char badgeItem = 'A';
            int priorityOfBadge = 0;
            List<string> groupOfElves = new List<string>();

            // Loops through lines in fil and appends in list then finds values of repeated chars
            foreach (string line in File.ReadLines(inputPath))
            {
                groupOfElves.Add(line);
                Console.WriteLine(groupOfElves.Count);
                if (groupOfElves.Count == 3)
                {
                    foreach (char item in groupOfElves[0])
                    {
                        if(groupOfElves[1].Contains(char.ToString(item)) && groupOfElves[2].Contains(char.ToString(item)))
                        {
                            badgeItem = item;
                        }
                    }
                    groupOfElves.Clear();

                    if (char.IsLower(badgeItem))
                    {
                        priorityOfBadge = badgeItem - 96;
                    }
                    else if (char.IsUpper(badgeItem))
                    {
                        priorityOfBadge = badgeItem - 38;
                    }
                    totalPriorityOfItems += priorityOfBadge;
                }

                //Console.WriteLine(badgeItem);
                //Console.WriteLine(priorityOfBadge);
                //Console.WriteLine(totalPriorityOfItems);
            }
        }
    }
}
