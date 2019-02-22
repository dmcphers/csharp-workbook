using System;

namespace Program1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // call getAnswer function which calculates all numbers between 1 and 100 that are divisible by 3
            // and place the return value of that function in the variable answer
            int answer = getAnswer();
            // output message stating how many numbers between 1 and 100 are divisible by 3
            System.Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3.", answer);
        }
            // funtion calculates the answer to how many numbers are divisible between 1 and 100 by 3
        static int getAnswer()
            {   
                // initialize count to 0
                int count = 0;
                // loop from 1 to 100. If current number in loop is divisible by 3 with no remainder,
                // then increment count
                for (int i = 1; i < 100; i++)
                {
                    if (i%3 == 0)
                    {
                        count++;
                    }
                }
                // return count of numbers between 1 and 100 divisible by 3 to function call in main
                return count;
            }
    }
}
