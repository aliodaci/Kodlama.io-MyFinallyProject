﻿namespace Core.CrosCuttingConcers.Logging.Log4Net.Loggers
{
    public partial class DatabaseLogger
    {
        public class FileLogger : LoggerServiceBase
        {
            public FileLogger() : base("JsonFileLogger")
            {
            }
        }
    }
}
