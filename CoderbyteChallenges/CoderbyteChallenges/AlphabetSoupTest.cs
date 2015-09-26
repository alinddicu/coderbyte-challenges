namespace CoderbyteChallenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AlphabetSoupTest
    {
        /*
         
         Take the str string parameter being passed and return the string with the letters in alphabetical order (ie. hello becomes ehllo). 
         Assume numbers and punctuation symbols will not be included in the string. 
         
         */

        [TestMethod]
        public void GivencoderbyteWhenAlphabetSoupThenReturnbcdeeorty()
        {
            Check.That(new AlphabetSoup().Execute("coderbyte")).IsEqualTo("bcdeeorty");
        }
    }
}
