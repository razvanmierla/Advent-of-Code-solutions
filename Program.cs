using AdventOfCode2021;
using System.Reflection;

class TestClass
{
    static void Main()
    {
        string dirPath = $"{Directory.GetCurrentDirectory()}\\Puzzle_Inputs";
        string day1_inputPath = $"{dirPath}\\input_day1.txt";
        string day2_inputPath = $"{dirPath}\\input_day2.txt";

        var Day1_result = Day1.GetResult(day1_inputPath);
        var Day2_result = Day2.GetResult(day2_inputPath);
    }
}