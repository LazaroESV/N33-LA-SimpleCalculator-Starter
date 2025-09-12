using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch (argOperation)
            {
                case "+":
                    result = (argFirstNumber + argSecondNumber);
                    break;
                case "-":
                    result = (argFirstNumber - argSecondNumber);
                    break;
                case "*":
                    result = (argFirstNumber * argSecondNumber);
                    break;
                case "/":
                    result = (argFirstNumber / argSecondNumber);
                    break;
                case "%":
                    result = (argFirstNumber % argSecondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid Operator detected");
                    break;
            }

            return result;
        }
    }
}
