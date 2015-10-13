namespace CoderbyteChallenges.Tools
{
    using System.Collections.Generic;
    using System.Linq;

    class PrimeNumbers
    {
        public IEnumerable<int> Execute(int limit)
        {
            var divisors = new List<int>();
            for (var i = 2; i < limit; i++)
            {
                divisors.Add(i);
            }

            var primeNumbers = new List<int>();
            for (var number = 2; number < limit; number++)
            {
                var divisor = 0;
                for (var i = 0; i < divisors.Count; i++)
                {
                    divisor = divisors[i];
                    if (divisor < number)
                    {
                        if (number % divisor == 0)
                        {
                            break;
                        }
                    }
                }

                if (divisor == divisors.Last())
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }
    }
}
