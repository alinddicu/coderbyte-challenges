namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class TransitivityRelationsTest
    {
        [TestMethod]
        public void GivenTest1WhenTransitivityRelationsThenReturnTrue()
        {
            var result = new TransitivityRelations().Execute("(1,1,1)", "(0,1,1)", "(0,1,1)");
            Check.That(result.IsTransitive).IsTrue();
        }

        [TestMethod]
        public void GivenExampleWhenTransitivityRelationsThenReturnFalse()
        {
            var result = new TransitivityRelations().Execute("(1,1,1)", "(1,0,0)", "(0,1,0)");
            Check.That(result.IsTransitive).IsFalse();
            Check.That(result.MissingConnections).ContainsExactly("1 -> 2", "2 -> 0");
        }

        [TestMethod]
        public void GivenTest2WhenTransitivityRelationsThenReturnFalse()
        {
            var result = new TransitivityRelations().Execute("(0,1,0,0)", "(0,0,1,0)", "(0,0,1,1)", "(0,0,0,1)");
            Check.That(result.IsTransitive).IsFalse();
            Check.That(result.MissingConnections).ContainsExactly("0 -> 2", "1 -> 3");
        }
    }
}
