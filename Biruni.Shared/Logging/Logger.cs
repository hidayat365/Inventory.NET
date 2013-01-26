using System;
using System.Diagnostics;
using System.Net;
using System.IO; 
using System.Xml;

namespace Biruni.Shared.Logging
{
    // Author : Mohamed Ashraf
    // Date Written : 9th April 2003
    // Date Modified: 14th April 2003

    /// <summary>
    /// Logger is used for creating a customized error log files or an error can be registered as
    /// a log entry in the Windows Event Log on the administrator's machine.
    /// </summary>
    public class Logger
    {
        protected static string strLogFilePath = string.Empty;

        /// <summary>
        /// Setting LogFile path. If the logfile path is null then it will update error info into LogFile.txt under
        /// application directory.
        /// </summary>
        public static string LogFilePath
        {
            set
            {
                strLogFilePath = value;
            }
            get
            {
                return strLogFilePath;
            }
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Logger() { }

        /// <summary>
        /// Write error log entry to customized text-based text file
        /// </summary>
        /// <param name="objException"></param>
        /// <returns></returns>
        public static bool DebugRoutine(string strDebug)
        {
            if (true != WriteErrorLog(GetLogFilePath(), strDebug))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Write error log entry to customized text-based text file
        /// </summary>
        /// <param name="objException"></param>
        /// <returns></returns>
        public static bool ErrorRoutine(Exception objException)
        {
            return ErrorRoutine(false, objException);
        }

        /// <summary>
        /// Write error log entry for window event if the bLogType is true. Otherwise, write the log entry to
        /// customized text-based text file
        /// </summary>
        /// <param name="bLogType"></param>
        /// <param name="objException"></param>
        /// <returns>false if the problem persists</returns>
        public static bool ErrorRoutine(bool bLogType, Exception objException)
        {
            try
            {
                //Check whether logging is enabled or not
                bool bLoggingEnabled = false;
                bLoggingEnabled = CheckLoggingEnabled();

                //Don't process more if the logging 
                if (false == bLoggingEnabled)
                    return true;

                //Write to Windows event log
                if (true == bLogType)
                {
                    string EventLogName = "Biruni IMS";

                    if (!EventLog.SourceExists(EventLogName))
                        EventLog.CreateEventSource(objException.Message, EventLogName);

                    // Inserting into event log
                    EventLog Log = new EventLog();
                    Log.Source = EventLogName;
                    Log.WriteEntry(objException.Message, EventLogEntryType.Error);
                }
                //Custom text-based event log
                else
                {
                    if (true != CustomErrorRoutine(objException))
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Check Logginstatus config file is exist. If exist read the value set the loggig status
        /// </summary>
        private static bool CheckLoggingEnabled()
        {
            string strLoggingStatusConfig = string.Empty;

            strLoggingStatusConfig = GetLoggingStatusConfigFileName();

            //If it's empty then enable the logging status 
            if (strLoggingStatusConfig.Equals(string.Empty))
            {
                return true;
            }
            else
            {

                //Read the value from xml and set the logging status
                bool bTemp = GetValueFromXml(strLoggingStatusConfig);
                return bTemp;
            }
        }

        /// <summary>
        /// Check the Logginstatus config under debug or release folder. If not exist, check under 
        /// project folder. If not exist again, return empty string
        /// </summary>
        /// <returns>empty string if file not exists</returns>
        private static string GetLoggingStatusConfigFileName()
        {
            string strCheckinBaseDirecotry = AppDomain.CurrentDomain.BaseDirectory + "Logging\\LoggingStatus.Config";

            if (File.Exists(strCheckinBaseDirecotry))
                return strCheckinBaseDirecotry;
            else
            {
                string strCheckinApplicationDirecotry = GetApplicationPath() + "Logging\\LoggingStatus.Config";

                if (File.Exists(strCheckinApplicationDirecotry))
                    return strCheckinApplicationDirecotry;
                else
                    return string.Empty;
            }
        }

        /// <summary>
        /// Read the xml file and getthe logging status
        /// </summary>
        /// <param name="strXmlPath"></param>
        /// <returns></returns>
        private static bool GetValueFromXml(string strXmlPath)
        {
            try
            {
                //Open a FileStream on the Xml file
                FileStream docIn = new FileStream(strXmlPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                XmlDocument contactDoc = new XmlDocument();
                //Load the Xml Document
                contactDoc.Load(docIn);

                //Get a node
                XmlNodeList UserList = contactDoc.GetElementsByTagName("LoggingEnabled");

                //get the value
                string strGetValue = UserList.Item(0).InnerText.ToString();

                if (strGetValue.Equals("0"))
                    return false;
                else if (strGetValue.Equals("1"))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// If the LogFile path is empty then, it will write the log entry to LogFile.txt under application directory.
        /// If the LogFile.txt is not availble it will create it
        /// If the Log File path is not empty but the file is not availble it will create it.
        /// </summary>
        /// <param name="objException"></param>
        /// <returns>false if the problem persists</returns>
        private static bool CustomErrorRoutine(Exception objException)
        {
            bool bReturn = true;
            // write the error log to that text file
            if (true != WriteErrorLog(GetLogFilePath(), objException))
            {
                bReturn = false;
            }
            return bReturn;
        }

        /// <summary>
        /// Write custom information to the text file for debuging purpose
        /// </summary>
        /// <param name="strPathName"></param>
        /// <param name="strRemarks"></param>
        /// <returns>false if the problem persists</returns>
        private static bool WriteErrorLog(string strPathName, string strRemarks)
        {
            bool bReturn = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(strPathName, true))
                {
                    sw.WriteLine("[{0}] {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strRemarks);
                    sw.Flush();
                    sw.Close();
                }
                bReturn = true;
            }
            catch (Exception)
            {
                bReturn = false;
            }
            return bReturn;
        }

        /// <summary>
        /// Write Source,method,date,time,computer,error and stack trace information to the text file
        /// </summary>
        /// <param name="strPathName"></param>
        /// <param name="objException"></param>
        /// <returns>false if the problem persists</returns>
        private static bool WriteErrorLog(string strPathName, Exception objException)
        {
            bool bReturn = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(strPathName, true))
                {
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine("^^-------------------------------------------------------------------^^");
                    sw.WriteLine("Source      : " + objException.Source.ToString().Trim());
                    sw.WriteLine("Method      : " + objException.TargetSite.Name.ToString());
                    sw.WriteLine("Date        : " + DateTime.Now.ToLongTimeString());
                    sw.WriteLine("Time        : " + DateTime.Now.ToShortDateString());
                    sw.WriteLine("Computer    : " + Dns.GetHostName().ToString());
                    sw.WriteLine("Error       : " + objException.Message.ToString().Trim());
                    sw.WriteLine("Stack Trace : " + objException.StackTrace.ToString().Trim());
                    sw.WriteLine("^^-------------------------------------------------------------------^^");
                    sw.Flush();
                    sw.Close();
                }
                bReturn = true;
            }
            catch (Exception)
            {
                bReturn = false;
            }
            return bReturn;
        }

        /// <summary>
        /// Check the log file in applcation directory. If it is not available, creae it
        /// </summary>
        /// <returns>Log file path</returns>
        private static string GetLogFilePath()
        {
            try
            {
                // get the base directory
                string baseDir = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.RelativeSearchPath;

                // search the file below the current directory
                string retFilePath;
                if (String.IsNullOrEmpty(LogFilePath))
                {
                    retFilePath = baseDir + "Logging\\LogFile-" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                    LogFilePath = retFilePath;
                }
                else
                {
                    retFilePath = LogFilePath;
                }

                // if exists, return the path
                if (File.Exists(retFilePath))
                    return retFilePath;

                //create a text file
                else
                {
                    if (false == CheckDirectory(retFilePath)) return string.Empty;
                    FileStream fs = new FileStream(retFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                }

                return retFilePath;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Create a directory if not exists
        /// </summary>
        /// <param name="strLogPath"></param>
        /// <returns></returns>
        private static bool CheckDirectory(string strLogPath)
        {
            try
            {
                int nFindSlashPos = strLogPath.Trim().LastIndexOf("\\");
                string strDirectoryname = strLogPath.Trim().Substring(0, nFindSlashPos);

                if (false == Directory.Exists(strDirectoryname))
                    Directory.CreateDirectory(strDirectoryname);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private static string GetApplicationPath()
        {
            try
            {
                string strBaseDirectory = AppDomain.CurrentDomain.BaseDirectory.ToString();
                int nFirstSlashPos = strBaseDirectory.LastIndexOf("\\");
                string strTemp = string.Empty;

                if (0 < nFirstSlashPos)
                    strTemp = strBaseDirectory.Substring(0, nFirstSlashPos);

                int nSecondSlashPos = strTemp.LastIndexOf("\\");
                string strTempAppPath = string.Empty;
                if (0 < nSecondSlashPos)
                    strTempAppPath = strTemp.Substring(0, nSecondSlashPos);

                string strAppPath = strTempAppPath.Replace("bin", "");
                return strAppPath;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
