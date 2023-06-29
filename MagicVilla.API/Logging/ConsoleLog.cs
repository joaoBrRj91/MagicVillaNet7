using System.Text;
using MagicVilla.API.Logging.Interfaces;

namespace MagicVilla.API.Logging
{
    public class ConsoleLog : IGenerationLogging
    {
        private readonly ILogger<ConsoleLog> logger;

        public ConsoleLog(ILogger<ConsoleLog> logger)
        {
            this.logger = logger;
        }

        public string FormatLogLevelMessage(LogLevel logLevel)
            => $"==== {logLevel} ====";

        public void Log(string mensage, LogLevel logLevel, string? responseResult = null)
        {

            logger.Log(logLevel, FormatLogLevelMessage(logLevel));

            var finalMessageLog = new StringBuilder();
            finalMessageLog.AppendLine($"Message : {mensage}");
            finalMessageLog.AppendLine($"Response Result : {responseResult ?? "Process dont produce response"}");


            logger.Log(logLevel, finalMessageLog.ToString());

        }

        
        
    }
}

