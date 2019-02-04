using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            // output message to tell user what this program will do
            Console.WriteLine("This program will pick a random number between 1 and 10.");
            System.Console.WriteLine("You will have 4 chances to guess the number.");
            Random rnd = new Random();
            int secNumber = rnd.Next(1,11);
            System.Console.WriteLine("The secret number is: {0}", secNumber);
            int count = 0;

        do {

            // prompt user to enter a number
            System.Console.WriteLine("Pleae enter a number between 1 and 10.");
            // read user input into the userStringInput variable
            string userStringInput = Console.ReadLine();
            // declare an integer variable
            int userNumberInput;
            // see if user input can be converted to a number and set true or false value into isNumber variable
            bool isNumber = int.TryParse(userStringInput, out userNumberInput);
             

            // if user input is a number
            if (isNumber)
                {
                    // if user number = secret number then output message that user has won and end program
                    if (userNumberInput == secNumber)
                    {
                        System.Console.WriteLine("You won!");
                        break;
                    }
                    // if user number does not equal secret number then inform user and show number of tries remaining
                    count++;
                    System.Console.WriteLine("That is not correct. You can try {0} more time(s).", 4 - count);
                } 
            else
                {
                    // show message that user has not entered a number and try again
                    System.Console.WriteLine("You have not entered a number, please run the program again.");
                }
                // loop through to the maximum number of tries if user does not guess number
        } while (count < 4);

            // display message that user lost and invite them to play again
            if (count == 4)
            {
                 System.Console.WriteLine("You lost. Run the program to try again if you would like.");
            }
           
        }
    }
}
