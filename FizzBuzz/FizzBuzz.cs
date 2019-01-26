using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100 for this fizzbuzz program to use:");
            int userNumber = Int32.Parse(Console.ReadLine());
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
