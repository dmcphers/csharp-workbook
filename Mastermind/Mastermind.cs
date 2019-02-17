using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        public static void Main()
        {

            bool won = false;
            System.Console.WriteLine("How many tries would you like to guess correct answer?");
            int userTurns = Convert.ToInt32(Console.ReadLine());
            string[] answer = CreateAnswer();
            foreach(var i in answer)
            {
                System.Console.WriteLine(i);
            }
            Game game = new Game(answer, userTurns);
            for (int turns = userTurns; turns > 0; turns--)
            {
                Console.WriteLine($"You have {turns} tries left");
                Console.WriteLine("Choose four letters: ");
                string letters = Console.ReadLine();
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++)
                {
                    balls[i] = new Ball(letters[i].ToString());
                }
                Row row = new Row(balls);
                game.AddRow(row);
                Console.WriteLine(game.Rows);
                if (game.Score(row) == "4 - 0")
                {
                    won = true;
                    System.Console.WriteLine("You Won!");
                    break;
                }
            }
            if (won == false)
            {
                Console.WriteLine("Out Of Turns");
            }
        }

        private static string[] CreateAnswer()
        {
            string[] answer = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 4);
                char letter = (char)('a' + num);
                answer[i] = letter.ToString();
            }
            return answer;
        }
    }
}





