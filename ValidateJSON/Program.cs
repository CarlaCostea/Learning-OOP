using System;

namespace ValidateJSON
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool valid = ValidateJsonString(input);
            Console.WriteLine(valid);
        }

        public static bool ValidateJsonString(string input)
        {
            if (input == null)
            {
                return false;
            }

            return IsWrappedInDoubleQuotes(input);
        }

        private static bool IsWrappedInDoubleQuotes(string input)
        {
            if (input.Length <= 1)
            {
                return false;
            }

            return input[0] == '"' && input[input.Length - 1] == '"';
        }
    }
}
