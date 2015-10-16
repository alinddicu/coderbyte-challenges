namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class TripleDoubleTest
    {
        /*
         
            have the function TripleDouble(num1,num2) take both parameters being passed, 
            and return true if there is a straight triple of a digit at any place in num1 and also a straight double of the same digit in num2. 
         
            For example: if num1 equals 451999277 and num2 equals 41177722899, then return 1 because 
            in the first parameter you have the straight triple 999 and you have a straight double, 99, of the same number in the second parameter. 
            If this isn't the case, return false. 
         
        */

        [TestMethod]
        public void Given465555And5579WhenExecuteThenReturnTrue()
        {
            Check.That(new TripleDouble().Execute(465555, 5579)).IsTrue();
        }

        [TestMethod]
        public void Given67844And66237WhenExecuteThenReturnTrue()
        {
            Check.That(new TripleDouble().Execute(67844, 66237)).IsFalse();
        }
    }
}
