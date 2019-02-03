using System;

namespace program5
{
    class Program
    {
        static void Main(string[] args)
        {
            // inform user what the program will do
            Console.WriteLine("This program will recieve a comma separated series of numbers that you enter.");
            System.Console.WriteLine("The program will then output the greatest number of the numbers you entered.");
            // prompt user to enter a number
            System.Console.WriteLine("Please enter a series of numbers separated by commas.");
            // read the user input into a variable
            string userStringInput = Console.ReadLine();
        }
    }
}
