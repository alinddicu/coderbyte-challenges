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
            const string str = "abc";

            var arrayOfStrings = str.ToArrayOfStrings();

            Check.That(arrayOfStrings).ContainsExactly(new[] { "a", "b", "c" });
        }

        [TestMethod]
        public void CheckIsLetter()
        {
            Check.That("a".IsLetter()).IsTrue();
            Check.That("1".IsLetter()).IsFalse();
            Check.That("*".IsLetter()).IsFalse();
            Check.That("ab".IsLetter()).IsFalse();
            Check.That("1b".IsLetter()).IsFalse();
            Check.That("".IsLetter()).IsFalse();
        }

        [TestMethod]
        public void CheckIndexesOf()
        {
            Check.That("a".IndexesOf('a')).ContainsExactly(new[] { 0 });
            Check.That("'".IndexesOf('\'')).ContainsExactly(new[] { 0 });
            Check.That("'".IndexesOf('a')).IsEmpty();
            Check.That("aa".IndexesOf('a')).ContainsExactly(new[] { 0, 1 });
            Check.That("aba".IndexesOf('a')).ContainsExactly(new[] { 0, 2 });
        }
    }
}
