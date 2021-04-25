using System.Collections.Generic;
using PuzzleSolutions.Day2;
using Xunit;

namespace PuzzleSolutionsTests.Puzzle2
{
    public class Question1PolicyShould
    {
        [Fact]
        public void Get_The_Correct_Number_Of_Valid_Passwords()
        {
            var inputs = new List<string>()
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };

            var passwordPhilosophy = new Question1Policy(inputs);
            var actual = passwordPhilosophy.GetNumberOfValidPasswords();

            Assert.Equal(2, actual);
        }
    }
}
