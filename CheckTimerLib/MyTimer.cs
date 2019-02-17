using System;
using System.Threading;

namespace CheckTimerLib
{
    public class MyTimer
    {
        private int lifetime;
        public int Lifetime { get { return lifetime; } }

        private DateTime startTime;
        private DateTime endTime;
        private string taskName;

        public MyTimer(int milliseconds) {
            lifetime = milliseconds;
        }
        public void Start() {
            taskName = "Task";
            startTime = DateTime.UtcNow;
            TimerCallback callback = new TimerCallback(Die);
            Timer timer = new Timer(callback, null, lifetime, Timeout.Infinite);
        }
        public void Pause() { }
        public void Die(Object obj) {
            endTime = DateTime.UtcNow;
            Record record = new Record(startTime, endTime, taskName);
            record.Print();
        }
    }
}
