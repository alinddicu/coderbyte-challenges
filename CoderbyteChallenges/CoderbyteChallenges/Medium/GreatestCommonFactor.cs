namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Tools;

    public class GreatestCommonFactor
    {
        public int Execute(int numberToFactor1, int numberToFactor2)
        {
            var primeNumbers = new PrimeNumbers().Execute(Min(numberToFactor1, numberToFactor2)).ToArray();

            var factors1 = GetFactors(InitFactorsList(), numberToFactor1, FilterPrimeNumbers(numberToFactor1, primeNumbers).ToArray());
            var factors2 = GetFactors(InitFactorsList(), numberToFactor2, FilterPrimeNumbers(numberToFactor2, primeNumbers).ToArray());

            var factorGroups1 = factors1.GroupBy(o => o).Select(g => new FactorGroup(g.Key, g.Count()));
            var factorGroups2 = factors2.GroupBy(o => o).Select(g => new FactorGroup(g.Key, g.Count()));

            var minFactorGroups = from g1 in factorGroups1
                          join g2 in factorGroups2 on g1.Factor equals g2.Factor
                          select new FactorGroup(g2.Factor, Min(g1.Count, g2.Count));

            return minFactorGroups.Select(Power).Multiply();
        }

        private static IEnumerable<int> FilterPrimeNumbers(int numberToFactor, IEnumerable<int> primeNumbers)
        {
            return primeNumbers.Where(pn => pn < numberToFactor);
        }

        private static int Power(FactorGroup f)
        {
            return (int)Math.Pow(f.Factor, f.Count);
        }

        private static int Min(params int[] numbers)
        {
            return numbers.Min(n => n);
        }

        private static List<int> InitFactorsList()
        {
            return new List<int> { 1 };
        }

        private static IEnumerable<int> GetFactors(
            ICollection<int> factors, 
            int number,
            ICollection<int> primeNumbers)
        {
            foreach (var pn in primeNumbers)
            {
                var rest = number % pn;
                if (rest == 0)
                {
                    factors.Add(pn);
                    return GetFactors(factors, number / pn, primeNumbers);
                }

                if (number == 1)
                {
                    break;
                }
            }

            return factors;
        }

        private struct FactorGroup
        {
            public FactorGroup(int factor, int count)
                : this()
            {
                Factor = factor;
                Count = count;
            }

            public int Factor { get; private set; }

            public int Count { get; private set; }

            public override string ToString()
            {
                return string.Format("Factor : {0}, Count : {1}", Factor, Count);
            }
        }
    }
}