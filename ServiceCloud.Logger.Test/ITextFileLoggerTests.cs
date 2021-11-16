using NUnit.Framework;
using System.Text;
using System;
using Moq;


namespace ServiceCloud.Logger.Test {
    [TestFixture]
    abstract public class SimpleMessageFormatterTests {
        protected abstract ITextFileLogger CreateTestObject();

        [Test]
        public void ITextFileLogger_Encoding_DefaultValue_Test() {
            ITextFileLogger tfLogger = CreateTestObject();
            string target = tfLogger.ToString();

            Assert.IsFalse(string.IsNullOrEmpty(target));
        }

        [Test]
        public void ITextFileLogger_FilePath_DefaultValue_Test() {
            ITextFileLogger target = CreateTestObject();

            Assert.IsFalse(string.IsNullOrEmpty(target.FilePath));
        }

        [Test]
        public void ITextFileLogger_MessageDelimiter_DefaultValue_Test() {
            ITextFileLogger target = CreateTestObject();

            Assert.IsFalse(string.IsNullOrEmpty(target.MessageDelimiter));
        }

        [Test]
        public void ITextFileLogger_MessageFormatter_DefaultValue_Test() {
            ITextFileLogger ftLogger = CreateTestObject();

            Assert.IsNotNull(ftLogger.MessageFormatter);
        }

        [Test]
        public void ITextFileLogger_MessageFormatter_SetCorrectValue_Test() {
            ITextFileLogger target = CreateTestObject();
            var expected = Moq.Mock.Of<IMessageFormatter>();

            target.MessageFormatter = expected;

            Assert.AreEqual(expected, target.MessageFormatter);
        }

        [Test]
        public void ITextFileLogger_MessageFormatter_SetIncorrectValue_Test() {
            ITextFileLogger target = CreateTestObject();

            Assert.Catch<ArgumentNullException>(() => target.MessageFormatter = null) ;
        }
    }
}
