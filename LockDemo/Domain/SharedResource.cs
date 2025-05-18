namespace LockDemo.Domain
{
    public class SharedResource
    {
        private int _counter = 0;
        private readonly object _sync = new();

        public void Increment()
        {
            lock (_sync)
            {
                _counter++;
            }
        }

        public int GetCount()
        {
            lock (_sync)
            {
                return _counter;
            }
        }
    }
} 