using System.Collections.Generic;
using PuzzleSolutions.Day2;
using Xunit;

namespace PuzzleSolutionsTests.Puzzle2
{
    public class Question2PolicyShould
    {
        [Fact]
        public void Succeed_With_The_Correct_Letter_At_Exactly_One_Index()
        {
            var inputs = new List<string>()
            {
                "1-3 a: abcde",
            };

            var passwordPhilosophy = new Question2Policy(inputs);
            var actual = passwordPhilosophy.GetNumberOfValidPasswords();

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Fail_With_The_Correct_Letter_At_Both_Index()
        {
            var inputs = new List<string>()
            {
                "2-9 c: ccccccccc"
            };

            var passwordPhilosophy = new Question2Policy(inputs);
            var actual = passwordPhilosophy.GetNumberOfValidPasswords();

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Fail_With_The_Correct_Letter_At_neither_Index()
        {
            var inputs = new List<string>()
            {
                "1-3 b: cdefg"
            };

            var passwordPhilosophy = new Question2Policy(inputs);
            var actual = passwordPhilosophy.GetNumberOfValidPasswords();

            Assert.Equal(0, actual);
        }
    }
}
