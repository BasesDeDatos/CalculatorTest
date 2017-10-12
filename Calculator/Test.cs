using System;

namespace CalculatorTest
{
    class Test
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.save(calculator.multiply(100, 10));
            Console.WriteLine(calculator.multiply(calculator.read(), 30));
            Console.ReadKey();
        }
    }
}
