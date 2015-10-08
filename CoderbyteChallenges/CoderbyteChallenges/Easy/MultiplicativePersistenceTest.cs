namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class MultiplicativePersistenceTest
    {
        /*
         
         have the function MultiplicativePersistence(num) take the num parameter being passed 
         which will always be a positive integer and return its multiplicative persistence 
         which is the number of times you must multiply the digits in num 
         until you reach a single digit. 
         For example: 
            if num is 39 then your program should return 3 because 3 * 9 = 27 
            then 2 * 7 = 14 and finally 1 * 4 = 4 and you stop at 4. 
         
         */

        [TestMethod]
        public void Given4WhenMultiplicativePersistenceThenReturn0()
        {
            Check.That(new MultiplicativePersistence().Execute(4)).IsEqualTo(0);
        }

        [TestMethod]
        public void Given25WhenMultiplicativePersistenceThenReturn2()
        {
            Check.That(new MultiplicativePersistence().Execute(25)).IsEqualTo(2);
        }
    }
}
