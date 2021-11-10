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
    }
}