using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {

            // declare and initialize variables
            bool play = true;
            string playch;
            string hand2 = "";
            int hand1score = 0;
            int hand2score = 0;
            


            // do while loop to be performed at least once, then game continuation depends on user choice            
            do
            {
                Console.WriteLine("Enter hand 1: (Rock, Paper, or Scissors)");
                // store user choice converted to lower case in the hand1 variable
                string hand1 = Console.ReadLine().ToLower();
                // declare and initialize new random variable to hold computer choice
                Random rnd = new Random();
                // create a string array of possible choices
                string[] handchoices = {"rock", "paper", "scissors"};
                // pick a random number between 0 and 2 inclusive and assign to variable
                int choice_index = rnd.Next(0, 3);
                // assign the randomly chosen index of the choice array to the variable hand2
                hand2 = handchoices[choice_index];
                // print the computer choice to screen
                Console.WriteLine("Computer chooses {0}", hand2);
                // call the CompareHands function while passing in hand1 and hand2 as parameters and output result to screen
                Console.WriteLine(CompareHands(hand1, hand2, hand1score, hand2score));
                //Console.WriteLine(KeepScore(hand1score, hand2score));

                // ask user if wants to play again
                Console.WriteLine("Would you like to play again? [y/n]:");
                playch = Console.ReadLine();
                // if user answers yes, then set play to true and loop back to the start of loop
                if (playch == "y" || playch == "Y" || playch == "Yes" || playch == "YES" || playch == "yes")
                    {
                        play = true;
                    }
                    else
                    {
                        // user does not want to play again, so quit program
                        play = false;
                        break;
                    } 
            } while (play == true);
                
        }
        
        public static string CompareHands(string hand1, string hand2, int hand1score, int hand2score)
        {
            string scoreMessage;
            // if hands equal then its a tie
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }

            // if hand1 = rock and hand2 = scissors then hand1 wins - otherwise hand2 wins    
            if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                {
                   hand1score += 1;
                   scoreMessage = "Hand one wins! Cumulative game(s) score is: hand1 " + hand1score + " wins and computer " + hand2score + " wins!";
                    return scoreMessage;
                    
                }
                //hand 2 must have been paper
                hand2score += 1;
                return "Computer wins! Cumulative game(s) score is: hand1 " + hand1score + " wins and computer " + hand2score + " wins!";
            }

            // if hand1 = paper and hand2 = rock then hand1 wins - otherwise hand2 wins 
            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    hand1score += 1;
                    return "Hand one wins! Cumulative game(s) score is: hand1 " + hand1score + " wins and computer " + hand2score + " wins!";;
                }
                //hand 2 must have been scissors
                hand2score += 1;
                return "Computer wins!  Cumulative game(s) score is: hand1 " + hand1score + " wins and computer " + hand2score + " wins!";;
            }

            // if hand1 = scissors and hand2 = paper then hand1 wins - otherwise hand2 wins
            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    hand1score += 1;
                    return "Hand one wins! Cumulative game(s) score is: hand1 " + hand1score + " wins and computer " + hand2score + " wins!";
                }
                // hand 2 must have been rock
                hand2score += 1;
                return "Computer wins! Cumulative game(s) score is: hand1 " + hand1score + " wins and computer " + hand2score + " wins!";
            }
                
            return hand1 + ' ' + hand2;
        }
        public static int KeepScore(int hand1, int hand2)
    
        {
            
            return hand1 + ' ' + hand2;
        }
    }
}
