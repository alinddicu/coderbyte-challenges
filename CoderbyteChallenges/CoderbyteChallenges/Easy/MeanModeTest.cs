namespace CoderbyteChallenges.Easy
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class MeanModeTest
    {
        /*
         
         have the function MeanMode(arr) take the array of numbers stored in arr and return 1 if the mode equals the mean, 
         0 if they don't equal each other (ie. [5, 3, 3, 3, 1] should return 1 because the mode (3) equals the mean (3)). 
         The array will not be empty, will only contain positive integers, and will not contain more than one mode
         
         */

        [TestMethod]
        public void GivenTest1WhenMeanModeThenReturnFalse()
        {
            Check.That(new MeanMode().Execute(1, 2, 3)).IsFalse();
        }

        [TestMethod]
        public void GivenTest2WhenMeanModeThenReturnTrue()
        {
            Check.That(new MeanMode().Execute(4, 4, 4, 6, 2)).IsTrue();
        }
    }
}
