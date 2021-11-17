using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCloud.Logger
{

    public class SimpleMessageFormatter : IMessageFormatter {
        /// <summary>
        /// Реализаця интерфейса IMessageFormatter
        /// </summary>
        string IMessageFormatter.Format(int level, string message) {
            /// <summary>
            /// Реализаця приводящую журналируемое сообщение к виду: «level: message»
            /// </summary>
            string result = level + ": " + message;
            return result;
        }
    }
}
