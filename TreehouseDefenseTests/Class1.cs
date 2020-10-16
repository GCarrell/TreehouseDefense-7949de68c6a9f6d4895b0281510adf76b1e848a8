using Xunit;
namespace TreehouseDefense.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Initialization()
        {
            var expected = 1.1;
            var target = new Calculator(1.1);
            Assert.Equal(expected, target.Result, 1);
        }

        [Fact]
        public void BasicAdd()
        {
            var target = new Calculator(1.1);
            target.Add(2.2);
            var expected = 3.3;
            Assert.Equal(expected, target.Result, 1);
        }
    }
}