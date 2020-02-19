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

            return IsWrappedInDoubleQuotes(input) && ValidateContent(input);
        }

        public static bool IsWrappedInDoubleQuotes(string input)
        {
            if (input == null)
            {
                return false;
            }

            if (input.Length <= 1)
            {
                return false;
            }

            return input[0] == '"' && input[input.Length - 1] == '"';
        }

        private static bool ValidateContent(string input)
        {
            const int maxControlChar = 32;
            const int backslash = 92;
            const int last = 1;
            const int second = 2;
            bool validContent = true;
            if (Convert.ToInt16(input[1]) < maxControlChar)
            {
                return false;
            }

            int i = 1;
            while (i < input.Length - last)
            {
                if (input[i] == '/' || input[i] == '"')
                {
                    return false;
                }

                if (Convert.ToInt16(input[i]) == backslash)
                {
                    validContent = ValidateNext(input, ref i);
                }
                else
                {
                    i++;
                }
            }

            return validContent;
        }

        private static bool ValidateNext(string input, ref int i)
        {
            char[] controlChar = { 'a', 'b', 't', 'n', 'v', 'f', 'r' };
            for (int k = 0; k < controlChar.Length; k++)
            {
                if (input[i + 1] == controlChar[k])
                {
                    i++;
                    return true;
                }
            }

            i++;
            return false;
        }
    }
}
