using Calculator;
using Xunit;

namespace CalculatorTests
{
    public class SumCalculatorTests
    {
        [Fact]
        public void SumOfTwoAndTwoIsFour()
        {
            // ARRANGE
            var sut = new SumCalculator();

            // ACT
            var result = sut.Sum(2, 2);

            // ASSERT
            Assert.Equal(4, result);
        }
    }
}