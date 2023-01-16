// .NET
using System;
using System.IO;
using System.Linq;

// Application
using AdventOfCode2.Enums;

namespace AdventOfCode2.Part1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // The path of the input file
            string path = args.Single();

            // Get the total score
            int totalScore = File.ReadLines(path).Select(GetPoints).Sum();

            // Output total score to console
            Console.WriteLine(totalScore);
        }

        private static int GetPoints(string line)
        {
            // Get the opponent's move. This will be A, B or C.
            var opponentMove = (Move) (line[0] - 'A' + 1);

            // Get out move. This will be X, Y or Z.
            var ownMove = (Move) (line[2] - 'X' + 1);

            // Get the results. This will be win, draw or loss.
            var result = GetResult(ownMove, opponentMove);

            // Calculate the number of points for this round
            return (int) ownMove + (int) result;
        }

        private static Result GetResult(Move ownMove, Move opponentMove)
        {
            if (ownMove == opponentMove)
            {
                // Draw if moves are the same
                return Result.Draw;
            }

            switch (ownMove)
            {
                case Move.Rock when opponentMove == Move.Scissors: // Rock beats scissors
                case Move.Paper when opponentMove == Move.Rock: // Paper beats rock
                case Move.Scissors when opponentMove == Move.Paper: // Scissors beat paper
                    return Result.Win;
                default:
                    // Any other combination is a loss
                    return Result.Loss;
            }
        }
    }
}
