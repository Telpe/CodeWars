using KataSolution;

namespace TestProject1
{
    public class Tests
    {
        [TestCase("1", 1)]
        [TestCase("22\n21", 2)]
        [TestCase("333\n322\n321", 3)]
        [TestCase("7777777\n7666666\n7655555\n7654444\n7654333\n7654322\n7654321", 7)]
        [TestCase("77777777777777777\n76666666666666666\n76555555555555555\n76544444444444444\n76543333333333333\n76543222222222222\n76543211111111111\n76543210000000000\n76543210999999999\n76543210988888888\n76543210987777777\n76543210987666666\n76543210987655555\n76543210987654444\n76543210987654333\n76543210987654322\n76543210987654321", 17)]
        [TestCase("777777777777777777777777777\n766666666666666666666666666\n765555555555555555555555555\n765444444444444444444444444\n765433333333333333333333333\n765432222222222222222222222\n765432111111111111111111111\n765432100000000000000000000\n765432109999999999999999999\n765432109888888888888888888\n765432109877777777777777777\n765432109876666666666666666\n765432109876555555555555555\n765432109876544444444444444\n765432109876543333333333333\n765432109876543222222222222\n765432109876543211111111111\n765432109876543210000000000\n765432109876543210999999999\n765432109876543210988888888\n765432109876543210987777777\n765432109876543210987666666\n765432109876543210987655555\n765432109876543210987654444\n765432109876543210987654333\n765432109876543210987654322\n765432109876543210987654321", 27)]
        [TestCase("", 0)]
        [TestCase("", -10)]
        [TestCase("", -89)]
        public void Test1(string output, int input)
        {
            // Arrange


            // Act
            var actual = Pattern16.Pattern(input);

            // Assert
            Assert.That(actual, Is.EqualTo(output));
        }


    }
}