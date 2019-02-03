using System;
using System.Collections.Generic;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
           // inform user of purpose of program
            Console.WriteLine("This program will take all the numbers you enter and add them together.");
            
            // initialize a list to hold numbers user enters
            List<int> numbersList = new List<int>{};
            // declare and initialize a count variable that will be used to keep track if user has entered any numbers
            int count = 0;
            // declare and initialize sum variable to hold sum of all values user enters
            int sum = 0;
            // declare and initialize continueInput variable to determine whether program continues or stops
            bool continueInput = false;

        do {
                // give user instructions
                Console.WriteLine("Please enter either a number or the word 'ok' to exit.");
                // read input from user
                string userStringInput = Console.ReadLine();
                // declare an integer variable
                int userNumberInput;
                // see if user input can be converted to a number and set true or false value into isNumber variable
                bool isNumber = int.TryParse(userStringInput, out userNumberInput);
            
                // if user input is a number
                if (isNumber)
                    {
                        // add user number to the numbers list
                        numbersList.Add(userNumberInput);
                        // calculate sum of user numbers
                        sum = sum + userNumberInput;
                        // increment the count of user entries
                        count++;
                        // set continueInput value to true to allow for continuation of program
                        continueInput = true;
                    } 

                // if user enters 'ok'
                else if (userStringInput == "ok")
                {
                    // if this is user's first entry, give message that no numbers were entered and set contineInput
                    // to false to end program
                    if (count == 0)
                    {
                        Console.WriteLine("No numbers were entered.");
                        continueInput = false;
                    }
                    else
                    // display output of numbers user entered, the sum of the numbers entered, and
                    // set continueInput to false to end program
                    {
                        System.Console.WriteLine("The numbers you entered were: ");
                        foreach (int number in numbersList)
                        {
                            System.Console.WriteLine(number);
                        }
                        System.Console.WriteLine("The sum of the numbers you entered is: {0}", sum);
                        continueInput = false;
                    }
                    
                } 

            } while (continueInput);
        }
    }
}
