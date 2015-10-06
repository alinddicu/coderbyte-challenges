namespace CoderbyteChallenges.Easy
{
    public class PowersOfTwo
    {
        public bool Execute(int number)
        {
            do
            {
                var rest = number % 2;
                if (rest != 0)
                {
                    return false;
                }

                number = number / 2;
            } while (number != 1);

            return true;
        }
    }
}
