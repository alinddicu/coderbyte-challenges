namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class LetterCapitalizeTest
    {
        /*
         
         Take the str parameter being passed and capitalize the first letter of each word. Words will be separated by only one space. 
         
         */

        [TestMethod]
        public void GivenHelloWhenExecuteThenReturnHello()
        {
            var result = new LetterCapitalize().Execute("hello");

            Check.That(result).IsEqualTo("Hello"); ;
        }

        [TestMethod]
        public void GivenhelloworldWhenExecuteThenReturnHelloWorld()
        {
            var result = new LetterCapitalize().Execute("hello world");

            Check.That(result).IsEqualTo("Hello World"); ;
        }
    }
}
