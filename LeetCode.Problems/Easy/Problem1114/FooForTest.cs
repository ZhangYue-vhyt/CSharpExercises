using System;
using System.Threading;

namespace LeetCode.Problems.Easy.Problem1114
{
    public class FooWithAutoResetEvent
    {
        private AutoResetEvent _event1;
        private AutoResetEvent _event2;
        public string Result { get; private set; }

        public FooWithAutoResetEvent()
        {
            _event1 = new AutoResetEvent(false);
            _event2 = new AutoResetEvent(false);
        }

        public void First()
        {

            Result += "first";
            _event1.Set();
        }

        public void Second()
        {
            _event1.WaitOne();
            Result += "second";
            _event2.Set();
        }

        public void Third()
        {
            _event2.WaitOne();
            Result += "third";
        }
    }
}