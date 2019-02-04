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
            // declare a random variable
            Random rnd = new Random();
            // set the random variable to a value between 1 and 10 and put it into secNumber variable
            int secNumber = rnd.Next(1,11);
            System.Console.WriteLine("The secret number is: {0}", secNumber);

            // initialize count of user tries to 0
            int count = 0;
            // pass count and secNumber into checkUserGuess function and store result in userOutcome
            bool userOutcome = checkUserGuess(count, secNumber);
            // if userOutcome is true, then display 'you won'
            if (userOutcome == true)
                {
                    System.Console.WriteLine("You won!");
                }
            // if userOutcome is false, then display 'you lost'
            else if (userOutcome == false)
                {
                    System.Console.WriteLine("You lost!");
                }
        }

        public static bool checkUserGuess(int count, int secNumber)
        {

            // loop through until user guesses secret number or reaches maximum of 4 tries
            do {

                    // prompt user to enter a number
                    System.Console.WriteLine("Pleae enter a number between 1 and 10.");
                    // read user input into the userStringInput variable
                    string userStringInput = Console.ReadLine();
                    // convert user input to an integer variable
                    int userNumberInput = int.Parse(userStringInput);
                    // if user number = secret number then break out of the loop and return true
                    if (userNumberInput == secNumber)
                        {
                            break;
                        }
                    else
                        {
                            // if user number does not equal secret number then increment count,
                            // inform user, and show number of tries remaining
                            count++;
                            System.Console.WriteLine("That is not correct. You can try {0} more time(s).", 4 - count);
                        } 

            } while (count < 4);

            // if user tries = 4 then return false to function call in main
            if (count == 4)
            {
                return false;
            }

            // return true to function call in main if user guesses secret number
            return true;
        }
    }
}
