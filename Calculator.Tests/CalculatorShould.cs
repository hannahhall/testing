using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int actual = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(83, actual);
        }

        [Fact]
        public void SubtractTwoIntegersShould()
        {
          int actual = _calculator.Subtract(3, 1);
          Assert.Equal(2, actual);
        }
    }
}
