namespace CoderbyteChallenges.Easy
{
    using System.Linq;

    public class MeanMode
    {
        public bool Execute(params int[] numbers)
        {
            var mean = (int)numbers.Average();
            var maxGroup = numbers.GroupBy(n => n).Max(g => g.Count());
            var mode = numbers.GroupBy(n => n).First(g => g.Count() == maxGroup).Key;
            
            return mean == mode;
        }
    }
}
