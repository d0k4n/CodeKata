namespace BinarySearchTest
{
    using BinarySearch;
    using NUnit.Framework;

    [TestFixture]
    public class BinarySearchTest
    {

        [Test, TestCaseSource(nameof(TestCases))]
        public void Given_Array_BinarySearch_Search_Then_Got_Result(int expectedResult, int needle, int[] haystack)
        {
            var binarySearch = new BinarySearch();
            var result = binarySearch.Search(needle, haystack);

            Assert.That(result, Is.EqualTo(expectedResult), "Binary search fail");
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public void Given_Array_When_BinarySearchWithArrayChop_Then_Got_Result(int expectedResult, int needle, int[] haystack)
        {
            var binarySearch = new BinarySearchWithArrayChop();
            var result = binarySearch.Search(needle, haystack);

            Assert.That(result, Is.EqualTo(expectedResult), "Binary search fail");
        }
        
        [Test, TestCaseSource(nameof(TestCases))]
        public void Given_Array_When_BinarySearchRecurrent_Then_Got_Result(int expectedResult, int needle, int[] haystack)
        {
            var binarySearch = new BinarySearchRecurrent();
            var result = binarySearch.Search(needle, haystack);

            Assert.That(result, Is.EqualTo(expectedResult), "Binary search fail");
        }

        private static object[] TestCases =
        {
            new object[] {-1, 3, new int[0]},
            new object[] {-1, 3, new [] {1}},
            new object[] {0,  1, new [] {1}},
            new object[] {0,  1, new [] {1, 3, 5}},
            new object[] {1,  3, new [] {1, 3, 5}},
            new object[] {2,  5, new [] {1, 3, 5}},
            new object[] {-1, 0, new [] {1, 3, 5}},
            new object[] {-1, 2, new [] {1, 3, 5}},
            new object[] {-1, 4, new [] {1, 3, 5}},
            new object[] {-1, 6, new [] {1, 3, 5}},
            new object[] {0,  1, new [] {1, 3, 5, 7}},
            new object[] {1,  3, new [] {1, 3, 5, 7}},
            new object[] {2,  5, new [] {1, 3, 5, 7}},
            new object[] {3,  7, new [] {1, 3, 5, 7}},
            new object[] {-1, 0, new [] {1, 3, 5, 7}},
            new object[] {-1, 2, new [] {1, 3, 5, 7}},
            new object[] {-1, 4, new [] {1, 3, 5, 7}},
            new object[] {-1, 6, new [] {1, 3, 5, 7}},
            new object[] {-1, 8, new [] {1, 3, 5, 7}}
        };
    }
}
