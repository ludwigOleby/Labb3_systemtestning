using Labb3_systemtestning;
using System;
using Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class AdditionTest
    {
        [Fact]
        public void addition1plus1shouldReturn2()
        {
            // Arrange
            Calculator sut = new Calculator { calculations = new List<string>() };
            sut.addition(10, 10);

            // Act
            var expected = 20;
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
        public void AdditionTheoryTest(int num1, int num2)
        {
            // Arrange
            Calculator sut = new Calculator { calculations = new List<string>() };
            sut.addition(num1, num2);

            //Act
            var expected = num1 + num2;
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
