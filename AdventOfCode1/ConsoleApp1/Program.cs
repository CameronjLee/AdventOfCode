using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1_1
{
    class Program
    {

        static void Main(string[] args)
        {
            string file = @"C: \Users\cameronlee\Repos\Advent of Code\Input\AOC1 input.txt";
            int highestElfCalorieCount = 0;
            int secondHighestElfCalorieCount = 0;
            int thirdHighestElfCalorieCount = 0;
            int elfCalorieCount = 0;

            using (StreamReader sr = new StreamReader(file))
            {
                while (sr.Peek() > -1)
                {
                    string currentLine = sr.ReadLine();
                    if (String.IsNullOrEmpty(currentLine))
                    {
                        if (elfCalorieCount > highestElfCalorieCount)
                        {
                            thirdHighestElfCalorieCount = secondHighestElfCalorieCount;
                            secondHighestElfCalorieCount = highestElfCalorieCount;
                            highestElfCalorieCount = elfCalorieCount;
                        }
                        else if (elfCalorieCount > secondHighestElfCalorieCount)
                        {
                            thirdHighestElfCalorieCount = secondHighestElfCalorieCount;
                            secondHighestElfCalorieCount = elfCalorieCount;
                        }
                        else if (elfCalorieCount > thirdHighestElfCalorieCount)
                        {
                            thirdHighestElfCalorieCount = elfCalorieCount;
                        }
                        elfCalorieCount = 0;
                        continue;
                    }
                    
                    elfCalorieCount += Int32.Parse(currentLine);
                    int totalCalories = highestElfCalorieCount + secondHighestElfCalorieCount + thirdHighestElfCalorieCount;
                    Console.WriteLine(elfCalorieCount);
                    Console.WriteLine("highest is: " + highestElfCalorieCount);
                    Console.WriteLine("second is: " + secondHighestElfCalorieCount);
                    Console.WriteLine("third is: " + thirdHighestElfCalorieCount);
                    Console.WriteLine("Total is: " + totalCalories);




                }
            }

        }
    }
}
