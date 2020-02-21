using System;

namespace ValidateJSON
{
    public class ValidateJSONNumber
    {
        public static void Main1()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ValidateInput(input));
            float converted;
            if (!float.TryParse(input, out converted))
            {
                return;
            }

            Console.WriteLine(true);
        }

        public static bool ValidateInput(string input)
        {
            return false;
        }
    }
}
