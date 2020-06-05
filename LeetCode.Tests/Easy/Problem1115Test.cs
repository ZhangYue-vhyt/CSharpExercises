using System.Threading;
using System.Threading.Tasks;
using LeetCode.Problems.Easy.Problem1115;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class Problem1115Test
    {
        [Fact]
        public void FooBarTest()
        {
            //Given
            var foobar = new FooBarForTest(100);
            var t1 = Task.Factory.StartNew(foobar.Foo);
            var t2 = Task.Factory.StartNew(foobar.Bar);

            //When
            var expected = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                expected += "foobar";
            }
            
            //Then
            Task.WaitAll(t1, t2);
            Assert.Equal(expected, foobar.Result);
        }
    }
}