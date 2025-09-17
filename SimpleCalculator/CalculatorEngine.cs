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
                    result = (argFirstNumber + argSecondNumber);
                    break;
                case "-":
                    result = (argFirstNumber - argSecondNumber);
                    break;
                case "*":
                    result = (argFirstNumber * argSecondNumber);
                    break;
                case "/":
                    if (!(argSecondNumber == 0)){
                        result = (argFirstNumber / argSecondNumber);
                    }
                    else{
                        throw new DivideByZeroException("Cannot divide by zero");
                    }
                        break;
                case "%":
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
