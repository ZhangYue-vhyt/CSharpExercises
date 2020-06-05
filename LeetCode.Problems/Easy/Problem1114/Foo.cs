using System;
using System.Threading;

namespace LeetCode.Problems.Easy.Problem1114
{
    public class Foo
    {
        private AutoResetEvent _event1;
        private AutoResetEvent _event2;
        public Foo()
        {
            _event1 = new AutoResetEvent(false);
            _event2 = new AutoResetEvent(false);
        }

        public void First(Action printFirst)
        {

            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _event1.Set();
        }

        public void Second(Action printSecond)
        {
            _event1.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _event2.Set();
        }

        public void Third(Action printThird)
        {
            _event2.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}