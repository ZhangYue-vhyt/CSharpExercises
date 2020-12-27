using LeetCode.Problems.Amazon;

using Xunit;

namespace LeetCode.Tests.Amazon
{
    public class AmazonTwoSumUniquePairsTest
    {
        [Fact]
        public void TestName()
        {
            //Given
            var instance = new TwoSumUniquePairs();
            var nums1 = new int[] { 1, 1, 2, 45, 46, 46 };
            var target1 = 47;
            var nums2 = new int[] { 1, 1 };
            var target2 = 2;
            var nums3 = new int[] { 1, 5, 1, 5 };
            var target3 = 6;
            var nums4 = new int[] { 5, 7, 3, 9, 13, 11, 6, 6, 3, 3 };
            var target4 = 12;
            //When

            //Then
            Assert.Equal(2, instance.StockPairs(nums1, target1));
            Assert.Equal(1, instance.StockPairs(nums2, target2));
            Assert.Equal(1, instance.StockPairs(nums3, target3));
            Assert.Equal(3, instance.StockPairs(nums4, target4));
        }
    }
}
