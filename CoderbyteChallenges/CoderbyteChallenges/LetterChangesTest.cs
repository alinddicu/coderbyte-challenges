namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class LetterChangesTest
    {
        /*
         
         Replace every letter in the string with the letter following it in the alphabet (ie. c becomes d, z becomes a). 
         Then capitalize every vowel in this new string (a, e, i, o, u) and finally return this modified string. 
         
         */

        [TestMethod]
        [Ignore]
        public void GivenHello3WhenLetterChangesThenReturnIfmmp3()
        {
            var result = new LetterChanges().Execute("Hello3");

            Check.That(result).IsEqualTo("Ifmmp3");
        }

        [TestMethod]
        public void GivenheWhenLetterChangesThenReturnif()
        {
            var result = new LetterChanges().Execute("he");

            Check.That(result).IsEqualTo("if");
        }

        [TestMethod]
        public void GivenHeWhenLetterChangesThenReturnIf()
        {
            var result = new LetterChanges().Execute("He");

            Check.That(result).IsEqualTo("If");
        }
    }
}
