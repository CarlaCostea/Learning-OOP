using System;

namespace ValidateJSON
{
    public class ValidateJSONFile
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please enter a valid file");
                return;
            }

            var input = System.IO.File.ReadAllText(args[0]);
            var value = new Value();
            bool valid = value.Match(input).Success();
            Console.WriteLine(valid);
        }
    }
}
