using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(" ", "")]
        [TestCase("-", "")]
        [TestCase("_", "")]
        [TestCase("", "")]
        [TestCase("the-stealth-warrior", "theStealthWarrior")]
        [TestCase("the_stealth_warrior", "theStealthWarrior")]
        [TestCase("The_Stealth_Warrior", "TheStealthWarrior")]
        [TestCase("The-Stealth-Warrior", "TheStealthWarrior")]
        [TestCase("The_Stealth-warrior", "TheStealthWarrior")]
        [TestCase("the-Stealth_warrior", "theStealthWarrior")]
        [TestCase("the Stealth warrior", "theStealthWarrior")]
        public void Test1(string input, string expectedOutput)
        {
            // Arrange
            

            // Act
            var actual = Kata.ToCamelCase(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}