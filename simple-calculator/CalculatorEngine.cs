using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            //You can use switch case also here for multiple operations or use if-else-if ladder
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
            if (argOperation == "-" || argOperation.ToLower() == "substraction")
            {
                result = argFirstNumber - argSecondNumber;
            }
            if (argOperation == "×" || argOperation.ToLower() == "multiplication")
            {
                result = argFirstNumber * argSecondNumber;
            }
            if (argOperation == "÷" || argOperation.ToLower() == "division")
            {
                result = argFirstNumber / argSecondNumber;
            }

            return result;
        }
    }
}
