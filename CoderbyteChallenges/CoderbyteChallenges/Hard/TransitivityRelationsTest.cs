namespace CoderbyteChallenges.Hard
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class TransitivityRelationsTest
    {
        [TestMethod]
        public void GivenTest1WhenExecuteThenReturnTrue()
        {
            var result = new TransitivityRelations().Execute("(1,1,1)","(0,1,1)","(0,1,1)"); 
            Check.That(result.IsTransitive).IsTrue();
        }
    }
}
