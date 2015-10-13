namespace CoderbyteChallenges.Tools
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void Given10WhenPrimeNumbersThenReturn2And3And5And7()
        {
            Check.That(new PrimeNumbers().Execute(10)).ContainsExactly(new[] { 2, 3, 5, 7 });
        }
    }
}
