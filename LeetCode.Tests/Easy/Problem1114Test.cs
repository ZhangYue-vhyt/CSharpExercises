using System;
using System.Threading;
using System.Threading.Tasks;
using LeetCode.Problems.Easy.Problem1114;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class Problem1114Test
    {
        [Fact]
        public void TestFoo()
        {
            var foo = new FooWithAutoResetEvent();
            var t1 = Task.Factory.StartNew(foo.Second);
            var t2 = Task.Factory.StartNew(foo.First);
            var t3 = Task.Factory.StartNew(foo.Third);
            Task.WaitAll(t1, t2, t3);
            Assert.Equal("firstsecondthird", foo.Result);
        }
    }
}