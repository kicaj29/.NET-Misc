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
        public async Task TestMocking()
        {
            IParent parent = Substitute.For<IParent>();
            IChild child = new ChildClass(parent);

            child.MethodWithNoParams();
            parent.Received().MethodWithNoParams();


            parent.TwoParamsAndReturnList("abc", 123).Returns(["qq", "ww"]);
            List<string> listString = child.TwoParamsAndReturnList("abc", 123);
            parent.Received().TwoParamsAndReturnList("abc", 123);
            Assert.That(listString[0], Is.EqualTo("qq"));
            Assert.That(listString[1], Is.EqualTo("ww"));


            parent.MethodWithParamsAndReturnValueAsync("abc", 123).Returns(["qq", "ww"]);
            List<string> listStringAsync = await child.MethodWithParamsAndReturnValueAsync("abc", 123);
            await parent.Received().MethodWithParamsAndReturnValueAsync("abc", 123);
            Assert.That(listStringAsync[0], Is.EqualTo("qq"));
            Assert.That(listStringAsync[1], Is.EqualTo("ww"));

            Assert.Pass();
        }
    }
}