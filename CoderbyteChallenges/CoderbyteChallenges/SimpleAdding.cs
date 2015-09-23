namespace CoderbyteChallenges
{
    public class SimpleAdding
    {
        public int Execute(int limitNumber)
        {
            var sum = 0;
            for (int number = 0; number <= limitNumber; number++)
            {
                sum += number;
            }

            return sum;
        }
    }
}
