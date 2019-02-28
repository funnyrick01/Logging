using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoggingWebsite.Helpers
{
    public class LoggingHelper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void writeToFile(string type, string message)
        {
            if (type.ToLower() == "info")
            {
                logger.Info("\r\n" + message);
            }
            else if (type.ToLower() == "warning")
            {
                logger.Warn("\r\n" + message);
            }
            else if (type.ToLower() == "debug")
            {
                logger.Debug("\r\n" + message);
            }
            else if (type.ToLower() == "error")
            {
                logger.Error("\r\n" + message);
            }
            else
            {
                logger.Error("\r\nType " + type + " komt niet voor in de logginghelper.cs");
            }
        }
    }
}