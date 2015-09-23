namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Tools;

    public class LetterCapitalize
    {
        public string Execute(string input)
        {
            var words = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words.Select(w => CapitalizeWord(w)));
        }

        private static string CapitalizeWord(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Remove(0, 1);
        }
    }
}
