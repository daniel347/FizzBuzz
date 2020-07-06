using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; ++number)
            {
                string output = "";
                if (number % 3 == 0)
                {
                    output += "Fizz";
                }

                if (number % 5 == 0)
                {
                    output += "Buzz";
                }

                if (number % 7 == 0)
                {
                    output += "Bang";
                }

                if (number % 11 == 0)
                {
                    // If bong is present remove all other outputs
                    output = "Bong";
                }

                if (output.Equals(""))
                {
                    // Only print the number if nothing else is applicable
                    output += number.ToString();
                }
                Console.WriteLine(output);
            }
        }
    }
}