namespace CoderbyteChallenges.ArithGeo
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class ArithGeoTest
    {
        /*
         
         take the array of numbers stored in arr and return the string 
         * "Arithmetic" if the sequence follows an arithmetic pattern 
         * or return "Geometric" if it follows a geometric pattern. 
         If the sequence doesn't follow either pattern return -1. 
         An arithmetic sequence is one where the difference between each of the numbers is consistent, 
         where as in a geometric sequence, each term after the first is multiplied by some constant or common ratio. 
         * Arithmetic example: [2, 4, 6, 8] 
         * and Geometric example: [2, 6, 18, 54]. 
         
         Negative numbers may be entered as parameters, 0 will not be entered, and no array will contain all the same elements. 
                  
         */

        [TestMethod]
        public void Given5And10And15WhenArithGeoThenArithmetic()
        {
            Check.That(new ArithGeo().Execute(5, 10, 15)).IsEqualTo(ArithGeoType.Arithmetic);
        }

        [TestMethod]
        public void Given2And4And8WhenArithGeoThenArithmetic()
        {
            Check.That(new ArithGeo().Execute(2, 4, 8)).IsEqualTo(ArithGeoType.Geometric);
        }

        [TestMethod]
        public void Given2And4And16And24WhenArithGeoThenNone()
        {
            Check.That(new ArithGeo().Execute(2, 4, 16, 24)).IsEqualTo(ArithGeoType.None);
        }
    }
}
