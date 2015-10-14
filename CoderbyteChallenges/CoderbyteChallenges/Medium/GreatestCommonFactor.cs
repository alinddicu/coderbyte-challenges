namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CoderbyteChallenges.Tools;

    public class GreatestCommonFactor
    {
        public int Execute(int n1, int n2)
        {
            var primeNumbers = new PrimeNumbers().Execute(1000).ToArray();

            var factors1 = primeNumbers.Where(pn => pn < n1).Where(pn => n1 % pn == 0).Concat(new List<int> { 1 });
            var factors2 = primeNumbers.Where(pn => pn < n2).Where(pn => n2 % pn == 0).Concat(new List<int> { 1 });

            return factors1.Intersect(factors2).Multiply();
        }
    }
}
