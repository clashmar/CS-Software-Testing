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
        [TestCase(null, TestName = "Returns East when passed North and Right.")]
        public void CompassRotateTest()
        {
            Compass.Rotate(Enums.Point.North, Enums.Direction.Right).Should().Be(Enums.Point.East);
        }
    }
}