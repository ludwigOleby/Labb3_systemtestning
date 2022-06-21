using Labb3_systemtestning;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorTest
{
    public class UserInputTest
    {

        [Fact]
        public void UserInputTestShouldBe5()
        {
            // Arrange
            Calculator sut = new Calculator { calculations = new List<string>() };

            // Act
            sut.firstUserInput();
            var expected = 5;

            var actual = sut.num1;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
