using System;
using MagicVilla.API.Logging.Enums;

namespace MagicVilla.API.Logging.Interfaces
{
	public interface IGenerationLogging
	{
		public void Log(string mensage, LogLevel logLevel, string? responseResult = null);

		public string FormatLogLevelMessage(LogLevel logLevel);
	}
}

