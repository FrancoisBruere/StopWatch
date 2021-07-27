using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;

        private DateTime _stopTime;

        public TimeSpan _duration { get; private set; }
        public TimeSpan _lapsedTime { get; private set; }

        private bool _isStarted;

        
        public void Start()
        {
            if (!_isStarted)
            {
                _startTime = DateTime.Now;
                _isStarted = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already started!! Press any key to exit");
            }
        }

        public void Stop()
        {
            if (_isStarted)
            {
                _stopTime = DateTime.Now;
                _lapsedTime = _stopTime - _startTime;
                _duration += _stopTime - _startTime;
                _isStarted = false;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already stopped!! Press any key to exit");
            }

        }

    }
}

