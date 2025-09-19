using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double? firstNumber = null;
                double? secondNumber = null;

                while (firstNumber == null)
                {
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }
                while (secondNumber == null)
                {
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }
                
                double? result = null;
                string operation = null;

                while (result == null){
                    operation = Console.ReadLine();
                    result = calculatorEngine.Calculate(operation, (double)firstNumber, (double)secondNumber);
                }

                switch (operation)
                {
                    case "+":
                    case "add":
                    case "plus":
                        operation = "plus";
                        break;
                    case "-":
                    case "subtract":
                    case "minus":
                        operation = "minus";
                        break;
                    case "*":
                    case "multiply":
                    case "times":
                        operation = "times";
                        break;
                    case "/":
                    case "divide":
                    case "divided by":
                        operation = "divided by";
                        break;
                    case "%":
                    case "modulate":
                    case "modulo":
                        operation = "modulo";
                        break;
                    default:
                        operation = null;
                        Console.WriteLine(Properties.Constants.InvalidOperatorPrompt);
                        break;
                }

                if (result != 0)
                {
                    Console.WriteLine("The value " + $"{firstNumber} {operation}" + " the value " + $"{secondNumber}" + " is equal to " + $"{result}");
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
