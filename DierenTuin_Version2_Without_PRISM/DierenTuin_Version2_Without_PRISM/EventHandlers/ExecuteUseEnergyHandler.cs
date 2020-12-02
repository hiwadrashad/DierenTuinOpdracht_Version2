using System;
using System.Collections.Generic;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.EventHandlers
{
    public static  class ExecuteUseEnergyHandler
    {
        public static void ExecuteUseEnergyEventHandler(object sender, EventArgs e)
        {
            MainFunctions.MainFunctions.UseEnergyAllAnimals useEnergyAll = new MainFunctions.MainFunctions.UseEnergyAllAnimals();
            useEnergyAll.UseEnergyAllAnimalsPerTick();
        }
    }
}
