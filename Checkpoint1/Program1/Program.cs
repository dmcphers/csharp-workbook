using System;

namespace Program1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // ask user question that will determine output of program
            Console.WriteLine("Would you like to see how many numbers between 1 and 100 are divisible by 3 ?");
            Console.WriteLine("If yes press y, if no press n");

            // read in user input and store it in userInput variable
             string userInput = Console.ReadLine().ToLower();

             // pass in userInput value to outputResult function
             int screenOutput = outputResult(userInput);


            // user condition to output message to screen based on user input
             if (screenOutput == 1)
             {
                 // call function to calculate answer and store answer in answer variable
                int answer = getAnswer();
                Console.WriteLine($"There are {answer} numbers between 1 and 100 that are divisible by 3 !");
             } 
             else if (screenOutput == 2)
             {
                Console.WriteLine("Ok, well if you ever want to in the future, come back and run this program again.");
             } 
             else 
             {
                 Console.WriteLine("You didn't enter a y or an n, please run the program again");
             }
        }
        // function recieves userInput and returns number that will determine whether to continue program or not
        static int outputResult(string userInput)
            {
                if (userInput == "y")
                {
                    return 1;
                } else if (userInput == "n")
                {
                    return 2;
                } else
                {
                    return 0;
                }
            }
            // funtion calculates the answer to how many numbers are divisible between 1 and 100 by 3
        static int getAnswer()
            {
                int count = 0;
                for (int i = 1; i < 100; i++)
                {
                    if (i%3 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
    }
}
