namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class FirstReverseTest
    {
        /*
         
         For this challenge you will be reversing a string.
         
         */

        [TestMethod]
        public void GivenAbCWhenExecuteThenReturnCbA()
        {
            var result = new FirstReverse().Execute("AbC");

            Check.That(result).Equals("CbA");
        }
    }
}
