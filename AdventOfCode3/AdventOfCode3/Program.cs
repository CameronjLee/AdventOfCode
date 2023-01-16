using System;
using System.IO;

namespace AdventOfCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"../../../../Input/AOC3 input.txt"))
            {
                int totalPriorityOfItems = 0;
                string fileLine;

                // Loops through lines and compares strings to find repeated values and priority
                while ((fileLine = sr.ReadLine()) != null)
                {
                    int compartmentContentsLength = (fileLine.Length)/2;
                    string compartment1 = fileLine.Substring(0, compartmentContentsLength);
                    string compartment2 = fileLine.Substring(compartmentContentsLength, compartmentContentsLength);
                    char duplicateItem = 'A';
                    int priorityOfItem = 0;
                    
                    foreach (char item in compartment1)
                    {
                        foreach (char item2 in compartment2)
                        {
                            if (item == item2)
                            {
                                duplicateItem = item;
                                break;
                            }
                        }
                    }

                    if (char.IsLower(duplicateItem))
                    {
                        priorityOfItem = duplicateItem - 96;
                    }
                    else if (char.IsUpper(duplicateItem))
                    {
                        priorityOfItem = duplicateItem - 38;
                    }

                    totalPriorityOfItems += priorityOfItem;

                    //Console.WriteLine(duplicateItem);
                    //Console.WriteLine(priorityOfItem);
                    //Console.WriteLine(totalPriorityOfItems);
                }
            }
        }
    }
}
