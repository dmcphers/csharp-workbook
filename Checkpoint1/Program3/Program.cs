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
            // convert user string variable to a number variable
            int userNumberInput = int.Parse(userStringInput);
            // pass in userNumberInput to getFactorial function and store result in factorial variable
            int factorial = getFactorial(userNumberInput);
            // output calculated result
            System.Console.WriteLine("{0}! = {1}", userNumberInput, factorial);
        }

        public static int getFactorial(int userNumber)
            {
               // set initial value of factorial to 1
                    int factorial = 1;
                    // loop to find factorial of number entered by user
                    for (int factNum = userNumber; factNum > 0; factNum--)
                    {
                        factorial *= factNum;
                    }
                // return factorial of user entered number to function call in main
                return factorial;
            }
    }
}
