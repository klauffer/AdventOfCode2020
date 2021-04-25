using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PuzzleSolutions.Day2
{
    internal static class InputAdapter
    {
        public static IReadOnlyList<Password> Parse(IEnumerable<string> inputs)
        {
            var regEx = new Regex(@"^(?<minimum>\d*)-(?<maximum>\d*)\s*(?<letter>[a-zA-Z]):\s(?<password>[a-zA-Z]*)");
            var passwords = new List<Password>();
            foreach(var input in inputs)
            {
                var matches = regEx.Matches(input);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    Int32.TryParse(groups["minimum"].Value, out var minimum);
                    Int32.TryParse(groups["maximum"].Value, out var maximum);
                    var letter = char.Parse(groups["letter"].Value);
                    var password = groups["password"].Value;
                    passwords.Add(new Password(letter, minimum, maximum, password));
                }
            }
            return passwords;
        }

    }
}
