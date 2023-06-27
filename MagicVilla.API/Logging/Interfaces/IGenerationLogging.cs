using System;
using MagicVilla.API.Logging.Enums;

namespace MagicVilla.API.Logging.Interfaces
{
	public interface IGenerationLogging
	{
		public void Log(string mensage, LogLevelCustomLogEnum logLevelCustomLog);
	}
}

