namespace CoderbyteChallenges.Tools
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void WhenToArrayOfStringsThenReturnArrayOfStrings()
        {
            var str = "abc";

            var arrayOfStrings = str.ToArrayOfStrings();

            Check.That(arrayOfStrings).ContainsExactly(new[] { "a", "b", "c" });
        }
    }
}
