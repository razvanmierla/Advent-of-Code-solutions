using AdventOfCode2021;
using System.Reflection;

class TestClass
{
    static void Main()
    {
        string dirPath = $"{Directory.GetCurrentDirectory()}\\Puzzle_Inputs";
        string day1_inputPath = $"{dirPath}\\input_day1.txt";
        string day2_inputPath = $"{dirPath}\\input_day2.txt";
        string day3_inputPath = $"{dirPath}\\input_day3.txt";

        var Day1_result = Day1.GetResult(day1_inputPath);
        var Day2_result = Day2.GetResult(day2_inputPath);
        int Day1_result = new Day1().GetResult(day1_inputPath);
        var Day2_result = new Day2().GetResult(day2_inputPath);
        var Day3_result = new Day3().GetResult(day3_inputPath);
    }
}