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

            switch (input[0])
            {
                case '-':
                    return VerifyContentAfterMinus(input);
                case '0':
                    return VerifyContentAfterZero(input);
                default:
                    return VerifyDigitsNoZero(input);
            }
        }

        private static bool VerifyDigitsNoZero(string input)
        {
            throw new NotImplementedException();
        }

        private static bool VerifyContentAfterZero(string input)
        {
            throw new NotImplementedException();
        }

        private static bool VerifyContentAfterMinus(string input)
        {
            throw new NotImplementedException();
        }

        private static bool VerifyContent(string input)
        {
            if (input == null)
            {
                return false;
            }

            return false;
        }
    }
}
