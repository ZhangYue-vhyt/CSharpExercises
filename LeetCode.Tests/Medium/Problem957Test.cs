using LeetCode.Problems.Medium.Problem957;

using Xunit;

namespace LeetCode.Tests.Medium
{
    public class Problem957Test
    {
        [Fact]
        public void TestName()
        {
            //Given
            var instance = new CellComplete();
            var cells1 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var cells2 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var cells3 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var cells4 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var cells5 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var cells6 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var cells7 = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            //When
            var day1 = new int[] { 0, 1, 1, 0, 0, 0, 0, 0 };
            var day2 = new int[] { 0, 0, 0, 0, 1, 1, 1, 0 };
            var day3 = new int[] { 0, 1, 1, 0, 0, 1, 0, 0 };
            var day4 = new int[] { 0, 0, 0, 0, 0, 1, 0, 0 };
            var day5 = new int[] { 0, 1, 1, 1, 0, 1, 0, 0 };
            var day6 = new int[] { 0, 0, 1, 0, 1, 1, 0, 0 };
            var day7 = new int[] { 0, 0, 1, 1, 0, 0, 0, 0 };

            //Then
            Assert.Equal(day1, instance.PrisonAfterNDays(cells1, 1));
            Assert.Equal(day2, instance.PrisonAfterNDays(cells2, 2));
            Assert.Equal(day3, instance.PrisonAfterNDays(cells3, 3));
            Assert.Equal(day4, instance.PrisonAfterNDays(cells4, 4));
            Assert.Equal(day5, instance.PrisonAfterNDays(cells5, 5));
            Assert.Equal(day6, instance.PrisonAfterNDays(cells6, 6));
            Assert.Equal(day7, instance.PrisonAfterNDays(cells7, 7));
        }
    }
}
