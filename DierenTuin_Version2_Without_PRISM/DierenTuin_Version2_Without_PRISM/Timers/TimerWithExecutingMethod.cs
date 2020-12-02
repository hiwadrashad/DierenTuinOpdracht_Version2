using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace DierenTuin_Version2_Without_PRISM.Timers
{
    public class TimerWithExecutingMethod
    {
        public void SetInterval()
        {
            EventHandlers.WriteDataFromDataBaseToListBoxEventHandler InitEventHandlerListBox = new EventHandlers.WriteDataFromDataBaseToListBoxEventHandler();
            EventHandlers.RemoveDeadAnimalsEventHandler InitEventHandlerRemoveDeadAnimals = new EventHandlers.RemoveDeadAnimalsEventHandler();
            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(InitEventHandlerListBox.WriteDataFromDataServiceToListBoxEventHandler);
            dispatcherTimer.Tick += new EventHandler(InitEventHandlerRemoveDeadAnimals.RemoveDeadAnimals);
            dispatcherTimer.Tick += new EventHandler(EventHandlers.ExecuteUseEnergyHandler.ExecuteUseEnergyEventHandler);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(500);
            dispatcherTimer.Start();
            //System.Timers.Timer tmr = new System.Timers.Timer();
            ////tmr.Elapsed += EventHandlers.ExecuteUseEnergyHandler.ExecuteUseEnergyEventHandler;
            //tmr.Elapsed += InitEventHandlerListBox.WriteDataFromDataServiceToListBoxEventHandler;
            ////tmr.Elapsed += InitEventHandlerRemoveDeadAnimals.RemoveDeadAnimals;
            //tmr.AutoReset = true;
            //tmr.Interval = 500;
            //tmr.Start();

        }
    }
}
