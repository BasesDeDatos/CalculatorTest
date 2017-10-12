using System;

public class Calculator
{
    private float accumulator;

    public Calculator()
	{
        accumulator = 0;
	}

    public float add(float operand1, float operand2)
    {
        return (operand1 + operand2);
    }

    public float substract(float operand1, float operand2)
    {
        return (operand1 - operand2);
    }

    public float multiply(float operand1, float operand2)
    {
        return (operand1 * operand2);
    }

    public float divide(float operand1, float operand2)
    {
        return (operand1 / operand2);
    }

    public void save(float number)
    {
        accumulator = number;
    }

    public float read()
    {
        return accumulator;
    }

    public void erase()
    {
        accumulator = 0;
    }
}
