using System;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Valid operations: +, -, ×, ÷, %");
            Console.WriteLine("Example: 5 + 3");

            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            double firstNumber = InputConverter.ConvertInputToNumeric(firstInput);

            Console.Write("Enter operation (+, -, ×, ÷, %): ");
            string operation = OperatorConverter.Convert(Console.ReadLine());

            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();
            double secondNumber = InputConverter.ConvertInputToNumeric(secondInput);

            var engine = new CalculatorEngine();
            double result = engine.Calculate(operation, firstNumber, secondNumber);

            // Human-readable formatted output
            string operationWord = OperatorConverter.ToWord(operation);
            var sb = new StringBuilder();
            sb.AppendFormat("The value {0} {1} the value {2} is equal to {3:F2}.",
                            firstNumber, operationWord, secondNumber, result);

            Console.WriteLine(sb.ToString());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
