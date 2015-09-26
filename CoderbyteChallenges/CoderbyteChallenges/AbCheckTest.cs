﻿namespace CoderbyteChallenges
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
        [Ignore]
        public void WhenLauraSpacesobsThenReturnFalse()
        {
            Check.That(new AbCheck().Execute("Laura sobs")).IsTrue();
        }
    }
}
