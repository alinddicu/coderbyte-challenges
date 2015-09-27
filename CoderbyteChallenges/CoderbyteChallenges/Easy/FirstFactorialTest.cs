namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstFactorialTest
    {
        /*
         
         For this challenge you will be determining the factorial for a given number.
         
         */

        [TestMethod]
        public void Given0WhenFactorialThenReturn1()
        {
            var result = new FirstFactorial().Execute(0);

            Check.That(result).IsEqualTo(1);
        }

        [TestMethod]
        public void Given3WhenFactorialThenReturn6()
        {
            var result = new FirstFactorial().Execute(3);

            Check.That(result).IsEqualTo(6);
        }
    }
}
