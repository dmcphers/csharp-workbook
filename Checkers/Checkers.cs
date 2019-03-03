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
        
        
        // public void GenerateCheckers()
        // {
        //     // Your code here
        //     return;
        // }
        
        // public void PlaceCheckers()
        // {
        //     for (var i = 0; i < Checkers.Count; i++)
        //     {
        //         int[] position = Checkers[i].Position;
        //         Grid[position[0]][position[1]] = Checkers[i];
        //     }
        // }
        
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
        
        // public Checker SelectChecker(int row, int column)
        // {
        //     return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        // }
        
        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }
        
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
            // call CreateBoard method on instance of board
            boardgame.CreateBoard();
            Console.WriteLine(boardgame.DrawBoard());
        }
    }
}
