using NUnit.Framework;
using System.Text;
using System;


namespace ServiceCloud.Logger {
    [TestFixture]
    public class SimpleMessageFormatterTests {

        [TestCase(1,"")]
        [TestCase(0,"someMessage")]
        [TestCase(-1,null)]
        public void SimpleMessageFormatter_Format_Test(int level, string mess) {
            IMessageFormatter target = new SimpleMessageFormatter();

            string result = target.Format(level, mess);
            string expected = level+ ": " + mess;

            Assert.AreEqual(expected, result);
        }
    }
}

