namespace CoderbyteChallenges.Medium
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class PrimeTimeTest
    {
        /*
         
         have the function PrimeTime(num) take the num parameter being passed and 
            return the string true if the parameter is a prime number, 
            otherwise return the string false. 
         The range will be between 1 and 2^16.          
         
         */

        [TestMethod]
        public void Given012WhenPrimeTimeThenReturnFalse()
        {
            new List<int> { 0, 1, 2 }.ForEach(n => Check.That(new PrimeTime().Execute(n)).IsFalse());
        }

        [TestMethod]
        public void Given5WhenPrimeTimeThenReturnTrue()
        {
            Check.That(new PrimeTime().Execute(5)).IsTrue();
        }

        [TestMethod]
        public void Given19WhenPrimeTimeThenReturnTrue()
        {
            Check.That(new PrimeTime().Execute(19)).IsTrue();
        }

        [TestMethod]
        public void Given111WhenPrimeTimeThenReturnFalse()
        {
            Check.That(new PrimeTime().Execute(111)).IsFalse();
        }
    }
}
