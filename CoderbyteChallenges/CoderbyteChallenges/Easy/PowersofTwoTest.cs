namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class PowersOfTwoTest
    {
        [TestMethod]
        public void Given4WhenPowersofTwoThenTrue()
        {
            Check.That(new PowersOfTwo().Execute(4)).IsTrue();
        }

        [TestMethod]
        public void Given6WhenPowersofTwoThenTrue()
        {
            Check.That(new PowersOfTwo().Execute(6)).IsFalse();
        }
    }
}
