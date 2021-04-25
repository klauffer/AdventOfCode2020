using System;
using Day2 = PuzzleSolutions.Day2;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2020 Puzzle Answers");
            Console.WriteLine("Day 2:");

            var question1Policy = new Day2.Question1Policy(Day2.PuzzleInput.ToList());
            Console.WriteLine($"question 1: The number of valid passwords are {question1Policy.GetNumberOfValidPasswords()}");

            var question2Policy = new Day2.Question2Policy(Day2.PuzzleInput.ToList());
            Console.WriteLine($"question 2: The number of valid passwords are {question2Policy.GetNumberOfValidPasswords()}");
        }
    }
}
