using System;
using System.Timers;

namespace SMT_STOPPER_RELEASE.common
{
    public static class TimerExtensions
    {
        public static void Start(this Timer timer, Action executeBeforeStart)
        {
            executeBeforeStart();
            timer.Start();
        }
    }
}
