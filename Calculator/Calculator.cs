using System;

namespace CalculatorTest
{
    public class Calculator
    {
        private int accumulator;
        private int memory;

        public Calculator()
        {
            accumulator = 0;
        }

        public int add(int number)
        {
            accumulator += number;
            return accumulator;
        }

        public int substract(int number)
        {
            accumulator -= number;
            return accumulator;
        }

        public int multiply(int number)
        {
            accumulator *= number;
            return accumulator;
        }

        public int divide(int number)
        {
            accumulator /= number;
            return accumulator;
        }

        public void save()
        {
            memory = accumulator;
        }

        public int read()
        {
            return memory;
        }

        public void erase()
        {
            memory = 0;
        }
    }
}