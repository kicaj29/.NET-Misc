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
            IParent mock = Substitute.For<IParent>();
            IChild child = new ChildClass(mock);

            child.MethodWithNoParams();
            mock.Received().MethodWithNoParams();


            mock.TwoParamsAndReturnList("abc", 123).Returns(["qq", "ww"]);
            List<string> listString = child.TwoParamsAndReturnList("abc", 123);
            mock.Received().TwoParamsAndReturnList("abc", 123);
            Assert.That(listString[0], Is.EqualTo("qq"));
            Assert.That(listString[1], Is.EqualTo("ww"));


            mock.MethodWithParamsAndReturnValueAsync("abc", 123).Returns(["qq", "ww"]);
            List<string> listStringAsync = await child.MethodWithParamsAndReturnValueAsync("abc", 123);
            await mock.Received().MethodWithParamsAndReturnValueAsync("abc", 123);
            Assert.That(listStringAsync[0], Is.EqualTo("qq"));
            Assert.That(listStringAsync[1], Is.EqualTo("ww"));

            //mock.HandlePersonAsync(Arg.Any<Person>()).Returns("qq_123");

            mock.HandlePersonAsync(Arg.Is<Person>(p => p.Name == "John" && p.Age == 30)).Returns("wrrr");
            string personSummary = await child.HandlePersonAsync(new Person { Name = "John", Age = 30 });
            await mock.Received().HandlePersonAsync(Arg.Is<Person>(p => p.Name == "John" && p.Age == 30));
            Assert.That(personSummary, Is.EqualTo("wrrr"));

            Assert.Pass();
        }
    }
}