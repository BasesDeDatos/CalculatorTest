using System;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    class CalculatorTest
    {
        /*
         * Conjuntos frontera: número < 0, número = 0, número > 0
         * Valor neutro: 0
        */
        [TestCase]
        public void addCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(8, (calculator.add(8)));
        }

        [TestCase]
        public void addNegativeCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(8);
            Assert.AreEqual(0, (calculator.add(-8)));
        }

        [TestCase]
        public void addZeroCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, (calculator.add(0)));
        }

        /*
         * Conjuntos frontera: número < 0, número = 0, número > 0
         * Valor neutro: 0
        */
        [TestCase]
        public void substractCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(-50, (calculator.substract(50)));
        }

        [TestCase]
        public void substractNegativeCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(12);
            Assert.AreEqual(24, (calculator.substract(-12)));
        }

        [TestCase]
        public void substractZeroCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, (calculator.substract(0)));
        }


        /*
         * Conjuntos frontera: número < 0, número = 0, número > 0
         * Valor absobente: 0
         * Valor neutro: 1
        */
        [TestCase]
        public void multiplyCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(100);
            Assert.AreEqual(400, (calculator.multiply(4)));
        }

        [TestCase]
        public void multiplyByNegativeCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(50);
            Assert.AreEqual(-100, (calculator.multiply(-2)));
        }

        [TestCase]
        public void multiplyByZeroCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, (calculator.multiply(24)));
        }

        [TestCase]
        public void multiplyByOneCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(450);
            Assert.AreEqual(450, (calculator.multiply(1)));
        }

        /*
         * Conjuntos frontera: número < 0, número = 0, número > 0
         * Valor absobente: 0
         * Valor neutro: 1
        */
        [TestCase]
        public void divideCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(9);
            Assert.AreEqual(3, (calculator.divide(3)));
        }

        [TestCase]
        public void divideOfZeroCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, (calculator.divide(3)));
        }

        [TestCase]
        public void divideByOneCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(234);
            Assert.AreEqual(234, (calculator.divide(1)));
        }

        [TestCase]
        public void divideByZeroCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(10);
            Assert.Catch<DivideByZeroException>(() => calculator.divide(0));
        }

        [TestCase]
        public void readCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(100);
            calculator.save();
            Assert.AreEqual(100, (calculator.read()));
        }

        [TestCase]
        public void saveCase()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, (calculator.read()));
            calculator.substract(-45);
            calculator.save();
            Assert.AreEqual(45, (calculator.read()));
        }

        [TestCase]
        public void eraseCase()
        {
            Calculator calculator = new Calculator();
            calculator.add(39);
            calculator.save();
            Assert.AreEqual(39, (calculator.read()));
            calculator.erase();
            Assert.AreEqual(0, calculator.read());
        }

    }
}
