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
        [Test]
        [TestCase(TestName = "Returns reversed string when passed any string")]
        public void ReverseStringTest()
        {
            Assert.Multiple(() =>
            {
                StringManipulator.ReverseString("test").Should().Be("tset");
                StringManipulator.ReverseString("").Should().Be("");
                StringManipulator.ReverseString("Look over there!!").Should().Be("!!ereht revo kooL");
            });
        }

        [Test]
        [TestCase(TestName = "Return true when passed racecar")]
        public void IsPalindromeTest_1()
        {

            StringManipulator.IsPalindrome("racecar").Should().Be(true);
        }

        [Test]
        [TestCase(TestName = "Return true when passed different casing and spaces")]
        public void IsPalindromeTest_2()
        {

            Assert.Multiple(() =>
            {
                StringManipulator.IsPalindrome("Racecar").Should().Be(true);
                StringManipulator.IsPalindrome("Taco cat").Should().Be(true);
                StringManipulator.IsPalindrome("A man a plan a canal Panama").Should().Be(true);
            });
        }


        [Test]
        [TestCase(TestName = "Return single word when only one word in the string is longest")]
        public void FindLongestWordsTest_1()
        {
            var analyser = new WordAnalyser();
            string input = "This is some example test data - come up with your own!";
            List<string> longestWords = new List<string>{ "example" };
            Assert.That(analyser.FindLongestWords(input), Is.EquivalentTo(longestWords));
        }

        [Test]
        [TestCase(TestName = "Return multiple words when multiple words in the string are longest")]
        public void FindLongestWordsTest_2()
        {
            var analyser = new WordAnalyser();
            string input = "This is some example testing datasss - comeeee up with yourrrr own!";
            List<string> longestWords = new List<string> { "example", "testing", "datasss", "comeeee", "yourrrr" };
            Assert.That(analyser.FindLongestWords(input), Is.EquivalentTo(longestWords));
        }

        [Test]
        [TestCase(TestName = "Returns the number 3 when passed the character 'l'")]
        public void CalculateLetterFrequencyTest_1()
        {
            var analyser = new WordAnalyser();
            analyser.CalculateLetterFrequency("Hello world")['l'].Should().Be(3);
        }

        [Test]
        [TestCase(TestName = "Returns the number 0 when passed the character 'z'")]
        public void CalculateLetterFrequencyTest_2()
        {
            var analyser = new WordAnalyser();

            analyser.CalculateLetterFrequency("This is a fairly boring thing.")['z'].Should().Be(0);
        }
    }
            
}
