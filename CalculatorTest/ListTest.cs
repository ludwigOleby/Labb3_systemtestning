using Labb3_systemtestning;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorTest
{
    public class ListTest
    {
        [Fact]
        public void ListShouldNotBeNull()
        {
            // Arrange
            Calculator sut = new Calculator();

            //Act
            sut.calculations = new List<string>();
            sut.addition(3, 2); // One of the calculation methods needs to run to fill the list

            //Assert
            Assert.NotEmpty(sut.calculations);
        }

    }
}
