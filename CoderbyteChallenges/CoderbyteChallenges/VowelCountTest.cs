namespace CoderbyteChallenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class VowelCountTest
    {
        /*
         
         take the str string parameter being passed and return the number of vowels the string contains 
         (ie. "All cows eat grass" would return 5). Do not count y as a vowel for this challenge
         
         */

        [TestMethod]
        public void WhenHelloThen2()
        {
            Check.That(new VowelCount().Execute("hello")).IsEqualTo(2);
        }

        [TestMethod]
        public void WhenCoderbyteThen3()
        {
            Check.That(new VowelCount().Execute("Coderbyte")).IsEqualTo(3);
        }
    }
}
