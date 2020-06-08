using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class MergeSortExtension
    {
        public static void MergeSortGeneric<T>(this IList<T> list)
        where T : struct, IComparable
        {
            list.SortGeneric(0, list.Count);
        }
        static void SortGeneric<T>(this IList<T> list, int l, int r)
        where T : struct, IComparable
        {
            var mid = (l + r) / 2;
            if (l < mid)
            {
                list.SortGeneric(l, mid);
                list.SortGeneric(mid, r);
                var temp = list.Merge(l, mid, r);
                for (int i = l; i < r; i++)
                {
                    list[i] = temp.ElementAt(i - l);
                }
            }

        }
        public static async Task MergeSortAsync<T>(this IList<T> list)
        where T : struct, IComparable
        {
            await list.SortAsync(0, list.Count);
        }

        static async Task SortAsync<T>(this IList<T> list, int l, int r)
        where T : struct, IComparable
        {
            var mid = (l + r) / 2;
            if (l < mid)
            {
                await list.SortAsync(l, mid);
                await list.SortAsync(mid, r);
                var temp = list.Merge(l, mid, r);
                Task.WaitAll();
                for (int i = l; i < r; i++)
                {
                    list[i] = temp.ElementAt(i - l);
                }
            }

        }
        static IEnumerable<T> Merge<T>(this IEnumerable<T> resource, int l, int mid, int r)
        where T : struct, IComparable
        {
            var left = resource.ToArray() [l..mid];
            var right = resource.ToArray() [mid..r];
            var i = 0;
            var j = 0;
            var result = new List<T>();

            while (i < left.Count() && j < right.Count())
            {
                if (left.ElementAt(i).CompareTo(right.ElementAt(j)) < 0)
                {
                    result.Add(left.ElementAt(i++));
                }
                else
                {
                    result.Add(right.ElementAt(j++));
                }
            }

            while (i < left.Count())
            {
                result.Add(left.ElementAt(i++));
            }

            while (j < right.Count())
            {
                result.Add(right.ElementAt(j++));

            }

            return result;
        }
    }
}