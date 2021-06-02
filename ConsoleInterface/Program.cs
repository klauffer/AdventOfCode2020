using System;
using Day2 = PuzzleSolutions.Day2;
using Day3 = PuzzleSolutions.Day3;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Advent Of Code 2020 Puzzle Answers");

                var question1Policy = new Day2.Question1Policy(Day2.PuzzleInput.ToList());
                var question2Policy = new Day2.Question2Policy(Day2.PuzzleInput.ToList());
                PrintDailyPuzzle(2, question1Policy.GetNumberOfValidPasswords().ToString(), question2Policy.GetNumberOfValidPasswords().ToString());

                var tobogganTrajectory = Day3.TobogganTrajectory.StartPuzzle(Day3.PuzzleInput.ToList());
                PrintDailyPuzzle(3, tobogganTrajectory.GetNumberOfTreesInPath().ToString(), tobogganTrajectory.GetNumberOfTreesInMultiplePaths().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static void PrintDailyPuzzle(int dayNumber, string question1Solution, string question2Solution)
        {
            Console.WriteLine($"");
            Console.WriteLine($"Day {dayNumber}:");

            var question1Policy = new Day2.Question1Policy(Day2.PuzzleInput.ToList());
            Console.WriteLine($"\tquestion 1: The number of valid passwords: {question1Solution}");
            var question2Policy = new Day2.Question2Policy(Day2.PuzzleInput.ToList());
            Console.WriteLine($"\tquestion 2: The number of valid passwords: {question2Solution}");
        }
    }
}
