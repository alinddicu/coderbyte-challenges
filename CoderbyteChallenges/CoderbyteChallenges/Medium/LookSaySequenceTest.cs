namespace CoderbyteChallenges.Medium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class LookSaySequenceTest
    {
        /*
         
            have the function LookSaySequence(num) take the num parameter being passed and return the next number 
            in the sequence according to the following rule:
         
            to generate the next number in a sequence read off the digits of the given number, 
            counting the number of digits in groups of the same digit. 
         
            For example, the sequence beginning with 1 would be: 1, 11, 21, 1211, ... 
            The 11 comes from there being "one 1" before it and the 21 comes from there being 
            "two 1's" before it. 
        
            So your program should return the next number in the sequence given num.         
         
         */

        [TestMethod]
        public void Given1211WhenLookSaySequenceThenReturn111221()
        {
            Check.That(new LookSaySequence().Execute(1211)).IsEqualTo(111221);
        }

        [TestMethod]
        public void Given2466WhenLookSaySequenceThenReturn121426()
        {
            Check.That(new LookSaySequence().Execute(2466)).IsEqualTo(121426);
        }
    }
}
