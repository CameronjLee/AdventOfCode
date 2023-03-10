// .NET
using System;
using System.Linq;

namespace AdventOfCode1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // Get the filepath
            string filepath = args.Single();

            // Get all calorie counts
            var calorieCounts = Utils.CalorieCountUtils.GetCalorieCounts(filepath);

            // Get the max calorie count
            int maxCalorieCount = calorieCounts.Max();

            // Output max calorie count
            Console.WriteLine(maxCalorieCount);
        }
    }
}
