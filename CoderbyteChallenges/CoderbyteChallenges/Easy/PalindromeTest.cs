namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class PalindromeTest
    {
        /*
         
            take the str parameter being passed and return the string true if the parameter is a palindrome, 
            (the string is the same forward as it is backward) otherwise return the string false. 
            For example: "racecar" is also "racecar" backwards. 
            Punctuation and numbers will not be part of the string. 
         
         */

        [TestMethod]
        public void GivenNeverSpaceOddSpaceOrSpaceEvenWhenPalindromeThenTrue()
        {
            Check.That(new Palindrome().Execute("never odd or even")).IsTrue();
        }

        [TestMethod]
        public void GivenEyeWhenPalindromeThenTrue()
        {
            Check.That(new Palindrome().Execute("eye")).IsTrue();
        }

        [TestMethod]
        public void GivenEytWhenPalindromeThenTrue()
        {
            Check.That(new Palindrome().Execute("eyt")).IsFalse();
        }
    }
}
