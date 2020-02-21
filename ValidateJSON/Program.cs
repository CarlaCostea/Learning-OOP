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
            bool validContent = true;
            if (Convert.ToInt16(input[1]) < maxControlChar)
            {
                return false;
            }

            int i = 1;
            while (i < input.Length - last)
            {
                if (input[i] == '/' || input[i] == '"' || Convert.ToInt16(input[i]) < maxControlChar)
                {
                    return false;
                }

                if (Convert.ToInt16(input[i]) == backslash)
                {
                    validContent = ValidateNext(input, ref i);
                    i++;
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
            const int backslash = 92;
            int nextChar = i + 1;
            const int uniCode = 4;
            const string controlChar = "abtnvfr";
            if (Convert.ToInt16(input[nextChar]) == backslash || input[nextChar] == '"' && nextChar != input.Length - 1)
            {
                i++;
                return true;
            }

            if (controlChar.IndexOf(input[nextChar]) != -1 || input[nextChar] == '/')
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
            const string hexaChars = "ABCDEF0123456789";
            const int uniCode = 4;
            for (int k = nextChar; k < nextChar + uniCode; k++)
            {
                if (hexaChars.IndexOf(input[k]) == -1)
                {
                    return false;
                }
            }

            i = nextChar + uniCode;
            return true;
        }
    }
}
