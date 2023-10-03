using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(23, 10)]
        [TestCase(78, 20)]
        [TestCase(9168, 200)]
        [TestCase(0, 0)]
        public void Test1(int input, int expectedOutput)
        {
            // Arrange


            // Act
            var actual = Kata.Solution(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

    }
}