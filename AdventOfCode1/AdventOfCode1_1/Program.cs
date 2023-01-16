// .NET
using System;
using System.Linq;

namespace AdventOfCode1_1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Get the filepath
            string filepath = args.Single();

            // Get all calorie counts
            var calorieCounts = Utils.CalorieCountUtils.GetCalorieCounts(filepath);

            // Get the max calorie count
            int maxCalorieCount = calorieCounts
                .OrderByDescending(x => x)
                .Take(3)
                .Sum();

            // Output max calorie count
            Console.WriteLine(maxCalorieCount);
        }
    }
}
