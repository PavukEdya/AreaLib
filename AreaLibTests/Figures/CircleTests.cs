using NUnit.Framework;

namespace AreaLib.Figures.Tests
{
    [TestFixture()]
    public class CircleTests
    {
        [Test]
        public void CircleTest()
        {
            var c = new Circle(5);
            Assert.IsNotNull(c);
            Assert.AreEqual(c.Radius, 5.0);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void CircleAreaTest(double r)
        {
            var c = new Circle(r);
            var area = Math.PI * Math.Pow(r, 2);
            Assert.AreEqual(c.Area(), area);
        }
    }
}