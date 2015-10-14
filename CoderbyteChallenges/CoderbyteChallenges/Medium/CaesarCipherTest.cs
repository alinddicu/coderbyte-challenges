namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class CaesarCipherTest
    {
        /*
         
            have the function CaesarCipher(str,num) take the str parameter 
            and perform a Caesar Cipher shift on it using the num parameter as the shifting number. 
            A Caesar Cipher works by shifting each letter in the string N places down 
            in the alphabet (in this case N will be num). 
         
            Punctuation, spaces, and capitalization should remain intact. 
            For example if the string is "Caesar Cipher" and num is 2 the output should be "Ecguct Ekrjgt".
         
         */

        [TestMethod]
        public void GivenHelloWith4WhenCaesarCipherThenReturnLipps()
        {
            Check.That(new CaesarCipher().Execute("hello", 4)).IsEqualTo("lipps");
        }

        [TestMethod]
        public void GivenAbcWith0WhenCaesarCipherThenReturnAbc()
        {
            Check.That(new CaesarCipher().Execute("abc", 0)).IsEqualTo("abc");
        }
    }
}
