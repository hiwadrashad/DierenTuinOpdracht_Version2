using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DierenTuin_Version2_Without_PRISM.Logging
{
    public class Log4NetLogging
    {

        static protected ILog Log = LogManager.GetLogger("TASK");

        public static Task<bool> logging()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
            return Task.Run(() =>
            {
                Thread.Sleep(100);
                return true;
            });
        }
    }
}
