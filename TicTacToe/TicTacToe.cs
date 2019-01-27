using System;

namespace TicTacToe
{
    class Program
    {
        // declare and initialize variables
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();
                

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        // get row and column input from user
        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
        }


        // place mark on the board in appropriate location, check for win, check for tie, and continue to next player move if neither
        public static void PlaceMark(int row, int column)
        {
        // your code goes here
        board[row][column] = playerTurn;
        bool winner = CheckForWin();
        bool tie = CheckForTie();
        System.Console.WriteLine(winner);
            if (winner)
            {
                DrawBoard();
                System.Console.WriteLine("Player " + playerTurn + " Won!");
            }
            else if (tie)
            {
                DrawBoard();
                System.Console.WriteLine("It was a tie!");
            }
            else
            {
                playerTurn = (playerTurn == "X") ? "O" : "X";
            }

        }


        // method to check for all types of wins
        public static bool CheckForWin()
        {
            // your code goes here
            if (HorizontalWin() || VerticalWin() || DiagonalWin())
            {
                return true;
            }
            return false;
        }


        // method to check for a tie
        public static bool CheckForTie()
        {
            // your code goes here
            if ((board[0][0] != " ") && (board[0][1] != " ") && (board[0][2] != " ") && (board[1][0] != " ") && (board[1][1] != " ")
             && (board[1][2] != " ") && (board[2][0] != " ") && (board[2][1] != " ") && (board[2][2] != " "))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        

        // method to check for horizontal win
        public static bool HorizontalWin()
        {
        // your code goes here
        if (((board[0][0] == playerTurn) && (board[0][1] == playerTurn) && (board[0][2] == playerTurn)) ||
           ((board[1][0] == playerTurn) && (board[1][1] == playerTurn) && (board[1][2] == playerTurn)) ||
           ((board[2][0] == playerTurn) && (board[2][1] == playerTurn) && (board[2][2] == playerTurn)))
           {
            return true;
           }

            return false;
        }


        // method to check for vertical win
        public static bool VerticalWin()
        {
        // your code goes here
        if (((board[0][0] == playerTurn) && (board[1][0] == playerTurn) && (board[2][0] == playerTurn)) ||
           ((board[0][1] == playerTurn) && (board[1][1] == playerTurn) && (board[2][1] == playerTurn)) ||
           ((board[0][2] == playerTurn) && (board[1][2] == playerTurn) && (board[2][2] == playerTurn)))
           {
            return true;
           }

            return false;
        }


        // method to check for diagonal win
        public static bool DiagonalWin()
        {
        // your code goes here
        if (((board[0][0] == playerTurn) && (board[1][1] == playerTurn) && (board[2][2] == playerTurn)) ||
           ((board[2][0] == playerTurn) && (board[1][1] == playerTurn) && (board[0][2] == playerTurn)))
           {
            return true;
           }

            return false;
        }


        // method to draw tic tac toe board
        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
