using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        public static void Main()
        {
            // initialize won to false so won will be false if user runs out of turns or set to true if user wins
            bool won = false;
            System.Console.WriteLine("How many tries would you like to guess correct answer?");
            // convert user input to an int
            int userTurns = Convert.ToInt32(Console.ReadLine());
            // call function CreateAnswer and set return value to a string array called answer
            string[] answer = CreateAnswer();

            // foreach(var i in answer)
            // {
            //     System.Console.WriteLine(i);
            // }

            // instantiate a new game and pass in computer generated answer and number of turns user has selected
            Game game = new Game(answer, userTurns);
            // loop through game logic for user selected number of turns or until user wins and loop is broken
            for (int turns = userTurns; turns > 0; turns--)
            {
                Console.WriteLine($"You have {turns} tries left");
                Console.WriteLine("Choose four letters: ");
                string letters = Console.ReadLine();
                // instantiate a new array of type ball that has a length of 4
                Ball[] balls = new Ball[4];
                // populate the array with balls(letters) chosen by the user
                for (int i = 0; i < 4; i++)
                {
                    balls[i] = new Ball(letters[i].ToString());
                }
                // create a new row by passing in the balls array
                Row row = new Row(balls);
                // add row to the rows list in game
                game.AddRow(row);
                // output the row of balls(letters) chosen and the score for that row
                Console.WriteLine(game.Rows);
                if (game.Score(row) == "4 - 0")
                {
                    won = true;
                    System.Console.WriteLine("You Won!");
                    break;
                }
            }
            // ran out of turns - lost the game
            if (won == false)
            {
                Console.WriteLine("Out Of Turns");
            }
        }

        private static string[] CreateAnswer()
        {
            // instantiate a new string array of size 4 and set it to variable answer
            string[] answer = new string[4];
            // loop 4 times to set random values into answer array
            for (int i = 0; i < 4; i++)
            {
                // instantiate a random object
                Random rnd = new Random();
                // randomly choose a number between 0 and 3
                int num = rnd.Next(0, 4);
                // get ascii integer value of 'a' and add random number to it to create a random character a,b,c, or d
                char letter = (char)('a' + num);
                // convert character to string for inserting in answer array
                answer[i] = letter.ToString();
            }
            return answer;
        }
    }
}





