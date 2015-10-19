namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Linq;

    public class CoinDeterminer
    {
        private static readonly int[] Coins = { 1, 5, 7, 9, 11 };
        private static readonly int MaxCoin = Coins.Max(c => c);

        public int Execute(int sum)
        {
            var minNumberOfCoins = Math.Round((decimal)sum / MaxCoin, MidpointRounding.AwayFromZero);
            var count = 1;
            var rest = sum - MaxCoin;
            do
            {
                var coin = Coins.Except(new[] { MaxCoin }).LastOrDefault(c => rest - c >= 0);
                rest = rest - coin;
                count++;
            } while (rest > 0);

            return count;
        }
    }
}
