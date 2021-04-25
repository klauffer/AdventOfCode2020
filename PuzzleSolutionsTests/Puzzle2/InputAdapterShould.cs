using System.Collections.Generic;
using System.Linq;
using PuzzleSolutions.Day2;
using Xunit;

namespace PuzzleSolutionsTests.Puzzle2
{
    public class InputAdapterShould
    {
        [Fact]
        public void Find_Minimum_Occurrence()
        {
            var inputs = new List<string>() { "1-3 a: abcde" };
            var passwordInputs = InputAdapter.Parse(inputs);

            var passwordInput = passwordInputs.FirstOrDefault();

            Assert.Equal(1, passwordInput.Index1);
        }

        [Fact]
        public void Find_Maximum_Occurrence()
        {
            var inputs = new List<string>() { "1-3 a: abcde" };
            var passwordInputs = InputAdapter.Parse(inputs);

            var passwordInput = passwordInputs.FirstOrDefault();

            Assert.Equal(3, passwordInput.Index2);
        }

        [Fact]
        public void Find_Required_Character()
        {
            var inputs = new List<string>() { "1-3 a: abcde" };
            var passwordInputs = InputAdapter.Parse(inputs);

            var passwordInput = passwordInputs.FirstOrDefault();

            Assert.Equal('a', passwordInput.requiredCharacter);
        }

        [Fact]
        public void Find_Password()
        {
            var inputs = new List<string>() { "1-3 a: abcde" };
            var passwordInputs = InputAdapter.Parse(inputs);

            var passwordInput = passwordInputs.FirstOrDefault();

            Assert.Equal("abcde", passwordInput.password);
        }
    }
}
