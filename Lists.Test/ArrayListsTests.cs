using NUnit.Framework;

namespace Lists.Test
{
    public class ArrayListsTests
    {


        [TestCase(2, new int[] { 5, 4, 6, 7 }, new int[] { 5, 4, 6, 7, 2 })]
        [TestCase(2, new int[] { }, new int[] {2})]
        [TestCase(-2, new int[] {0}, new int[] {0,-2})]
        
        public void AddElementTest(int value, int[] Array1, int[] Array2)
        {
            ArrayList actual= new ArrayList(Array1);
            ArrayList expected = new ArrayList(Array2);
            actual.AddElement(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, new int[] { 5, 4, 6, 7 }, new int[] {2, 5, 4, 6, 7})]
        [TestCase(0, new int[] { }, new int[] {0})]
        [TestCase(-2, new int[] { 0 }, new int[] {-2, 0})]
        public void AddFirstTest(int value, int[] Array1, int[] Array2)
        {
            ArrayList actual = new ArrayList(Array1);
            ArrayList expected = new ArrayList(Array2);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3,2, new int[] { 5, 4, 6, 7}, new int[] {5, 4, 6, 2, 7})]
        [TestCase(0,-1, new int[] { }, new int[] {-1})]
        [TestCase(1,-2, new int[] { 0 }, new int[] {0, -2})]
        public void AddElementTest(int index, int value, int[] Array1, int[] Array2)
        {
            ArrayList actual = new ArrayList(Array1);
            ArrayList expected = new ArrayList(Array2);
            actual.AddElement(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 4, 6, 7 }, new int[] { 5, 4, 6})]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { })]
        public void DeleteLastTest(int[] Array1, int[] Array2)
        {
            ArrayList actual = new ArrayList(Array1);
            ArrayList expected = new ArrayList(Array2);
            actual.DeleteLast();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 4, 6, 7 }, new int[] { 4, 6, 7 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { })]
        public void DeleteFirstTest(int[] Array1, int[] Array2)
        {
            ArrayList actual = new ArrayList(Array1);
            ArrayList expected = new ArrayList(Array2);
            actual.DeleteFirst();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, new int[] { 5, 4, 6, 7 }, new int[] { 5, 4, 7 })]
        [TestCase(0, new int[] {1}, new int[] { })]
        [TestCase(5, new int[] { }, new int[] { })]
        public void DeleteElementTest(int index, int[] Array1, int[] Array2)
        {
            ArrayList actual = new ArrayList(Array1);
            ArrayList expected = new ArrayList(Array2);
            actual.DeleteElement(index);
            Assert.AreEqual(expected, actual);
        }

    }
}