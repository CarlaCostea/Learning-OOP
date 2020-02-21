using System;

namespace ValidateJSON
{
    public class ValidateJSONNumber
    {
        public static void Main1()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ValidateInput(input));
        }

        public static bool ValidateInput(string input)
        {
            float converted;
            return float.TryParse(input, out converted);
        }
    }
}
