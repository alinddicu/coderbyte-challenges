namespace CoderbyteChallenges
{
    public class FirstReverse
    {
        public string Execute(string intialString)
        {
            var reversedString = string.Empty;
            var charArray = intialString.ToCharArray();

            for (var index = GetLastCaracterPosition(charArray); HasMoreCaractersToReverse(index); index--)
            {
                reversedString += charArray[index];
            }

            return reversedString;
        }

        private static bool HasMoreCaractersToReverse(int index)
        {
            return index >= 0;
        }

        private static int GetLastCaracterPosition(char[] charArray)
        {
            return charArray.Length - 1;
        }
    }
}
