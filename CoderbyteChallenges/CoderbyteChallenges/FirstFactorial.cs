namespace CoderbyteChallenges
{
    public class FirstFactorial
    {
        public int Execute(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            var factorial = 1;
            for (int countDown = n; countDown > 0; countDown--)
            {
                factorial = factorial * countDown;
            }

            return factorial;
        }
    }
}
