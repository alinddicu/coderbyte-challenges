namespace CoderbyteChallenges
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class SimpleAddingTest
    {
        /*
         
         For this challenge you will be adding up all the numbers from 1 to a certain argument.
         
         */

        [TestMethod]
        public void WhenSimpleAddingOf2ThenReturn3()
        {
            var result = new SimpleAdding().Execute(2);

            Check.That(result).IsEqualTo(3); ;
        }
    }
}
