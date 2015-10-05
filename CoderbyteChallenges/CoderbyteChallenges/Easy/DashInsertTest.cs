namespace CoderbyteChallenges.Easy
{
    using System.Security.Cryptography;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class DashInsertTest
    {
        /*
         
         have the function DashInsert(str) insert dashes ('-') between each two odd numbers in str. 
         For example: if str is 454793 the output should be 4547-9-3. 
         Don't count zero as an odd number
         
         */

        [TestMethod]
        public void Given99946WhenDashInsertThen9Dash9Dash946()
        {
            Check.That(new DashInsert().Execute("99946")).IsEqualTo("9-9-946");
        }
    }
}
