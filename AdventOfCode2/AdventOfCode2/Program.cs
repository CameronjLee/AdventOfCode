using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2
{
    class Program
    {
        static string GameWinner(int ownMove, int opponentMove)
        {
            //Console.WriteLine(ownMove);
            //Console.WriteLine(opponentMove);

            if (ownMove == 1 && opponentMove == 3)
            {
                ownMove += 3;
            }
            else if (ownMove == 3 && opponentMove == 1)
            {
                opponentMove += 3;
            }

            string result = "Why";
            if (ownMove == opponentMove)
            {
                result = "Draw";
            }
            else if (ownMove > opponentMove)
            {
                result = "Win";
            }
            else if (ownMove < opponentMove)
            {
                result = "Lose";
            }
                return result;
        }
        static void Main(string[] args)
        {
            
            int totalPoints = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\cameronlee\Repos\Advent of Code\Input\AOC2 input.txt"))
            {
                string fileLine;
                while ((fileLine = sr.ReadLine()) != null)
                {
                    int opponentMove = fileLine[0] - 64;
                    int ownMove = fileLine[2] - 87;
                    string handResult = GameWinner(ownMove, opponentMove);
                    Console.WriteLine(ownMove);
                    Console.WriteLine(opponentMove);
                    //Console.WriteLine(handResult);
                    //Console.WriteLine(movePoints);
                    if (handResult == "Win")
                    {
                        totalPoints += 6;
                    }
                    else if (handResult == "Draw")
                    {
                        totalPoints += 3;
                    }
                    totalPoints += ownMove;
                    Console.WriteLine(totalPoints);
                }
                
            }

        }
    }
}
