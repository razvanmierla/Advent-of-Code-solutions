using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    internal class Day1
    {

        public static int GetResult(string inputPath)
        {
            string[] lines = File.ReadAllLines(inputPath);

            int result = -1;
            int previousSum = -1;
            for (int i = 0; i < lines.Length; i++)
            {
                if (i + 2 == lines.Length)
                {
                    break;
                }
                int sum = Int32.Parse(lines[i]) + Int32.Parse(lines[i + 1]) + Int32.Parse(lines[i + 2]);
                if (previousSum < sum)
                {
                    result++;
                }
                previousSum = sum;
            }

            return result;
        }

    }
}
