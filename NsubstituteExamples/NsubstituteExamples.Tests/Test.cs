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

            Assert.Pass();
        }
    }
}