using System.Threading;

namespace LeetCode.Problems.Easy.Problem1115
{
    public class FooBarForTest
    {
        private int n;
        private AutoResetEvent _eventFoo;
        private AutoResetEvent _eventBar;
        public string Result { get; private set; }
        public FooBarForTest(int n)
        {
            this.n = n;
            _eventFoo = new AutoResetEvent(true);
            _eventBar = new AutoResetEvent(false);
        }
        public void Foo()
        {

            for (int i = 0; i < n; i++)
            {
                _eventFoo.WaitOne();
                Result += "foo";
                _eventBar.Set();
            }
        }

        public void Bar()
        {

            for (int i = 0; i < n; i++)
            {
                _eventBar.WaitOne();
                Result += "bar";
                _eventFoo.Set();
            }
        }
    }
}