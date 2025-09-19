using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double? Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            double? result = 0;

            switch (argOperation)
            {
                case "+":
                case "add":
                case "plus":
                    result = (argFirstNumber + argSecondNumber);
                    break;
                case "-":
                case "subtract":
                case "minus":
                    result = (argFirstNumber - argSecondNumber);
                    break;
                case "*":
                case "multiply":
                case "times":
                    result = (argFirstNumber * argSecondNumber);
                    break;
                case "/":
                case "divide":
                case "divided by":
                    if (!(argSecondNumber == 0)){
                        result = (argFirstNumber / argSecondNumber);
                    }
                    else{
                        throw new DivideByZeroException("Cannot divide by zero");
                    }
                        break;
                case "%":
                case "modulate":
                case "modulo":
                    result = (argFirstNumber % argSecondNumber);
                    break;
                default:
                    result = null;
                    Console.WriteLine(Properties.Constants.InvalidOperatorPrompt);
                    break;
            }

            return result;
        }
    }
}
