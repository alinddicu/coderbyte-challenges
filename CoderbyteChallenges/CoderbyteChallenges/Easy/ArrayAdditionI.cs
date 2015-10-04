namespace CoderbyteChallenges.Easy
{
    using System.Linq;

    public class ArrayAdditionI
    {
        public bool Execute(params int[] numbers)
        {
            return numbers
                .Select(n => new { Number = n, Sum = numbers.Where(n1 => n1 < n).Sum(n2 => n2) })
                .Any(o => o.Number == o.Sum);
        }
    }
}
