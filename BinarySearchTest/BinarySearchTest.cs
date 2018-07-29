namespace BinarySearchTest
{
    using BinarySearch;
    using NUnit.Framework;

    [TestFixture]
    public class BinarySearchTest
    {
        
        [Test]
        [TestCase(-1, 3, new int[0] )]
        [TestCase(-1, 3, new [] {1})]
        [TestCase(0,  1, new [] {1})]
        [TestCase(0,  1, new [] {1, 3, 5})]
        [TestCase(1,  3, new [] {1, 3, 5})]
        [TestCase(2,  5, new [] {1, 3, 5})]
        [TestCase(-1, 0, new [] {1, 3, 5})]
        [TestCase(-1, 2, new [] {1, 3, 5})]
        [TestCase(-1, 4, new [] {1, 3, 5})]
        [TestCase(-1, 6, new [] {1, 3, 5})]
        [TestCase(0,  1, new [] {1, 3, 5, 7})]
        [TestCase(1,  3, new [] {1, 3, 5, 7})]
        [TestCase(2,  5, new [] {1, 3, 5, 7})]
        [TestCase(3,  7, new [] {1, 3, 5, 7})]
        [TestCase(-1, 0, new [] {1, 3, 5, 7})]
        [TestCase(-1, 2, new [] {1, 3, 5, 7})]
        [TestCase(-1, 4, new [] {1, 3, 5, 7})]
        [TestCase(-1, 6, new [] {1, 3, 5, 7})]
        [TestCase(-1, 8, new [] {1, 3, 5, 7})]
        public void Given_Array_BinarySearch_Search_Then_Got_Result(int expectedResult, int needle, int[] haystack)
        {
            var binarySearch = new BinarySearch();
            var result = binarySearch.Search(needle, haystack);

            Assert.That(result, Is.EqualTo(expectedResult), "Binary search fail");
        }


        [Test]
        [TestCase(-1, 3, new int[0] )]
        [TestCase(-1, 3, new [] {1})]
        [TestCase(0,  1, new [] {1})]
        [TestCase(0,  1, new [] {1, 3, 5})]
        [TestCase(1,  3, new [] {1, 3, 5})]
        [TestCase(2,  5, new [] {1, 3, 5})]
        [TestCase(-1, 0, new [] {1, 3, 5})]
        [TestCase(-1, 2, new [] {1, 3, 5})]
        [TestCase(-1, 4, new [] {1, 3, 5})]
        [TestCase(-1, 6, new [] {1, 3, 5})]
        [TestCase(0,  1, new [] {1, 3, 5, 7})]
        [TestCase(1,  3, new [] {1, 3, 5, 7})]
        [TestCase(2,  5, new [] {1, 3, 5, 7})]
        [TestCase(3,  7, new [] {1, 3, 5, 7})]
        [TestCase(-1, 0, new [] {1, 3, 5, 7})]
        [TestCase(-1, 2, new [] {1, 3, 5, 7})]
        [TestCase(-1, 4, new [] {1, 3, 5, 7})]
        [TestCase(-1, 6, new [] {1, 3, 5, 7})]
        [TestCase(-1, 8, new [] {1, 3, 5, 7})]
        public void Given_Array_When_BinarySearchWithArrayChop_Then_Got_Result(int expectedResult, int needle, int[] haystack)
        {
            var binarySearch = new BinarySearchWithArrayChop();
            var result = binarySearch.Search(needle, haystack);

            Assert.That(result, Is.EqualTo(expectedResult), "Binary search fail");
        }
    }
}
