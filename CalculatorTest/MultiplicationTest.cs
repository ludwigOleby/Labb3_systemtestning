using Labb3_systemtestning;
using System;
using Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class MultiplicationTest
    {
        [Fact]
        public void Multiplication10times10shouldReturn100()
        {
            // Arrange
            Calculator sut = new Calculator { calculations = new List<string>() };
            sut.multiplication(10, 10);

            // Act
            var expected = 100;
            var actual = sut.result;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 1)]
        [InlineData(43, 24)]
        [InlineData(-5, -5)]
        [InlineData(-100, 100)]
        [InlineData(123456, 789123)]
        public void MultiplicationTheoryTest(int num1, int num2)
        {
            // Arrange
            Calculator sut = new Calculator { calculations = new List<string>() };
            sut.multiplication(num1, num2);

            //Act
            var expected = num1 * num2;
            var actual = sut.result;
            bool test;
            if (expected == actual)
            {
                test = true;
            }
            else
            {
                test = false;
            }

            //Assert
            Assert.True(test);
        }

    }
}
