using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase("", true)]
        [TestCase(" h njkds", false)]
        [TestCase(" h nGjHkds", false)]
        [TestCase(" GD F FSDG", true)]
        public void Test1(string input, bool expectedOutput)
        {
            // Arrange


            // Act
            var actual = input.IsUpperCase();

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}