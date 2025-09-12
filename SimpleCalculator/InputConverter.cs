using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double value = 0;

            if (double.TryParse(argTextInput, out value))
            {
                Console.WriteLine($"Parsed number: {value}");
            }
            else
            {
                Console.WriteLine("Invalid number format.");
            }

            return value;
        }
    }
}
