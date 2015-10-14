namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class StringScrambleTest
    {
        /*
         
         have the function StringScramble(str1,str2) take both parameters being passed and return the string true 
         if a portion of str1 characters can be rearranged to match str2, 
         otherwise return the string false. 
         
         For example: if str1 is "rkqodlw" and str2 is "world" the output should return true. Punctuation and symbols will not be entered with the parameters. 
         
         */

        [TestMethod]
        public void GivencdoreAndcoderWhenStringScrambleThenReturnTrue()
        {
            Check.That(new StringScramble().Execute("cdore","coder")).IsTrue();
        }

        [TestMethod]
        public void Givenh3llkoAndhelloWhenStringScrambleThenReturnTrue()
        {
            Check.That(new StringScramble().Execute("h3llko", "hello")).IsFalse();
        }
    }
}
