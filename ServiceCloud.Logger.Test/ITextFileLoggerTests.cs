using NUnit.Framework;
using ServiceCloud.Logger;
using System.Text;
using System;
using System.Collections.Generic;

namespace ServiceCloud.Logger.Test {
    [TestFixture]
    abstract public class ITextFileLoggerTests {
        protected abstract ITextFileLogger FactoryMethod();

        [Test]
        public void ITextFileLogger_Encoding_DefaultValue_Test() {
            ITextFileLogger tfLogger = FactoryMethod();
            string target = tfLogger.ToString();

            Assert.IsFalse(string.IsNullOrEmpty(target));
        }

        [Test]
        public void ITextFileLogger_FilePath_DefaultValue_Test() {
            ITextFileLogger target = FactoryMethod();

            Assert.IsFalse(string.IsNullOrEmpty(target.FilePath));
        }

        [Test]
        public void ITextFileLogger_MessageDelimiter_DefaultValue_Test() {
            ITextFileLogger target = FactoryMethod();

            Assert.IsFalse(string.IsNullOrEmpty(target.MessageDelimiter));
        }

        [Test]
        public void ITextFileLogger_MessageFormatter_DefaultValue_Test() {
            ITextFileLogger ftLogger = FactoryMethod();
            IMessageFormatter mFormatter = ftLogger.MessageFormatter;
            string target = mFormatter.ToString();

            Assert.IsFalse(string.IsNullOrEmpty(target));
        }

        [Test]
        public void ITextFileLogger_MessageFormatter_DefaultEntry_Test() {
            ITextFileLogger target = FactoryMethod();
           
            

        }



    }
}