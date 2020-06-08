using System;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.Sorting;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Tests
{
    public class MergeSortExtension
    {
        private readonly ITestOutputHelper _output;

        public MergeSortExtension(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestMergeSortGeneric()
        {
            var a = new int[] { 8, 5, 6, 3, 9, 2, 4, 1 };
            var b = new int[] { 8, 5, 6, 3, 9, 2, 4, 1 };
            a.MergeSortGeneric();
            Array.Sort(b);
            Assert.True(Enumerable.SequenceEqual(a, b));

            var c = new double[] { 8.1, 5.2, 6.3, 3.4, 9.5, 2.6, 4.7, 1.8 };
            var d = new double[] { 8.1, 5.2, 6.3, 3.4, 9.5, 2.6, 4.7, 1.8 };
            c.MergeSortGeneric();
            Array.Sort(d);
            Assert.True(Enumerable.SequenceEqual(c, d));
        }

        [Fact]
        public async Task TestMergeSortAsync()
        {
            var a = new int[] { 8, 5, 6, 3, 9, 2, 4, 1 };
            var b = new int[] { 8, 5, 6, 3, 9, 2, 4, 1 };
            await a.MergeSortAsync();
            Array.Sort(b);
            Assert.True(Enumerable.SequenceEqual(a, b));

            var c = new double[] { 8.1, 5.2, 6.3, 3.4, 9.5, 2.6, 4.7, 1.8 };
            var d = new double[] { 8.1, 5.2, 6.3, 3.4, 9.5, 2.6, 4.7, 1.8 };
            await c.MergeSortAsync();
            Array.Sort(d);
            Task.WaitAll();
            Assert.True(Enumerable.SequenceEqual(c, d));
        }
    }
}