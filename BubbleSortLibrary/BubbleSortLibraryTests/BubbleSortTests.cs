namespace BubbleSortLibraryTests
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        [Category("Happy Path")]
        public void GivenAnEmptyArrays_BubbleSort_returnEmptyArray()
        {
            int[] subject = new int[] { };

            var sorting = new BubbleSorting();
            Assert.That(sorting.BubbleSort(subject), Is.Empty);
        }

        [TestCase(new int[] { -1, -6, -23, -50 }, new int[] { -50, -23, -6, -1 })]
        [TestCase(new int[] { 70, 3, 40, 0, -60, -7, -3}, new int[] { -60, -7, -3, 0, 3, 40, 70 })]
        [TestCase(new int[] { 10, 4, 5, 3, 9, 7, 1, 6, 2, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [Category("Happy Path")]
        public void GivenAnArrayOfNumbers_BubbleSort_returnThemFromLowestToHighest(int[] subject, int[] expectedResult)
        {
            var sorting = new BubbleSorting();
            Assert.That(sorting.BubbleSort(subject), Is.EqualTo(expectedResult));
        }
    }
}