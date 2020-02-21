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
            if (input == null)
            {
                return false;
            }

            float converted;
            if (input.Length > 1 && input[0] == '0' && input[1] != '.')
            {
                return false;
            }

            return float.TryParse(input, out converted);
        }
    }
}
