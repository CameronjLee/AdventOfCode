// .NET
using System.Collections.Generic;
using System.IO;

namespace Utils
{
    public static class CalorieCountUtils
    {
        public static IEnumerable<int> GetCalorieCounts(string filepath)
        {
            // A list of calorie counts initialized with a single value of zero
            var calorieCounts = new List<int> { 0 };

            using (var streamReader = new StreamReader(filepath))
            {
                // The current line
                string line;

                // Loop through all lines
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Line is empty and is not the final line
                    if (line == string.Empty && streamReader.Peek() != -1)
                    {
                        // Append a zero to the list of calorie counts
                        calorieCounts.Add(0);
                        continue;
                    }

                    // Increment final calorie count in list
                    calorieCounts[calorieCounts.Count - 1] += int.Parse(line);
                }
            }

            return calorieCounts;
        }
    }
}
