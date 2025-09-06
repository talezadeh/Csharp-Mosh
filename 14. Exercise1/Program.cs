using System.Security.Cryptography.X509Certificates;

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

    public class Program
    {
        public static void Main(string[] args)
        {
            var sw = new MyStopWatch();

        // Run #1
        sw.Start();
        Thread.Sleep(1200); // pretend we are doing work for ~1.2 seconds
        TimeSpan first = sw.Stop();
        Console.WriteLine("Run #1: " + first);

        // Run #2 (reuse the same stopwatch)
        sw.Start();
        Thread.Sleep(700); // ~0.7 seconds of work
        TimeSpan second = sw.Stop();
        Console.WriteLine("Run #2: " + second);

        // You can always read the last measured duration:
        Console.WriteLine("LastDuration: " + sw.LastDuration);

        // Try these lines to see the safety checks:
        // sw.Start();
        // sw.Start(); // <-- this will throw InvalidOperationException

        }

    }
}