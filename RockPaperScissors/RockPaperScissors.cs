using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            bool play = true;
            string playch;
            string hand2 = "";


            //while (play == true)
            do
            {
                Console.WriteLine("Enter hand 1: (Rock, Paper, or Scissors)");
                string hand1 = Console.ReadLine().ToLower();
                //Console.WriteLine("Enter hand 2: (Rock, Paper, or Scissors)");
                Random rnd = new Random();
                string[] handchoices = {"rock", "paper", "scissors"};
                int choice_index = rnd.Next(0, 3);
                hand2 = handchoices[choice_index];
                Console.WriteLine("Computer chooses {0}", hand2);
                Console.WriteLine(CompareHands(hand1, hand2));

                // leave this command at the end so your program does not close automatically
                Console.WriteLine("Would you like to play again? [y/n]:");
                playch = Console.ReadLine();
                if (playch == "y" || playch == "Y" || playch == "Yes" || playch == "YES" || playch == "yes")
                    {
                        // If user chooses to play again it loops back to the start
                        play = true;
                    }
                    else
                    {
                        play = false;
                        break;
                    } 
            } while (play == true);
                


            //Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }
                
            if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                {
                    return "Hand one wins!";
                }
                //hand 2 must have been paper
                return "Hand two wins!";
            }

            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    return "Hand one wins!";
                }
                //hand 2 must have been scissors
                return "Hand two wins!";
            }

            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    return "Hand one wins!";
                }
                // hand 2 must have been rock
                return "Hand two wins!";
            }
                
            return hand1 + ' ' + hand2;
        }
    }
}
