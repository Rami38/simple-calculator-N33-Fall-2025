using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
            else if (argOperation == "-" || argOperation.ToLower() == "subtraction")
            {
                result = argFirstNumber - argSecondNumber;
            }
            else if (argOperation == "×" || argOperation.ToLower() == "multiplication")
            {
                result = argFirstNumber * argSecondNumber;
            }
            else if (argOperation == "÷" || argOperation.ToLower() == "division")
            {
                result = argFirstNumber / argSecondNumber;
            }
            else if (argOperation == "%" || argOperation.ToLower() == "modulus")
            {
                result = argFirstNumber % argSecondNumber;
            }
            else
            {
                throw new InvalidOperationException("The operation is not available");
            }

            return result;
        }
    }
}
