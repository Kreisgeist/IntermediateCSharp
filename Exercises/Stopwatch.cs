namespace Exercises
{
    public class Stopwatch
    {
        private DateTime _start;
        private bool _isStarted = false;

        public string Start()
        {
            if(!_isStarted)
            {
                this._start = DateTime.Now;
                this._isStarted = true;

                return "Watch Started. ";
            }
            else
            {
                return "Already Started. ";
            }

        }
        public TimeSpan Stop()
        {
            this._isStarted = false;
            return DateTime.Now - this._start;
        }
    }
}