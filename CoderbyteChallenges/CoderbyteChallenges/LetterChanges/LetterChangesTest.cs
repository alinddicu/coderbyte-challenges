namespace CoderbyteChallenges.LetterChanges
{
    using System;
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
        public void GivenHello3WhenLetterChangesThenReturnIfmmp3()
        {
            var result = new LetterChanges().Execute("Hello3");

            Check.That(result).IsEqualTo("Ifmmp3");
        }

        [TestMethod]
        public void GivenheWhenLetterChangesThenReturnif()
        {
            var result = new LetterChanges().Execute("he");

            Check.That(result).IsEqualTo("If");
        }

        [TestMethod]
        public void GivenHeWhenLetterChangesThenReturnIf()
        {
            var result = new LetterChanges().Execute("He");

            Check.That(result).IsEqualTo("If");
        }

        [TestMethod]
        public void GivenfuntimesWhenLetterChangesThenReturngvOUjnft()
        {
            var result = new LetterChanges().Execute("fun times!");

            Check.That(result).IsEqualTo("gvO Ujnft!");
        }

        [TestMethod]
        public void GivenZzWhenLetterChangesThenReturnAa()
        {
            var result = new LetterChanges().Execute("Zz");

            Check.That(result).IsEqualTo("AA");
        }

        [TestMethod]
        public void GivenUnknownLetterWhenLetterChangesThenThrow()
        {
            Check.ThatCode(() => new LetterChanges().Execute("ö")).Throws<InvalidOperationException>();
        }
    }
}
