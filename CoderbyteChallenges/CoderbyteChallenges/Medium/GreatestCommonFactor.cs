namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Tools;

    public class GreatestCommonFactor
    {
        public int Execute(int n1, int n2)
        {
            var primeNumbers = new PrimeNumbers().Execute(new[] { n1, n2 }.Min(n => n)).ToArray();

            var factors1 = GetFactors(InitFactorsList(), n1, primeNumbers.Where(pn => pn < n1).ToArray());
            var factors2 = GetFactors(InitFactorsList(), n2, primeNumbers.Where(pn => pn < n2).ToArray());

            var groups1 = factors1.GroupBy(o => o).Select(g => new Group(g.Key, g.Count()));
            var groups2 = factors2.GroupBy(o => o).Select(g => new Group(g.Key, g.Count()));

            var factors = from g1 in groups1
                          join g2 in groups2 on g1.Number equals g2.Number
                          select new Group(g2.Number, new[] { g1.Count, g2.Count }.Min(o => o));

            return factors.Select(f => (int)Math.Pow(f.Number, f.Count)).Multiply();

            throw new NotImplementedException();
        }

        private static List<int> InitFactorsList()
        {
            return new List<int> { 1 };
        }

        private static IEnumerable<int> GetFactors(List<int> factors, int number, int[] primeNumbers)
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

        private struct Group
        {
            public Group(int number, int count)
                : this()
            {
                Number = number;
                Count = count;
            }

            public int Number { get; private set; }

            public int Count { get; private set; }

            public override string ToString()
            {
                return string.Format("Number : {0}, Count : {1}", Number, Count);
            }
        }
    }
}