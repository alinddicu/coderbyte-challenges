namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class PermutationStepTest
    {
        /*
                  
         * have the function PermutationStep(num) take the num parameter being passed 
         * and return the next number greater than num using the same digits. 
         * 
         * For example: if num is 123 return 132, if it's 12453 return 12534. 
         * If a number has no greater permutations, return -1 (ie. 999).          
         
         */

        [TestMethod]
        public void Given11121WhenPermutationStepThenReturn11211()
        {
            Check.That(new PermutationStep().Execute(11121)).IsEqualTo(11211);
        }

        [TestMethod]
        [Ignore]
        public void Given41352WhenPermutationStepThenReturn41523()
        {
            Check.That(new PermutationStep().Execute(41352)).IsEqualTo(41532);
        }
    }
}
