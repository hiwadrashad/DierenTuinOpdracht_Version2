using System;
using System.Collections.Generic;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.EventHandlers
{
    public class WriteDataFromDataBaseToListBoxEventHandler
    {

        public void WriteDataFromDataServiceToListBoxEventHandler(object sender, EventArgs e)
        {
            StaticResources.StaticMainwindow.StaticMainWindowStorage.EnterAllDataFromDataServiceInListBox();
        }
    }
}
