namespace CoderbyteChallenges.Tools
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class CircularArrayTest
    {
        [TestMethod]
        public void WhenGetByIndexWhenExistingThenReturn()
        {
            var array = new CircularArray<int>(0, 1);

            Check.That(array[0]).IsEqualTo(0);
            Check.That(array[1]).IsEqualTo(1);
        }

        [TestMethod]
        public void WhenGetByIndexWhenNotExistingThenReturn()
        {
            var array = new CircularArray<int>(0, 1);

            Check.That(array[2]).IsEqualTo(0);
        }

        [TestMethod]
        public void WhenSetByIndexThenOk()
        {
            var array = new CircularArray<int>(0);
            array[0] = 1;

            Check.That(array[0]).IsEqualTo(1);
        }

        [TestMethod]
        public void WhenFirstIndexOfExistingThenReturnRightIndex()
        {
            var array = new CircularArray<int>(0);

            var index = array.FirstIndexOf(0);

            Check.That(index).IsEqualTo(0);
        }

        [TestMethod]
        public void WhenFirstIndexOfNonExistingThenReturn()
        {
            var array = new CircularArray<int>(0);

            var index = array.FirstIndexOf(1);

            Check.That(index).IsEqualTo(-1);
        }
    }
}
