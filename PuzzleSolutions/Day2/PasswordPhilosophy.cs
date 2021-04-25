using System.Collections.Generic;
using System.Linq;

namespace PuzzleSolutions.Day2
{
    public abstract class PasswordPhilosophy
    {
        private readonly IReadOnlyList<Password> _passwords;

        public PasswordPhilosophy(IEnumerable<string> inputs)
        {
            _passwords = InputAdapter.Parse(inputs);
        }
        public int GetNumberOfValidPasswords() => _passwords.Select(IsPasswordValid)
                                                            .Where(result => result == true)
                                                            .Count();

        protected abstract bool IsPasswordValid(Password password);
    }
}
