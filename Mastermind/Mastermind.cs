using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        // possible letters in code
        public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        
        // size of code
        public static int codeSize = 4;
        
        // number of allowed attempts to crack the code
        public static int allowedAttempts = 10;
        
        // number of tried guesses
        public static int numTry = 0;
        
        // test solution
        public static char[] solution = new char[] {'a', 'b', 'c', 'd'};
        //GenerateRandomCode(letters);
        
        
        // game board
        public static string[][] board = new string[allowedAttempts][];
        
        
        public static void Main()
        {

            //string[] rndAnswer = CreateAnswer();
            //System.Console.WriteLine(rndAnswer[0]);
            // declare and instantiate a new instance of game and pass in correct answer
            Game game = new Game (new string[] {"a", "b", "c", "d"});
            CreateBoard();
            DrawBoard();
            bool won = false;
            // have user guess the 4 letters and either output a message that says won or after try limit - show they lost
            for (int turns = 10; turns > 0; turns--) {
                Console.WriteLine($"You have {turns} tries left");
                System.Console.WriteLine("Choose four letters: ");
                string letters = Console.ReadLine();
                // create new array of type Ball that holds 4 balls
                Ball[] balls = new Ball[4];
                // set each letter of user input into its corresponding position in ball array
                for (int i = 0; i < 4; i++) {
                    balls[i] = new Ball (letters[i].ToString());
                }
                // pass the new balls array with user input into a Row
                Row row = new Row(balls);
                game.AddRow (row);
                Console.WriteLine(game.Rows);
                bool done = CheckSolution(game.Rows.ToCharArray());
                if (done){
                    System.Console.WriteLine("you won!");
                    won = true;
                    break;
                }
            }
            if (won == false){
                Console.WriteLine("Out of turns");
            }
            
            // char[] guess = new char[4];

            
            // Console.WriteLine("Enter Guess:");
            // guess = Console.ReadLine().ToCharArray();

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        private static string[] CreateAnswer()
        {
            string[] answer = new string[4];
            for (int i=0; i < 4; i++)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 4);
                char letter = (char)('a' + num);
                answer[i] = letter.ToString();
            }
            return answer;
        }
        
        public static bool CheckSolution(char[] guess)
        {
            // Your code here
            if (guess == solution){

            }
            return true;
        }
        
        public static string GenerateHint(char[] guess)
        {
            // Your code here
            return " ";
        }
        
        public static void InsertCode(char[] guess)
        {
            // Your code here
        }
        
        public static void CreateBoard()
        {
            for (var i = 0; i < allowedAttempts; i++)
            {
                board[i] = new string[codeSize + 1];
                for (var j = 0; j < codeSize + 1; j++)
                {
                    board[i][j] = " ";
                }
            }
        }
        
        public static void DrawBoard()
        {
            for (var i = 0; i < board.Length; i++)
            {
                Console.WriteLine("|" + String.Join("|", board[i]));
            }
            
        }
        
        public static char[] GenerateRandomCode(char[] letters) {
            Random rnd = new Random();
            for(var i = 0; i < codeSize; i++)
            {
                solution[i] = letters[rnd.Next(0, letters.Length)];
            }
            return solution;
        }
    }    
}
