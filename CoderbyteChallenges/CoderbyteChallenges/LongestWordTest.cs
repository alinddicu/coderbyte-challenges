namespace CoderbyteChallenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class LongestWordTest
    {
        [TestMethod]
        public void Given1WordOf2And1WordOf3WhenLongestWordThenReturnTheWordOf3()
        {
            var result = new LongestWord().Execute("I am young");

            Check.That(result).IsEqualTo("young");
        }

        [TestMethod]
        public void GivenEmptyPhraseWhenLongestWordThenEmpty()
        {
            var result = new LongestWord().Execute("");

            Check.That(result).IsEqualTo("");
        }
    }
}
