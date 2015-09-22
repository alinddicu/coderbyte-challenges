namespace CoderbyteChallenges
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstReverseTest
    {
        [TestMethod]
        public void GivenAbCWhenExecuteThenReturnCbA()
        {
            var result = new FirstReverse().Execute("AbC");

            Check.That(result).Equals("CbA");
        }
    }
}
