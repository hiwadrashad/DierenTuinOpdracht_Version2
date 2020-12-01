using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DierenTuin_Version2_Without_PRISM.Timers
{
    public class TimerWithExecutingMethod
    {
        public System.Timers.Timer SetInterval()
        {
            System.Timers.Timer tmr = new System.Timers.Timer();
            tmr.Elapsed += EventHandlers.ExecuteEatingHandler.ExecuteEatingEventHandler;
            tmr.AutoReset = true;
            tmr.Interval = 500;
            tmr.Start();

            return tmr;
        }
    }
}
