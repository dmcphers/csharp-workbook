using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            // inform user what the program will do
            Console.WriteLine("This program will compute the factorial of the number that you enter.");
            // prompt user to enter a number
            System.Console.WriteLine("Please enter a number.");
            // read the user input into a variable
            string userStringInput = Console.ReadLine();
            // declare an integer variable
            int userNumberInput;
            // see if user input can be converted to a number and set true or false value into isNumber variable
            bool isNumber = int.TryParse(userStringInput, out userNumberInput);

            // if user input is a number
            if (isNumber)
                {
                    // set initial value of factorial to 1
                    int factorial = 1;
                    // loop to find factorial of number entered by user
                    for (int factNum = userNumberInput; factNum > 0; factNum--)
                    {
                        factorial *= factNum;
                    }
                    // output calculated result
                    System.Console.WriteLine("{0}! = {1}", userNumberInput, factorial);
                } 
            else
                {
                    // show message that user has not entered a number and try again
                    System.Console.WriteLine("You have not entered a number, please run the program again.");
                }
        }
    }
}
