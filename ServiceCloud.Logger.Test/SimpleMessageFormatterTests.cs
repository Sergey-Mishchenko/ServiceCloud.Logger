using NUnit.Framework;
using System.Text;
using System;


namespace ServiceCloud.Logger {
    [TestFixture]
    public class SimpleMessageFormatterTests {

        [Test]
        public void SimpleMessageFormatter_Format_ReturnValueSrting_Test() {
            IMessageFormatter simple = new SimpleMessageFormatter();
            string target = simple.Format(2, "SomeMessage");

            Assert.IsInstanceOf<string>(target);
        }


        [Test]
        public void SimpleMessageFormatter_Format_FormatDefault_Test() {
            IMessageFormatter simple = new SimpleMessageFormatter();
            string messageResult = simple.Format(4, "");
            bool target = true;

            string[] messageArray = messageResult.Split(':');
            string leftMessage = messageArray[0];

            string rightMessage = null;
            if(messageArray.Length > 1) {
                for(int i = 1 ; i < messageArray.Length ; i++) {
                    rightMessage = rightMessage + ":" + messageArray[i].ToString();
                }
            } else {
                target = false;
            }

            if(rightMessage == null) {
                target = false;
                rightMessage = "fakeRightMessage";
            }

            string whitespace = rightMessage.Substring(0, 2);
            if(whitespace == ": ") {
                rightMessage = rightMessage.Substring(2, rightMessage.Length - 2);
            } else {
                target = false;
            }

            if(leftMessage.Length == 0 || rightMessage.Length == 0) {
                target = false;
            }

            Assert.IsFalse(target);
        }
    }
}

