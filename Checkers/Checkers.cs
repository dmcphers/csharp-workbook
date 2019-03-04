using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            // needed to allow for output of UTF8 symbols
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // instantiate a new game
            Game game = new Game();
            // call the startGame method of game
            game.startGame();
        }
    }

    public class Checker
    {
        public int[] Position  { get; set; }
        public string Color { get; set; }
         
        // Gets the Open or Closed circle value based on the checker's color
        public String Symbol
        {
            get
            {
                if (Color == "black")
                {
                    int openCircleID = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                    String openCircle = char.ConvertFromUtf32(openCircleID);

                    return openCircle;
                }
                else if (Color == "white")
                {
                    int closedCircleID = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                    String closedCircle = char.ConvertFromUtf32(closedCircleID);

                    return closedCircle;
                }
                else
                {
                    return "";
                }
            }
        }

          // checker constructor        
        public Checker(string color)
        {
            this.Color = color;
        }
    
         // ToString override
        public override String ToString()
        {
            return Symbol;
        }
    }

    public class Board
    {
        // board will have a jagged array of type Checker called Grid that makes up the board
        public Checker[][] Grid  { get; set; }
        // there will be a list of type Checker called Checkers that will hold Checkers currently on board
        public List<Checker> Checkers { get; set; }

        // board constructor does not need any parameters        
        public Board()
        {
            // Your code here
            return;
        }
        
        // method that creates the grid for the board and creates all the checker instances 
        // in their approprate positions at the beginning of the game
        public void CreateBoard()
        {
            // declare new variable checker of type Checker
            Checker checker;
            // instantiate new list of type Checker called Checkers
            Checkers = new List<Checker>();
            // instantiate new jagged array of type Checker called Grid for creating the board
            Grid = new Checker[8][]
            {
                new Checker[8],
                new Checker[8],
                new Checker[8],
                new Checker[8],
                new Checker[8],
                new Checker[8],
                new Checker[8],
                new Checker[8]
            };

            // Generates the white checkers and places them in the Grid
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if ((row == 0 || row == 2) && (column % 2 != 0))
                    {
                        checker = new Checker("white");
                        Checkers.Add(checker);
                        Grid[row][column] = checker;
                    }
                    else if ((row == 1) && (column % 2 == 0))
                    {
                        checker = new Checker("white");
                        Checkers.Add(checker);
                        Grid[row][column] = checker;
                    }
                }
            }

            // Generates the black checkers and places them in the Grid
            for (int row = 5; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if ((row == 5 || row == 7) && (column % 2 == 0))
                    {
                        checker = new Checker("black");
                        Checkers.Add(checker);
                        Grid[row][column] = checker;
                    }
                    else if ((row == 6) && (column % 2 != 0))
                    {
                        checker = new Checker("black");
                        Checkers.Add(checker);
                        Grid[row][column] = checker;
                    }
                }
            }
        }
        
        // method to place the checker based on user input
        // and logic that checks the validity of that user input
        public bool PlaceChecker(int originRow, int originColumn, int destinationRow, int destinationColumn, Checker checker)
        {
            // check if position is empty
           if (Grid[destinationRow][destinationColumn] == null)
           {
                if (checker.Color == "white")
                {
                    // make sure the user did not move more than one row or column and make sure user did not move backwards
                    if ((destinationRow == originRow + 1) && (destinationColumn == originColumn - 1 || destinationColumn == originColumn + 1))
                    {
                        Console.Clear();
                        Grid[destinationRow][destinationColumn] = checker;
                        return true;
                    }
                    else if ((destinationRow == originRow + 2) && (destinationColumn == originColumn - 2 || destinationColumn == originColumn + 2))
                    {
                        // if moving right, only allow the user to jump a checker if jumped checker is not white
                        if ((destinationColumn > originColumn) && (Grid[destinationRow - 1][destinationColumn - 1].Color != "white"))
                        {
                            Grid[destinationRow][destinationColumn] = checker;
                            return true;
                        }
                        // if moving left, only allow the user to jump a checker if jumped checker is not white
                        else if ((destinationColumn < originColumn) && (Grid[destinationRow - 1][destinationColumn + 1].Color != "white"))
                        {
                            Grid[destinationRow][destinationColumn] = checker;
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("You cannot jump your own checker. Please try again.");
                            return false;
                            //throw new Exception("trying to jump own checker");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You cannot move backwards and you cannot move more than 1 row or column at a time. Please try again.");
                        return false;
                    }
                }
                 if (checker.Color == "black")
                {
                   // make sure the user did not move more than one row or column and make sure user did not move backwards
                    if ((destinationRow == originRow - 1) && (destinationColumn == originColumn - 1 || destinationColumn == originColumn + 1))
                    {
                        Grid[destinationRow][destinationColumn] = checker;
                        return true;
                    }
                    // Checks to make sure the user isn't trying to jump a black checker
                    else if ((destinationRow == originRow - 2) && (destinationColumn == originColumn - 2 || destinationColumn == originColumn + 2))
                    {
                        // if moving right, only allow the user to jump a checker if jumped checker is not black
                        if ((destinationColumn > originColumn) && (Grid[destinationRow + 1][destinationColumn - 1].Color != "black"))
                        {
                            Grid[destinationRow][destinationColumn] = checker;
                            return true;
                        }
                        // if moving left, only allow the user to jump a checker if jumped checker is not black
                        else if ((destinationColumn < originColumn) && (Grid[destinationRow + 1][destinationColumn + 1].Color != "black"))
                        {
                            Grid[destinationRow][destinationColumn] = checker;
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("You cannot jump your own checker. Please try again.");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You cannot move backwards and you cannot move more than 1 row or column at a time. Please try again.");
                        return false;
                    }
                }
           }
           else
           {
               Console.Clear();
               Console.WriteLine("Not a valid move. There is a checker there. Plese try again.");
               return false;
           }
           return true;
        }
        
        public string DrawBoard()
        {
              // Header
            String formattedBoard = "  0 1 2 3 4 5 6 7" + "\n";

            // Loops through drawing the gameboard from the Grid array of Checkers
            for (int row = 0; row < 8; row++)
            {
                formattedBoard += Convert.ToString(row) + " ";

                for (int column = 0; column < 8; column++)
                {
                    // Error catching. Runs as long as the location has a Checker object
                    if (Grid[row][column] != null)
                    {
                        // Places a Checker in the space on the grid
                        if (Grid[row][column].Symbol != "")
                        {
                            formattedBoard += Grid[row][column] + " ";
                        }
                    }
                    else
                    {
                        // If the grid space is empty, inserts an empty space in the grid.
                        formattedBoard += "  ";
                    }

                    // Adds a new line if the loop is iterating on the the 7th column
                    if (column == 7)
                    {
                        formattedBoard += "\n";
                    }
                }
            }
            
            return formattedBoard;
        }
        
        public Checker SelectChecker(int row, int column, string color)
        {
            if (Grid[row][column].Color != color)
            {
                String invalidTurn = Grid[row][column].Color;
                System.Console.WriteLine("It is not {0}'s turn!", invalidTurn);
            }
            return Grid[row][column];
        }
        
        public bool RemoveChecker(int originRow, int originColumn, int destinationRow, int destinationColumn, Checker checker)
        {
            if (checker.Color == "white")
            {
                // if the player jumped a checker
                if (destinationRow == originRow + 2)

                // if (Grid[destinationRow - 1][destinationColumn - 1].Color == "white")
                // {
                //     System.Console.WriteLine("you cannot jump your own checker.");
                //     return false;
                // }
                // else 
                {
                    // player moves right
                    if (destinationColumn == originColumn + 2)
                    {
                        // remove the jumped checker from the Checkers list
                        Checkers.Remove(Grid[destinationRow -1][destinationColumn - 1]);
                        // remove the checker the player moved from its origin
                        Grid[originRow][originColumn] = null;
                        // remove the jumped checker
                        Grid[destinationRow - 1][destinationColumn - 1] = null;
                        // return true since a checker was jumped
                        return true;
                    }
                    // player moves left
                    else if (destinationColumn == originColumn - 2)
                    {
                        // remove the jumped checker from the Checkers list
                        Checkers.Remove(Grid[destinationRow -1][destinationColumn + 1]);
                        // remove the checker the player moved from its origin
                        Grid[originRow][originColumn] = null;
                        // remove the jumped checker
                        Grid[destinationRow - 1][destinationColumn + 1] = null;
                        // return true since a checker was jumped
                        return true;
                    }
                }
            }
            if (checker.Color == "black")
            {
                // if the player jumped a checker
                if (destinationRow == originRow - 2)
                {
                    // player moves right
                    if (destinationColumn == originColumn + 2)
                    {
                        // remove the jumped checker from the Checkers list
                        Checkers.Remove(Grid[destinationRow + 1][destinationColumn - 1]);
                        // remove the checker the player moved from its origin
                        Grid[originRow][originColumn] = null;
                        // remove the jumped checker
                        Grid[destinationRow + 1][destinationColumn - 1] = null;
                        // return true since a checker was jumped
                        return true;
                    }
                    // player moves left
                    else if (destinationColumn == originColumn - 2)
                    {
                        // remove the jumped checker from the Checkers list
                        Checkers.Remove(Grid[destinationRow + 1][destinationColumn + 1]);
                        // remove the checker the player moved from its origin
                        Grid[originRow][originColumn] = null;
                        // remove the jumped checker
                        Grid[destinationRow + 1][destinationColumn + 1] = null;
                        // return true since a checker was jumped
                        return true;
                    }
                }
            }

            // Removes the Checker the player moved from it's origin
            Grid[originRow][originColumn] = null;
            return false;
        }
        
        // method will check if all checkers in the list are white or none of the checkers in the list are white
        // in which case it would return true because that would mean someone won
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        // game constructor does not need any parameters
        public Game()
        {
            // Your code here
        }

        public void startGame()
        {
            // instantiate a new instance of Board called boardgame
            Board boardgame = new Board();
            // initialize starting game color
            String color = "white";
             // create a boolean to see if checker placement was valid
            bool placedChecker;
            // create a boolean to see if checker was removed
            bool removedChecker;
            // call CreateBoard method on instance of board
            boardgame.CreateBoard();

            // loop that will run as long as there is no winner
            do
            {
                //Console.Clear();
                 // call method that will output to the screen the board with its checkers in appropriate places
                Console.WriteLine(boardgame.DrawBoard());

                //try
                //{
                    // user selects a checker to move
                    Console.WriteLine($"{color}, please enter a row to move from:");
                    int originRow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{color}, please enter a column to move from:");
                    int originColumn = Convert.ToInt32(Console.ReadLine());
                    Checker checker = boardgame.SelectChecker(originRow, originColumn, color);

                    // Console.Clear();
                    // Console.WriteLine(boardgame.DrawBoard());

                    // place the checker in position on board based on user input
                    Console.WriteLine("Please enter the row to move to: ");
                    int destinationRow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the column to move to: ");
                    int destinationColumn = Convert.ToInt32(Console.ReadLine());
                    placedChecker = boardgame.PlaceChecker(originRow, originColumn, destinationRow, destinationColumn, checker);
                    if (placedChecker == false)
                    {
                        do
                        {
                        Console.WriteLine(boardgame.DrawBoard());
                            // user selects a checker to move
                        Console.WriteLine($"{color}, please enter a row to move from:");
                        originRow = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{color}, please enter a column to move from:");
                        originColumn = Convert.ToInt32(Console.ReadLine());
                        checker = boardgame.SelectChecker(originRow, originColumn, color);

                        // Console.Clear();
                        // Console.WriteLine(boardgame.DrawBoard());

                        // place the checker in position on board based on user input
                        Console.WriteLine("Please enter the row to move to: ");
                        destinationRow = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the column to move to: ");
                        destinationColumn = Convert.ToInt32(Console.ReadLine());
                        placedChecker = boardgame.PlaceChecker(originRow, originColumn, destinationRow, destinationColumn, checker);
                        }while(placedChecker == false);
                        //System.Console.WriteLine("test");
                    }
                    
                   

                    
                    // Console.Clear();
                    //Console.WriteLine(boardgame.DrawBoard());

                     // Removes jumped checker and the jumping checker from it's origin if checker removed
                     // or just removes the checker from its origin if a checker is not jumped
                    removedChecker = boardgame.RemoveChecker(originRow, originColumn, destinationRow, destinationColumn, checker);

                    //Console.Clear();
                    Console.WriteLine(boardgame.DrawBoard());
                    
                    // Checks if a Checker was removed in the turn. If there was and that player did not win,
                    // program asks the player if they can make another move by jumping another opponent's Checker with
                    // the same Checker they just played with. If player says no, it becomes the other players turn.
                    // If no checker was removed, it becomes the other person's turn
                    if (removedChecker && !boardgame.CheckForWin())
                    {
                        String userInput = "";
                        do
                        {
                            Console.WriteLine("Do you have another move you can make with the same checker? [Y/N]");
                            userInput = Console.ReadLine().ToLower();
                        }while (userInput != "y" && userInput != "n");

                        if (userInput == "n")
                        {
                            if (color == "white")
                            {
                                color = "black";
                            }
                            else
                            {
                                color = "white";
                            }
                        }
                    }  // Changes the player turn
                    else if (!removedChecker)
                    {
                        if (color == "white")
                        {
                            color = "black";
                        }
                        else
                        {
                            color = "white";
                        }
                    }
                //}
                // catch
                // {
                //     Console.WriteLine("Invalid selection");
                // }
            }while(!boardgame.CheckForWin());

            Console.WriteLine("{0} wins!!!", color);
        }
    }
}
