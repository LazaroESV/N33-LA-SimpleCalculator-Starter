using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double? ConvertInputToNumeric(string argTextInput)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-CA");

            double value = 0;
            double? returnedValue = null;
            
            if (double.TryParse(argTextInput, out value))
            {
                Console.WriteLine(Properties.Constants.ParsedValuePrompt + $"{value}");
                returnedValue = value;
            }
            else
            {
                Console.WriteLine(Properties.Constants.InvalidPrompt);
                returnedValue = null;
            }

            return returnedValue;
        }
    }
}
