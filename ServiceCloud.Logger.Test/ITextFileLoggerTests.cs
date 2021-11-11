using NUnit.Framework;
using ServiceCloud.Logger;

namespace ServiceCloud.Logger.Test {
    [TestFixture]
    public class ITextFileLoggerTests {

        abstract class TestObject { }    // абстрактный класс Product
        abstract class CreatorTestObject {   // абстрактный класс Creator

            public abstract TestObject FilePath();         
        }

        class CreatorTestObjectA : CreatorTestObject {
            public override TestObject FilePath() {                 
                return new TestObject_A(); 
            }
        }

        class TestObject_A : TestObject {
            string path = @"D:\Source\Patterns & Delegate & OOP\Factory Method";
            public string FilePath {
                get { return path; }
            }
        }

        class TestObject1 : TestObject { }

        [Test]
        public void ITextFileLogger_FilePath_checkDefaultValue_Test() {
            CreatorTestObject c = new CreatorTestObjectA();
            TestObject target = c.FilePath;



            //target.FilePath;
            //Assert.IsNotNull(result);
            //Assert.AreNotEqual("", result);
        }





    }
}