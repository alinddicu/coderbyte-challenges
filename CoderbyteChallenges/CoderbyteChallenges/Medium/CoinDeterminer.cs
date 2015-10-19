namespace CoderbyteChallenges.Medium
{
    using System.Linq;

    public class CoinDeterminer
    {
        private static readonly int[] Coins = { 1, 5, 7, 9, 11 };

        public int Execute(int sum)
        {
            var maxCoin = Coins.LastOrDefault(m => m <= sum);
            var count = 1;
            var rest = sum - maxCoin;
            do
            {
                var coin = Coins.Except(new[] { maxCoin }).LastOrDefault(c => rest - c >= 0);
                rest = rest - coin;
                count++;
            } while (rest > 0);

            return count;
        }
    }
}
