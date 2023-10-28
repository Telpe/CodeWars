using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 121*121, 19*19, 144*144, 161 * 161, 19 * 19, 144 * 144, 11 * 11, 19 * 19 }, true)]
        [TestCase(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19, 11 * 11 }, true)]
        [TestCase(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, false)]
        public void Test1(int[] a, int[] b, bool c)
        {
            // Arrange


            // Act
            var actual = AreTheySame.comp(a,b);

            // Assert
            Assert.That(actual, Is.EqualTo(c));
        }

        [TestCase(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new int[] { 121, 144, 19, 161, 19, 144, 19 })]
        [TestCase(new int[0], new int[0])]
        public void Test2(int[] a, int[] b)
        {
            // Arrange


            // Act
            var actual = "";

            // Assert
            Assert.Throws<Exception>(() => AreTheySame.comp(a, b));
        }
        
    }
}