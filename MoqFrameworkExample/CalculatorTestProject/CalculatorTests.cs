using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Calculator;
using Moq;

namespace CalculatorTestProject
{
    [ExcludeFromCodeCoverage]
    public class CalculatorTests
    {
        [Fact]
        public void TestUsingMoq()
        {
            //var calculator = new ICalculator();
            //Assert.Equal(4, calculator.Add(2, 2));

            //Since we cannot create an instance of ICalcuklator , we mock it
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2,2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));

        }

        [Fact]
        public void AddTest()
        {
            var calculator = new CalculatorOperations();
            Assert.Equal(22, calculator.Add(20, 2));
        }

        [Fact]
        public void SubtractTest()
        {
            var calculator = new Mock<CalculatorOperations>();
            calculator.Setup(x => x.Subtract(20, 2)).Returns(18);
            Assert.Equal(18, calculator.Object.Subtract(20, 2));
        }
        [Fact]
        public void MultiplyTest()
        {
            var calculator = new CalculatorOperations();
            Assert.Equal(40, calculator.Multiply(20, 2));
        }

        [Fact]
        public void DivideTest()
        {
            var calculator = new CalculatorOperations();
            Assert.Equal(10, calculator.Divide(20, 2));
        }
    }
}
