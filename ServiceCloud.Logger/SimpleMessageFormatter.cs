using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCloud.Logger {
    public class SimpleMessageFormatter : IMessageFormatter {
        string IMessageFormatter.Format(int level, string message) {
            string result = level+": "+message;
            return result;
        }
    }
}
