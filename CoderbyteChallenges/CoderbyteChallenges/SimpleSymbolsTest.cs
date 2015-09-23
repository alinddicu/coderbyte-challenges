namespace CoderbyteChallenges
{
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class SimpleSymbolsTest
    {
        /*
         
         take the str parameter being passed and determine if it is an acceptable sequence by either returning the string true or false. 
         The str parameter will be composed of + and = symbols with several letters between them (ie. ++d+===+c++==a) 
            and for the string to be true each letter must be surrounded by a + symbol. 
         So the string to the left would be false. 
         The string will not be empty and will have at least one letter. 
         
         */

        [TestMethod]
        public void GivenInput1WhenSimpleSymbolsThenReturnTrue()
        {
            Check.That(new SimpleSymbols().Execute("+d+=3=+s+")).IsEqualTo("true");
        }

        [TestMethod]
        public void GivenInput2WhenSimpleSymbolsThenReturnFalse()
        {
            Check.That(new SimpleSymbols().Execute("f++d+")).IsEqualTo("false");
        }

        [TestMethod]
        public void GivenDisallowedCaractersWhenSimpleSymbolsThenThrow()
        {
            Check.ThatCode(() => new SimpleSymbols().Execute("&#'(-_)~#{[|`\\^@]}$£%µ*,;:!?./§<>")).Throws<InvalidDataException>();
        }

        [TestMethod]
        public void GivenPlusLetterPlusWhenSimpleSymbolsThenReturnTrue()
        {
            Check.That(new SimpleSymbols().Execute("+f+")).IsEqualTo("true");
            Check.That(new SimpleSymbols().Execute("+a+")).IsEqualTo("true");
        }

        [TestMethod]
        public void GivenLetterPlusWhenSimpleSymbolsThenReturnFalse()
        {
            Check.That(new SimpleSymbols().Execute("f+")).IsEqualTo("false");
        }

        [TestMethod]
        public void GivenPlusLetterWhenSimpleSymbolsThenReturnFalse()
        {
            Check.That(new SimpleSymbols().Execute("+f")).IsEqualTo("false");
        }
    }
}
