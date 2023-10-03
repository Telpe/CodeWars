using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase("", "")]
        [TestCase("aabcdoeofghijklmnopqrstuuvwxyz", "bcdfghjklmnpqrstvwxyz")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "bcdfghjklmnpqrstvwxyz")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "BCDFGHJKLMNPQRSTVWXYZ")]
        public void Test1(string input, string expectedOutput)
        {
            // Arrange
            

            // Act
            var actual = Kata.Disemvowel(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }

        [TestCase("", "")]
        [TestCase("aabcdoeofghijklmnopqrstuuvwxyz", "bcdfghjklmnpqrstvwxyz")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "bcdfghjklmnpqrstvwxyz")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "BCDFGHJKLMNPQRSTVWXYZ")]
        public void Test2(string input, string expectedOutput)
        {
            // Arrange


            // Act
            var actual = Kata.Disemvowel2(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}