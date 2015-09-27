namespace CoderbyteChallenges
{
    using System.Linq;
    using Tools;

    public class Palindrome
    {
        public bool Execute(string str)
        {
            str = str.Replace(" ", string.Empty);

            return str
                .ToArrayOfStrings()
                .Select((letter, index) => new { Letter = letter, OppositeLetter = GetOppositeLetter(str, index) })
                .All(o => o.Letter == o.OppositeLetter);
        }

        private static string GetOppositeLetter(string str, int index)
        {
            return str[str.Length - 1 - index] + string.Empty;
        }
    }
}
