namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LetterCapitalize
    {
        public string Execute(string input)
        {
            return input.Substring(0, 1).ToUpper() + input.Remove(0, 1);
        }
    }
}
