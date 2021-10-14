using Xunit;

namespace Algorithms.Tests
{
    public class SearchTests
    {
        private readonly Search _algo;

        int[] array = new int[100];

        public SearchTests()
        {
            _algo = new Search();

            for (int i = 0; i < 100; i++)
            {
                array[i] = i;
            }
        }

        [Fact]
        public void TestLinearSearch_WhenCalled_ReturnsIndexOfItem()
        {
            var result = _algo.LinearSearch(array, 5);

            Assert.Equal(5, result);

        }

        [Fact]
        public void TestBinarySearch_WhenCalled_ReturnsIndexOfItem()
        {
            var result = _algo.BinarySearch(array, 5);

            Assert.Equal(5, result);

        }
    }
}