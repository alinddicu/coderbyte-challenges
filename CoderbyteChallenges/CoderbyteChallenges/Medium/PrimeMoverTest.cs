namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class PrimeMoverTest
    {
        /*
        
        have the function PrimeMover(num) return the numth prime number. 
        The range will be from 1 to 10^4. 
         
        For example: if num is 16 the output should be 53 as 53 is the 16th prime number. 
        
        */

        [TestMethod]
        public void Given9WhenPrimeMoverThenReturn23()
        {
            Check.That(new PrimeMover().Execute(9)).IsEqualTo(23);
        }
    }
}