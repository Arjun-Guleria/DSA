using Xunit;
using DSA.Arrays;

namespace Tests.Arrays
{
    public class TwoSumTests
    {
        [Fact]
        public void Test1()
        {
            var result = TwoSumSolution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new[] { 0, 1 }, result);
        }
    }
}