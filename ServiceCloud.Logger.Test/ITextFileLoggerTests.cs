using NUnit.Framework;
using ServiceCloud.Logger;

namespace ServiceCloud.Logger.Test {
    [TestFixture]
    public class ITextFileLoggerTests {

        abstract class CreatorTestObject {   
            public abstract TestObject FactoryMethod();
        }

        class CreatorTestObjectA : CreatorTestObject {
            public CreatorTestObjectA() { }

            public override TestObject FactoryMethod() {
                return new TestObjectA();
            }
        }

        abstract class TestObject {
            public abstract string FilePath { get; }
        }

        class TestObjectA : TestObject {
            private readonly string path;

            public TestObjectA() {
                path = @"D:\Source\Patterns & Delegate & OOP\Factory Method";

            }

            public override string FilePath {
                get { return path; }
            }
        }

        [Test]
        public void ITextFileLogger_FilePath_checkDefaultValue_Test() {

            CreatorTestObject c = new CreatorTestObjectA();
            TestObject some_object = new TestObjectA();
            string result = some_object.FilePath;

           
            Assert.IsNotNull(result);
            Assert.AreNotEqual("", result);
        }





    }
}