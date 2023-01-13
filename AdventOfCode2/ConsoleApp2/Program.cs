using System;
using System.IO;


namespace AdventOfCode2
{
    class Program
    {
        static int ResponseMove(string handResult, int opponentMove)
        {
            int ownMove = 0;
            //Console.WriteLine(ownMove);
            //Console.WriteLine(opponentMove);

            if (handResult == "X") //Lose
            {
                if (opponentMove == 1)
                {
                    ownMove = 3;
                }
                else
                {
                    ownMove = opponentMove - 1;
                }
                
            }
            else if (handResult == "Y") // Draw
            {
                ownMove = opponentMove;
            }
            else if (handResult == "Z")
            {
                if (opponentMove == 3)
                {
                    ownMove = 1;
                }
                else
                {
                    ownMove = opponentMove + 1;
                }
            }
            return ownMove;
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
                    string handResult = Char.ToString(fileLine[2]);
                    int ownMove = ResponseMove(handResult, opponentMove);
                    Console.WriteLine(ownMove);
                    Console.WriteLine(opponentMove);
                    Console.WriteLine(handResult);
                    //Console.WriteLine(movePoints);
                    if (handResult == "Z")
                    {
                        totalPoints += 6;
                    }
                    else if (handResult == "Y")
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