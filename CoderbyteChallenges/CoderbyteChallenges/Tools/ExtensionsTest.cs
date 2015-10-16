namespace CoderbyteChallenges.Tools
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void Given123WhenMultiplyThen6()
        {
            Check.That(new[] { 1, 2, 3 }.Multiply()).IsEqualTo(6);
        }

        [TestMethod]
        public void GivenEmptyWhenMultiplyThen6()
        {
            Check.That((new int[0]).Multiply()).IsEqualTo(0);
        }

        [TestMethod]
        public void Given123WhenToArrayOfIntsThen123()
        {
            Check.That(123.ToArrayOfInts()).ContainsExactly(new[] { 1, 2, 3 });
        }
    }
}
