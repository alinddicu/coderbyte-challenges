namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class GreatestCommonFactorTest
    {
        /*
         
         have the function Division(num1,num2) take both parameters being passed and return the Greatest Common Factor. 
         That is, return the greatest number that evenly goes into both numbers with no remainder. 
          
         For example: 12 and 16 both are divisible by 1, 2, and 4 so the output should be 4. 
         The range for both parameters will be from 1 to 10^3. 
         
         
         */

        [TestMethod]
        public void Given7And3WhenDivisionThenReturn1()
        {
            Check.That(new GreatestCommonFactor().Execute(7,3)).IsEqualTo(1);
        }

        [TestMethod]
        public void Given36And54WhenDivisionThenReturn18()
        {
            Check.That(new GreatestCommonFactor().Execute(36, 54)).IsEqualTo(18);
        }
    }
}
