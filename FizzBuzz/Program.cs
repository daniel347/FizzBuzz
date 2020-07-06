using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_value = 300;
            for (int number = 1; number <= max_value; ++number)
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

                if (number % 13 == 0)
                {
                    string[] beforeAndAfterB = output.Split('B', 2);
                    if (beforeAndAfterB.Length == 2)
                    {
                        // splits the string and inserts Fezz before the first B
                        output = beforeAndAfterB[0] + "Fezz" + "B" + beforeAndAfterB[1];
                    }
                    else
                    {
                        // If no B is found add to the end
                        output += "Fezz";
                    }
                    
                }

                if (number % 17 == 0)
                {
                    if (output.Length >= 8)
                    {
                        // if there are at least 2 words in the output,
                        // swap the order of the first two
                        output = output.Substring(4, 4) 
                                 + output.Substring(0, 4)
                                 + output.Substring(8);
                    }
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