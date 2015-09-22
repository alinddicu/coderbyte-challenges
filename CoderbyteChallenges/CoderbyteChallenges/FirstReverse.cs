namespace CoderbyteChallenges
{
    public class FirstReverse
    {
        public string Execute(string intialString)
        {
            var reversedString = string.Empty;
            var charArray = intialString.ToCharArray();

            for (var index = charArray.Length - 1; index >= 0; index--)
            {
                reversedString += charArray[index];
            }

            return reversedString;
        }
    }
}
