using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.PerformanceCounterClass
{
    public class PerformanceCounterClass
    {
        private PerformanceCounter _perf1;
        private PerformanceCounter _perf2;
        private PerformanceCounter _Perf3;

        private static PerformanceCounterClass _performanceCounter;

        private PerformanceCounterClass()
        {

        }

        public static PerformanceCounterClass GetPerformanceCounter()
        {

            if (_performanceCounter == null)
            {
                _performanceCounter = new PerformanceCounterClass();
                _performanceCounter.InitData();
            }
            return _performanceCounter;
        }

        public void InitData()
        {
            _perf1 = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            _perf2 = new PerformanceCounter("Memory", "Available MBytes");
            _Perf3 = new PerformanceCounter("System","System Up Time");
        }

        public PerformanceCounter GetFirstPerformanceCounter()
        {
            return _perf1;
        }

        public PerformanceCounter GetSecondPerformanceCounter()
        {
            return _perf2;
        }

        public PerformanceCounter GetThirdPerformanceCounter()
        {
            return _Perf3;
        }
    }
}
