﻿using System;

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
            const int secondLast = 2;
            bool validContent = true;
            for (int i = 1; i < input.Length - secondLast; i++)
            {
                Console.WriteLine(Convert.ToInt16(input[i]));
                if (Convert.ToInt16(input[i]) < maxControlChar)
                {
                    validContent = false;
                }
            }

            return validContent;
        }
    }
}
