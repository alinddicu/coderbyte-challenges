namespace CoderbyteChallenges.Easy
{
    public class SimpleAdding
    {
        public int Execute(int limitNumber)
        {
            var sum = 0;
            for (var number = 0; number <= limitNumber; number++)
            {
                sum += number;
            }

            return sum;
        }
    }
}
