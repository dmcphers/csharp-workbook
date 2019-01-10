using System;

namespace textbasedgame
{
    class Program
    {
        static void Main(string[] args)
        {

            string ch1;
            System.Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor. Do you take it? [y/n]");
            //ch1 = str(input("Do you take it? [y/n]: "))
            ch1 = Console.ReadLine();

            if (ch1 == "y")
            {
                System.Console.WriteLine("You have chosen the stick!");
            }
        }

    }
}
