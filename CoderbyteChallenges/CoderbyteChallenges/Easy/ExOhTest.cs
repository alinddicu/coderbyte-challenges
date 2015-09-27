namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]

    public class ExOhTest
    {
        /*
     
        take the str parameter being passed and return the string true if there is an equal number 
        of x's and o's, otherwise return the string false. 
        Only these two letters will be entered in the string, 
        no punctuation or numbers. For example: if str is "xooxxxxooxo" 
        then the output should return false because there are 6 x's and 5 o's.  
     
        */

        [TestMethod]
        public void GivenxooxxoWhenExOhThenReturnTrue()
        {
            Check.That(new ExOh().Execute("xooxxo")).IsTrue();
        }

        [TestMethod]
        public void GivenxWhenExOhThenReturnFalse()
        {
            Check.That(new ExOh().Execute("x")).IsFalse();
        }

        [TestMethod]
        public void GivenoxoWhenExOhThenReturnFalse()
        {
            Check.That(new ExOh().Execute("oxo")).IsFalse();
        }
    }
}