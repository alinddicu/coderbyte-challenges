namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class ArrayAdditionITest
    {
        [TestMethod]
        public void Given5And7And16And1And2WhenArrayAdditionIThenFalse()
        {
            var result = new ArrayAdditionI().Execute(5, 7, 16, 1, 2);

            Check.That(result).IsFalse();
        }


        [TestMethod]
        public void Given3And5AndMinus1And7And12WhenArrayAdditionIThenTrue()
        {
            var result = new ArrayAdditionI().Execute(3, 5, -1, 7, 12);

            Check.That(result).IsTrue();
        }
    }
}
