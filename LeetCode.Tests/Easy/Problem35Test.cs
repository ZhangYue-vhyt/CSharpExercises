using LeetCode.Problems.Easy.Problem35;

using Xunit;

namespace LeetCode.Tests.Easy
{
    public class Problem35Test
    {
        [Fact]
        public void TestName()
        {
            //Given
            var instance = new SearchInsertPosition();
            var nums1 = new int[] { 1, 3, 5, 6 };
            var target1 = 5;
            var nums2 = new int[] { 1, 3, 5, 6 };
            var target2 = 2;
            var nums3 = new int[] { 1, 3, 5, 6 };
            var target3 = 7;
            var nums4 = new int[] { 1, 3, 5, 6 };
            var target4 = 0;
            var nums5 = new int[] { 1 };
            var target5 = 0;

            //When

            //Then
            Assert.Equal(2, instance.SearchInsert(nums1, target1));
            Assert.Equal(1, instance.SearchInsert(nums2, target2));
            Assert.Equal(4, instance.SearchInsert(nums3, target3));
            Assert.Equal(0, instance.SearchInsert(nums4, target4));
            Assert.Equal(0, instance.SearchInsert(nums5, target5));
        }
    }
}
