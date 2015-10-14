namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class BinaryConverterTest
    {
        /*
         
            have the function BinaryConverter(str) return the decimal form of the binary value. 
            For example: if 101 is passed return 5, or if 1000 is passed return 8. 
         
         */

        [TestMethod]
        public void Given101WhenBinaryConverterThenReturn5()
        {
            Check.That(new BinaryConverter().Execute(101)).IsEqualTo(5);
        }

        [TestMethod]
        public void Given1000WhenBinaryConverterThenReturn8()
        {
            Check.That(new BinaryConverter().Execute(1000)).IsEqualTo(8);
        }
    }
}
