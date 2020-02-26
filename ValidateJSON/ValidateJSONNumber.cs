﻿using System;

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

            int currentPosition = 0;
            switch (input[0])
            {
                case '-':
                    return VerifyContentAfterMinus(input);
                case '0':
                    return VerifyContentAfterZero(input, ref currentPosition);
                default:
                    return VerifyDigitsNoZero(input);
            }
        }

        private static bool VerifyDigitsNoZero(string input)
            {
            if (input == null)
            {
                return false;
            }

            if (!char.IsDigit(input[0]) || input[0] == 0)
            {
                return false;
            }

            int currentPosition = 1;
            return VerifyContent(input, ref currentPosition);
        }

        private static bool VerifyContentAfterZero(string input, ref int currentPosition)
        {
            currentPosition++;
            if (input == null)
            {
                return false;
            }

            if (input.Length == 1)
            {
                return true;
            }

            if (input[currentPosition] != '.')
            {
                return false;
            }

            return VerifyContentAfterDot(input, ref currentPosition);
        }

        private static bool VerifyContentAfterDot(string input, ref int currentPosition)
        {
            bool isDigit = true;
            if (input == null)
            {
                return false;
            }

            if (input.Length <= currentPosition)
            {
                return false;
            }

            for (int i = currentPosition + 1; i < input.Length; i++)
            {
                if (input[i] == 'e' || input[i] == 'E')
                {
                    return VerifyExponential(input, ref i);
                }

                if (!char.IsDigit(input[i]))
                {
                    isDigit = false;
                }
            }

            return isDigit;
        }

        private static bool VerifyContentAfterMinus(string input)
        {
            if (input == null)
            {
                return false;
            }

            int currentPosition = 1;
            if (input[1] == '0')
            {
                return VerifyContentAfterZero(input, ref currentPosition);
            }

            return VerifyContent(input, ref currentPosition);
        }

        private static bool VerifyContent(string input, ref int currentPosition)
        {
            bool digit = true;
            if (input == null)
            {
                return false;
            }

            for (int i = currentPosition; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    return VerifyContentAfterDot(input, ref i);
                }

                if (input[i] == 'e' || input[i] == 'E')
                {
                    return VerifyExponential(input, ref i);
                }

                if (!char.IsDigit(input[i]))
                {
                    digit = false;
                }
            }

            return digit;
        }

        private static bool VerifyExponential(string input, ref int currentPosition)
        {
            if (input == null)
            {
                return false;
            }

            if (input.Length <= currentPosition)
            {
                return false;
            }

        }
    }
}
