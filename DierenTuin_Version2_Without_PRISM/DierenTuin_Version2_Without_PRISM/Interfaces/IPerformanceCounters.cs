using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.Interfaces
{
    interface IPerformanceCounters
    {
        PerformanceCounter GetFirstPerformanceCounter();
        PerformanceCounter GetSecondPerformanceCounter();
        PerformanceCounter GetThirdPerformanceCounter();
    }
}
