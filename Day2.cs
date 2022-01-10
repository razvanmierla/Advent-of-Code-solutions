using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    internal class Day2
    {
        public static int GetResult(string inputPath)
        {
            string[] lines = File.ReadAllLines(inputPath);

            int horizontal = 0;
            int depth = 0;
            int aim = 0;
            foreach (string line in lines)
            {
                if (line.Contains("forward"))
                {
                    horizontal += Int32.Parse(line[line.Length - 1].ToString());
                    depth = depth + Int32.Parse(line[line.Length - 1].ToString()) * aim;
                }
                if (line.Contains("up"))
                {
                    aim -= Int32.Parse(line[line.Length - 1].ToString());
                }
                if (line.Contains("down"))
                {
                    aim += Int32.Parse(line[line.Length - 1].ToString());
                }
                if (depth < 0)
                    depth = 0;
            }

            return horizontal * depth;
        }
    }
}
