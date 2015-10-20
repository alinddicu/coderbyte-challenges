namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class MultipleBracketsTest
    {
        /*
         
         have the function MultipleBrackets(str) take the str parameter being passed and return 1 #ofBrackets if the brackets are correctly matched and each one is accounted for. 
         Otherwise return 0. 
          
         For example: if str is "(hello [world])(!)", then the output should be 1 3 because all the brackets are matched and there are 3 pairs of brackets, 
         but if str is "((hello [world])" the the output should be 0 because the brackets do not correctly match up. 
          
         Only "(", ")", "[", and "]" will be used as brackets. 
         
         If str contains no brackets return 1.          
         
         */

        [TestMethod]
        public void GivenTest1WhenMultipleBracketsThenReturnFalse()
        {
            Check.That(new MultipleBrackets().Execute("(coder)[byte)]")).IsEqualTo(new MultipleBracketsResult(false));
        }

        [TestMethod]
        public void GivenTest2WhenMultipleBracketsThenReturnFalse()
        {
            Check.That(new MultipleBrackets().Execute("(coder)([byte)]")).IsEqualTo(new MultipleBracketsResult(false));
        }

        [TestMethod]
        public void GivenTest3WhenMultipleBracketsThenReturnTrueAnd5()
        {
            Check.That(new MultipleBrackets().Execute("(c([od]er)) b(yt[e])")).IsEqualTo(new MultipleBracketsResult(true, 5));
        }
    }
}
