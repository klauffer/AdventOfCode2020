using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day2
{
    public sealed class Question2Policy : PasswordPhilosophy
    {
        public Question2Policy(IEnumerable<string> inputs) : base(inputs)
        {
        }

        protected override bool IsPasswordValid(Password password)
        {
            var isLetterAtFirstIndex = password.password.ElementAt(password.Index1 - 1) == password.requiredCharacter;
            var isLetterAtSecondIndex = password.password.ElementAt(password.Index2 - 1) == password.requiredCharacter;

            return isLetterAtFirstIndex ^ isLetterAtSecondIndex; //XOR Operation
        }
    }
}
