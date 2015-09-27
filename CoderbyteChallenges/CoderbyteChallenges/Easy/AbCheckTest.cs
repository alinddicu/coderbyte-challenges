namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AbCheckTest
    {
        /*
         
         take the str parameter being passed and return the string true 
         if the characters a and b are separated by exactly 3 places anywhere in the string at least once 
         (ie. "lane borrowed" would result in true because there is exactly three characters between a and b). 
         Otherwise return the string false. 
         
         */

        [TestMethod]
        public void WhenAfterSpacebadlyThenReturnFalse()
        {
            Check.That(new AbCheck().Execute("after badly")).IsFalse();
        }

        [TestMethod]
        public void WhenLauraSpacesobsThenReturnFalse()
        {
            Check.That(new AbCheck().Execute("Laura sobs")).IsTrue();
        }

        [TestMethod]
        public void Whena123bThenTrue()
        {
            Check.That(new AbCheck().Execute("a123b")).IsTrue();
        }

        [TestMethod]
        public void Whena123dThenTrue()
        {
            Check.That(new AbCheck().Execute("a123d")).IsFalse();
        }

        [TestMethod]
        public void When0a23a567b8ThenTrue()
        {
            Check.That(new AbCheck().Execute("0a23a567b9")).IsTrue();
        }
    }
}
