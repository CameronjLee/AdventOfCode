using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string file = @"C: \Users\cameronlee\Repos\Advent of Code\Input\AOC1 input.txt";
            int highestElfCalorieCount = 0;
            int elfCalorieCount = 0;

            using (StreamReader sr = new StreamReader(file))
            {
                while (sr.Peek() > -1)
                {
                    string currentLine = sr.ReadLine();
                    if (String.IsNullOrEmpty(currentLine))
                    {
                        if (highestElfCalorieCount < elfCalorieCount)
                        {
                            highestElfCalorieCount = elfCalorieCount;
                        }
                         elfCalorieCount = 0;
                        continue;
                    }
                    elfCalorieCount += Int32.Parse(currentLine);
                    Console.WriteLine(elfCalorieCount);
                    Console.WriteLine(highestElfCalorieCount);



                }
            }
            //Console.WriteLine(no);
            
        }
    }
}
