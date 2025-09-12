﻿using System;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.WriteLine("Welcome to Simple Calculator\nEnter  your first number then press Enter:");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter  your Second number then press Enter:");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter operation like + or add number then press Enter:");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }
            var sb = new StringBuilder();
            sb.Append("The value ");
            sb.Append(firstNumber.ToString("F2"));
            sb.Append(" ");
            sb.Append(CalculatorEngine.OperatorToText(opNormalized));
            sb.Append(" the value ");
            sb.Append(secondNumber.ToString("F2"));
            sb.Append(" is equal to ");
            sb.Append(result.ToString("F2"));
            sb.Append(".");

            Console.WriteLine();
            Console.WriteLine(sb.ToString());

        }
    }
}
