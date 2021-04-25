using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day2
{
    public class Question1Policy : PasswordPhilosophy
    {
        public Question1Policy(IEnumerable<string> inputs) : base(inputs)
        {
        }

        protected override bool IsPasswordValid(Password password)
        {
            var numberOfTimesLetterOccurs = password.password
                                                .Where(letter => letter == password.requiredCharacter)
                                                .Count();
            if (numberOfTimesLetterOccurs >= password.Index1 &&
                numberOfTimesLetterOccurs <= password.Index2)
            {
                return true;
            }
            return false;
        }
    }
}
