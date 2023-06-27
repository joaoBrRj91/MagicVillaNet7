using System;
using MagicVilla.API.Logging.Enums;
using MagicVilla.API.Logging.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.API.Logging
{
    public class ConsoleLog : IGenerationLogging
    {
        private readonly ILogger<ConsoleLog> logger;

        public ConsoleLog(ILogger<ConsoleLog> logger)
        {
            this.logger = logger;
        }

        public void Log(string mensage, LogLevelCustomLogEnum logLevelCustomLog)
        {

            if (logLevelCustomLog == LogLevelCustomLogEnum.Info)
                logger.LogInformation(mensage);

            if (logLevelCustomLog == LogLevelCustomLogEnum.Error)
                logger.LogError(mensage);

        }
    }
}

