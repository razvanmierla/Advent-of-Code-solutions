using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    internal class Day3 : IDaySolution
    {
        public static int inputStringsLength = 0;

        public int GetResult(string inputPath)
        {
            string[] lines = File.ReadAllLines(inputPath);
            inputStringsLength = lines.First().Length;

            int oxygenGeneratorRating = getRating(lines, true);
            int CO2ScrubberRating = getRating(lines, false);

            return oxygenGeneratorRating * CO2ScrubberRating;
        }

        public static int getRating(string[] lines, bool isOxygenRating)
        {
            List<string> filteredStrings = new List<string>(lines);
            int index = 0;
            for (int i = 0; i < inputStringsLength; i++)
            {
                var test = lines.GroupBy(line => line.First());
                int max = -1;
                char toAdd = '1';

                bool sameMax = false;
                foreach (var elem in test)
                {
                    if (max == elem.Count())
                    {
                        sameMax = true;
                    }
                    if (max < elem.Count())
                    {
                        toAdd = elem.Key;
                        max = elem.Count();
                    }
                }

                FilterArraysOfStrings(ref lines, ref filteredStrings, index, toAdd, sameMax, isOxygenRating);

                index++;

                for (int j = 0; j < lines.Count(); j++)
                {
                    lines[j] = lines[j].Substring(1);
                }
            }

            return Convert.ToInt32(filteredStrings.First(), 2);
        }

        private static void FilterArraysOfStrings(ref string[] lines, ref List<string> filteredStringsForOxygen, 
                                                  int index, char toAdd, bool sameMax, bool isOxygenRating)
        {
            if (sameMax)
            {
                if (filteredStringsForOxygen.Count > 1)
                {
                    filteredStringsForOxygen = filteredStringsForOxygen.Where(line => line[index] == (isOxygenRating ? '1' : '0'))
                                                                       .ToList();
                    lines = lines.Where(line => line.First() == (isOxygenRating ? '1' : '0'))
                                 .ToArray();
                }
            }
            else
            {
                if (filteredStringsForOxygen.Count > 1)
                {
                    filteredStringsForOxygen = filteredStringsForOxygen.Where(line => isOxygenRating ? (line[index] == toAdd) : 
                                                                                                       (line[index] != toAdd))
                                                                       .ToList();

                    lines = lines.Where(line => isOxygenRating ? (line.First() == toAdd) : 
                                                                 (line.First() != toAdd))
                                 .ToArray();
                }
            }
        }
    }
}
