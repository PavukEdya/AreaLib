using NUnit.Framework;

namespace AreaLib.Figures.Tests
{
    [TestFixture()]
    public class TriangleTests
    {
        [Test]
        public void TriangleConstructorTest()
        {
            var t = new Triangle(3, 4, 5);
            Assert.IsNotNull(t);
            Assert.AreEqual(t.SideA, 3);
            Assert.AreEqual(t.SideB, 4);
            Assert.AreEqual(t.SideC, 5);
        }
        [TestCase(1, 2, 3)]
        [TestCase(1, 1, 3)]
        public void TriangleWrongSidesTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => { new Triangle(a, b, c); });
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        [TestCase(7, 24, 25)]
        [TestCase(9, 40, 41)]
        public void TriangleIsRightTest(double a, double b, double c)
        {
            var t = new Triangle(a, b, c);
            Assert.IsTrue(t.IsRight());
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 12, 13, 30)]
        [TestCase(8, 15, 17, 60)]
        [TestCase(7, 24, 25, 84)]
        [TestCase(9, 40, 41, 180)]
        public void TriangleAreaTest(double a, double b, double c, double area)
        {
            var t = new Triangle(a, b, c);
            Assert.AreEqual(t.Area(), area);

        }
    }
}