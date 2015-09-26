namespace CoderbyteChallenges
{
    public class AbCheck
    {
        public bool Execute(string str)
        {
            var indexOfA = str.IndexOf('a');
            var expectedIndexOfB = indexOfA + 3;

            return str.IndexOf('b') == expectedIndexOfB;
        }
    }
}
