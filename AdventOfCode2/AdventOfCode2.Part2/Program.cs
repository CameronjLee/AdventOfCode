// .NET
using System;
using System.IO;
using System.Linq;

// Application
using AdventOfCode2.Enums;

namespace AdventOfCode2.Part2
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
            // Get the opponent's move. This will be A, B or C and will be converted to Rock, Paper
            // or scissors.
            var opponentMove = (Move) (line[0] - 'A' + 1);

            // Get the result. This will be X, Y or Z and will be converted to loss, draw or win.
            var result = (Result) (3*(line[2] - 'X'));

            // Get the move that must be made to obtain the desired result.
            var move = GetMove(opponentMove, result);

            return (int) move + (int) result;
        }

        private static Move GetMove(Move opponentMove, Result result)
        {
            if (result == Result.Draw)
            {
                // Copy opponent's move to draw
                return opponentMove;
            }

            switch (opponentMove)
            {
                case Move.Rock when result == Result.Loss:
                case Move.Paper when result == Result.Win:
                    // Scissors beat paper but lose to rock
                    return Move.Scissors;
                case Move.Paper when result == Result.Loss:
                case Move.Scissors when result == Result.Win:
                    // Rock beats scissors but loses to paper
                    return Move.Rock;
                default:
                    // Paper beats rock but loses to scissors
                    return Move.Paper;
            }
        }
    }
}
