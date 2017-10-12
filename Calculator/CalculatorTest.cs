using System;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    class CalculatorTest
    {
        [TestCase]
        public void addCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(12, (calculator.add(4, 8)));
        }

        [TestCase]
        public void substractCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(24, (calculator.substract(50, 26)));
        }

        [TestCase]
        public void multiplyCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(48, (calculator.multiply(2, 24)));
        }

        [TestCase]
        public void divideCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(3, (calculator.divide(9, 3)));
        }

        [TestCase]
        public void readCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, (calculator.read()));
        }
        
    }
}
