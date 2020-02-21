using System;

namespace ValidateJSON
{
    public class ValidateString
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
            const int last = 1;
            bool validContent = true;
            int i = 1;
            while (i < input.Length - last)
            {
                if (input[i] == '"' || input[i] < maxControlChar)
                {
                    return false;
                }

                if (input[i] == '\\')
                {
                    validContent = ValidateNext(input, ref i);
                }

                i++;
            }

            return validContent;
        }

        private static bool ValidateNext(string input, ref int i)
        {
            int nextChar = i + 1;
            const int uniCode = 4;
            const string controlChar = "abtnvfr\\\"/";
            if (controlChar.Contains(input[nextChar]) && nextChar != input.Length - 1)
            {
                i++;
                return true;
            }

            if (input[nextChar] == 'u' && input.Length > nextChar + uniCode)
            {
                i++;
                return ValidUnicode(input, ref i);
            }

            i++;
            return false;
        }

        private static bool ValidUnicode(string input, ref int i)
        {
            int nextChar = i + 1;
            const string hexaChars = "abcdefABCDEF0123456789";
            const int uniCode = 4;
            for (int k = nextChar; k < nextChar + uniCode; k++)
            {
                if (!hexaChars.Contains(input[k]))
                {
                    return false;
                }
            }

            i = nextChar + uniCode;
            return true;
        }
    }
}
