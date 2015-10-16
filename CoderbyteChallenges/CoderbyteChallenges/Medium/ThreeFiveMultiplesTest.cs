namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class ThreeFiveMultiplesTest
    {
        /*
         
         have the function ThreeFiveMultiples(num) return the sum of all the multiples of 3 and 5 that are below num. 
         For example: if num is 10, the multiples of 3 and 5 that are below 10 are 3, 5, 6, and 9, 
         and adding them up you get 23, so your program should return 23.
         
         */

        [TestMethod]
        public void Given10WhenThreeFiveMultiplesThenReturn23()
        {
            Check.That(new ThreeFiveMultiples().Execute(10)).IsEqualTo(23);
        }
    }
}
