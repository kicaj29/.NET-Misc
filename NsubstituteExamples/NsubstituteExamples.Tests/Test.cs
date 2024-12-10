using NSubstitute;

namespace NsubstituteExamples.Tests
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMocking()
        {
            IParent parent = Substitute.For<IParent>();
            IChild child = new ChildClass(parent);

            child.MethodWithNoParams();
            parent.Received().MethodWithNoParams();

            child.MethodWithParamsAndReturnValue("abc", 123).Returns(["qq", "ww"]);
            List<string> listString = child.MethodWithParamsAndReturnValue("abc", 123);
            parent.Received().MethodWithParamsAndReturnValue("abc", 123);
            Assert.That(listString[0], Is.EqualTo("qq"));
            Assert.That(listString[1], Is.EqualTo("ww"));

            Assert.Pass();
        }
    }
}