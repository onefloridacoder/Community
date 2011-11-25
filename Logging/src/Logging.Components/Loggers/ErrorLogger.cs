using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logging.Components
{
    public interface IErrorLogger
    {
        void LogError(ScreenKeyType screenContext, string message, string stackTrace, LoggingType loggingType);
    }
    
    public class ErrorLogger : IErrorLogger
    {
        IIsoStoreService IsoStoreService { get; set; }
        ILoggingService LoggingService { get; set; }

        public ErrorLogger(IIsoStoreService isoStoreService, ILoggingService loggingService)
        {
            this.IsoStoreService = isoStoreService;
            this.LoggingService = loggingService;
        }

        public void LogError(ScreenKeyType screenContext, string message, string stackTrace, LoggingType loggingType)
        {
            switch (loggingType)
            {
                case LoggingType.Client:
                    this.IsoStoreService.WriteToStore(screenContext, message, stackTrace);
                    break;
                case LoggingType.Server:
                    this.LoggingService.WriteExceptionToLogs(message, stackTrace);
                    break;
                case LoggingType.ClientAndServer:
                    this.LoggingService.WriteExceptionToLogs(message, stackTrace);
                    this.IsoStoreService.WriteToStore(screenContext, message, stackTrace);
                    break;
            }
        }
    }
}
