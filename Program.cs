using AdventOfCode2021;
using System.Reflection;

class TestClass
{
    static void Main()
    {
        string dirPath = $"{Directory.GetCurrentDirectory()}\\Puzzle_Inputs";
        string day1_inputPath = $"{dirPath}\\input_day1.txt";

        var Day1_result = Day1.GetResult(day1_inputPath);
    }
}