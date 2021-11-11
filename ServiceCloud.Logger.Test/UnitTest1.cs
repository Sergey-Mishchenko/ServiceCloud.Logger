using NUnit.Framework;
using ServiceCloud.Logger;

namespace ServiceCloud.Logger.Test {
    public class Tests {
       
        private RealizationITextFileLogger fileLogger = null;

        [SetUp]
        public void Setup() {
            fileLogger = new Logger.RealizationITextFileLogger();
        }

        [Test]           
        public void Encoding_checkForNull_returnIsNotNull() {
            string result = null;
          //  result = fileLogger.Encoding();
            Assert.IsNotNull(result);
        }

        [Test]

        public void FilePath_checkForNull_returnIsNotNull() {
            string result = null;             
            result = fileLogger.FilePath();
            Assert.IsNotNull(result);
        }

        [Test]
        public void MessageDelimiter_checkForNull_returnIsNotNull() {
            string result = null;
          //  result = fileLogger.MessageDelimiter();
            Assert.IsNotNull(result);
        }

        [Test]
        public void FilePath_checkForEmpty_returnIsNotEmpty() {
            string result = null;
            result = fileLogger.FilePath();
            Assert.AreNotEqual("", result);
        }

        [Test]
        public void MessageDelimiter_checkForEmpty_returnIsNotEmpty() {
            string result = null;
         //   result = fileLogger.MessageDelimiter();
            Assert.AreNotEqual("", result);
        }

        [TearDown]
        public void DerivedTearDown() {
            fileLogger = null;
        }
    }
}