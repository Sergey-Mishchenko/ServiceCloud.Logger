using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCloud.Logger {
    public class RealizationITextFileLogger: ITextFileLogger {
        private string result = @"D:\Source\ServiceCloud.Logger";

        public string FilePath {
            get { return result; }
        }
    }
}
