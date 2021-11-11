using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCloud.Logger {
    public interface ITextFileLogger:ILogger {
      //  Encoding Encoding { get; }

        string FilePath { get; }

      //  string MessageDelimiter { get; }

     //   IMessageFormatter MessageFormatter { get; set; }

    }
}
