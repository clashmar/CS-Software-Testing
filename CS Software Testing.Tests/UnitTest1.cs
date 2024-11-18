using FluentAssertions;

namespace CS_Software_Testing.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(TestName = "Returns East when passed North and Right.")]
        public void CompassRotateTest()
        {
            Compass.Rotate(Enums.Point.North, Enums.Direction.Right).Should().Be(Enums.Point.East);
        }

        [Test]
        [TestCase(TestName = "Returns correct direction when passed right turn")]
        public void MultipleAssertsRight()
        {
            Assert.Multiple(() =>
            {
                Compass.Rotate(Enums.Point.North, Enums.Direction.Right).Should().Be(Enums.Point.East);
                Compass.Rotate(Enums.Point.East, Enums.Direction.Right).Should().Be(Enums.Point.South);
                Compass.Rotate(Enums.Point.South, Enums.Direction.Right).Should().Be(Enums.Point.West);
                Compass.Rotate(Enums.Point.West, Enums.Direction.Right).Should().Be(Enums.Point.North);
            });
        }

        [Test]
        [TestCase(TestName = "Returns correct direction when passed left turn")]
        public void MultipleAssertsLeft()
        {
            Assert.Multiple(() =>
            {
                Compass.Rotate(Enums.Point.North, Enums.Direction.Left).Should().Be(Enums.Point.West);
                Compass.Rotate(Enums.Point.East, Enums.Direction.Left).Should().Be(Enums.Point.North);
                Compass.Rotate(Enums.Point.South, Enums.Direction.Left).Should().Be(Enums.Point.East);
                Compass.Rotate(Enums.Point.West, Enums.Direction.Left).Should().Be(Enums.Point.South);
            });
        }
    }
}