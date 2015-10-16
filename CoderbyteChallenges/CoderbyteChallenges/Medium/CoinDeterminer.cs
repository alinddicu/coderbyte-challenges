namespace CoderbyteChallenges.Medium
{
    using System.Linq;

    public class CoinDeterminer
    {
        private static readonly int[] Coins = { 1, 5, 7, 9, 11 };

        public int Execute(int sum)
        {
            var count = 0;
            var rest = sum;
            do
            {
                var coin = Coins.LastOrDefault(c => rest - c >= 0);
                rest = rest - coin;
                count++;
            } while (rest > 0);

            return count;
        }
    }
}
