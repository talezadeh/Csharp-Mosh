namespace Exercise1
{
    public class MyStopWatch
    {

        private DateTime _startTime;
        private bool _isRunning;

        public TimeSpan LastDuration { get; private set; } = TimeSpan.Zero;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
        }
        public TimeSpan Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            LastDuration = DateTime.Now - _startTime;
            _isRunning = false;
            return LastDuration;
        }
    }
}