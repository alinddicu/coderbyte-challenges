namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Tools;

    public class AlphabetSoup
    {
        public string Execute(string input)
        {
            return string.Join(string.Empty, input.ToArrayOfStrings().OrderBy(s => s));
        }
    }
}
