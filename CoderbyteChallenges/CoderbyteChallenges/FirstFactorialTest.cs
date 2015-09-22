namespace CoderbyteChallenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstFactorialTest
    {
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
