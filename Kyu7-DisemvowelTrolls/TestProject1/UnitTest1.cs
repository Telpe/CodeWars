using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Test1(string input, string expectedOutput)
        {
            // Arrange
            

            // Act
            var actual = Kata.Disemvowel(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}