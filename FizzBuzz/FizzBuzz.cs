using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            // get input from user
            Console.WriteLine("Enter a number between 1 and 100 for this fizzbuzz program to use:");
            // convert user input to integer type and store it in a variable
            int userNumber = Int32.Parse(Console.ReadLine());
            // loop through each number from 1 to user number and give appropriate output based on whether
            // the user number is divisible by 3 or 5 or both
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
