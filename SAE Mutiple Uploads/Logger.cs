
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace SAE_Mutiple_Uploads
{
    public class Logger:IDisposable
    {
        private StreamWriter log;

        public Logger(string logPath)
        {
            log = new StreamWriter(logPath, true, Encoding.UTF8);
            log.AutoFlush = true;
        }


        public void Log(string fmt, params object[] args)
        {
            try
            {
                string msg = string.Format(fmt, args);
                Debug.WriteLine(msg);
                log.WriteLine(DateTime.Now + "\t" + msg);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        #region IDisposable Members

        public void Dispose()
        {
            log.Close();  
        }

        #endregion
    }
}
