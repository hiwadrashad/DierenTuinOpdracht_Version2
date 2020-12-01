using System;
using System.Collections.Generic;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.EventHandlers
{
    public static  class ExecuteEatingHandler
    {
        public static void ExecuteEatingEventHandler(object sender, EventArgs e)
        {
            MainFunctions.MainFunctions.UseEnergyAllAnimals useEnergyAll = new MainFunctions.MainFunctions.UseEnergyAllAnimals();
            useEnergyAll.UseEnergyAllAnimalsPerTick();
        }
    }
}
