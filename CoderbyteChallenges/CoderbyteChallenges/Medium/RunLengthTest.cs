namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class RunLengthTest
    {
        /*
         
         have the function RunLength(str) take the str parameter being passed and return a compressed version of the string 
         using the Run-length encoding algorithm. 
         This algorithm works by taking the occurrence of each repeating character and outputting that number 
         along with a single character of the repeating sequence. 
         For example: "wwwggopp" would return 3w2g1o2p. 
          
         The string will not contain any numbers, punctuation, or symbols. 
         
         */

        [TestMethod]
        public void GivenaabbcdeWhenRunLengthThenReturn2a2b1c1d1e()
        {
            Check.That(new RunLength().Execute("aabbcde")).IsEqualTo("2a2b1c1d1e");
        }

        [TestMethod]
        public void GivenwwwbbbwWhenRunLengthThenReturn3w3b1w()
        {
            Check.That(new RunLength().Execute("wwwbbbw")).IsEqualTo("3w3b1w");
        }
    }
}
