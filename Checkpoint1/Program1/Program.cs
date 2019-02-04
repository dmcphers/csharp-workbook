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
