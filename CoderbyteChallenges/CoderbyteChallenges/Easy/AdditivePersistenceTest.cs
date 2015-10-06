namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AdditivePersistenceTest
    {
        /*
         
         have the function AdditivePersistence(num) take the num parameter being passed 
         which will always be a positive integer and return its additive persistence 
         which is the number of times you must add the digits in num until you reach 
         a single digit. 
         
         For example: if num is 2718 then your program should return 2 because 2 + 7 + 1 + 8 = 18 and 1 + 8 = 9 and you stop at 9.          
         
         */

        [TestMethod]
        public void Given4WhenAdditivePersistenceThenReturn0()
        {
            Check.That(new AdditivePersistence().Execute(4)).IsEqualTo(0);
        }

        [TestMethod]
        public void Given19WhenAdditivePersistenceThenReturn2()
        {
            Check.That(new AdditivePersistence().Execute(19)).IsEqualTo(2);
        }


    }
}
