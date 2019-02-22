using System;
using System.Collections.Generic;


namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // call function that gets number of blocks to play with from user
            int numberBlocks = GameBlocks();

            // instantiate a new game with the user choice number of blocks
            Game game = new Game(numberBlocks);

            // instantiate a new array of type block that is the size of the number the user has chosen
            Block[] blocks = new Block[game.Blocknum];

            // loop through all the blocks in the block array while assigning a value(weight) to each block
            for (int i = game.Blocknum -1; i >= 0; i--)
            {
                blocks[i] = new Block(i + 1);
                // push all blocks to tower A to start the game
                game.towers["A"].Blocks.Push(blocks[i]);
            }
            // print out game board to initialize new game
            game.PrintBoard();

            // set a boolean to false that will stay false until the user wins in which case it will
            // become true and perform win logic
            bool won = false;

            do
            {
                // main game play logic sequence to be run until user has won
                game.AskForMove();
                game.PrintBoard();
                won = game.CheckForWin();
            }
            while (!won);

            System.Console.WriteLine("You Win!");
        }
        
        // method to get number of blocks to play game with from user
        public static int GameBlocks()
        {
            System.Console.WriteLine("How many blocks would you like to play with?");
            int userInput =  Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
    }
    class Block
    {
        // block has an integer property called weight
         public int Weight{ get; private set;}
         public Block (int weight)
         {
             this.Weight = weight;
         }
    }

      class Tower
    {
        // a tower is a stack of blocks
        public Stack<Block> Blocks = new Stack<Block>();
        public Tower(Stack<Block> blocks)
        {
            this.Blocks = blocks;
        }
    }
   
    class Game
    {
        // a game will have a key value pair (dictionary) consisting of an identifying letter as
        // the key and an instance of a tower as the value
        public Dictionary<string, Tower> towers = new Dictionary<string, Tower>();
        public int Blocknum = 0;
        public Game (int blocknum)
        {
            // set the towers dictionary to 3 towers with different keys and a new stack of type block for each tower
            towers.Add("A", new Tower(new Stack<Block>()));
            towers.Add("B", new Tower(new Stack<Block>()));
            towers.Add("C", new Tower(new Stack<Block>()));

            // assign Blocknum property to number of blocks user has chosen
            Blocknum = blocknum;
        }
        public void PrintBoard()
        {
            // loop through once for each tower and print out tower key
            foreach (KeyValuePair<string, Tower> tower in towers)
            {
                System.Console.Write(tower.Key);
                // write out the weight of each block in the stack
                foreach ( Block block in tower.Value.Blocks)
                {
                     System.Console.Write(block.Weight);
                }
               System.Console.WriteLine();
            }
        }

        // method that will ask user which tower to move from and which tower to move to
        public void AskForMove()
        {
            try
            {
                System.Console.WriteLine("Which tower do you want to move a block from? (A, B, or C)?");
                string from = Console.ReadLine().ToUpper();
                System.Console.WriteLine("Which tower do you want to add a block to? (A, B, or C?)");
                string to = Console.ReadLine().ToUpper();

                // call MovePiece function to move the blocks
                MovePiece(towers[from], towers[to]);
                
            }
            catch
            {
                System.Console.WriteLine("Please enter a valid move. (A, B, or C)");
                AskForMove();
            }

        }
        public void MovePiece(Tower from, Tower to)
        {   // if move is determined not legal after passed to IsLegal function, output message that
            // informs user and loops back to the AskForMove function
            if (!IsLegal(from, to))
            {
                System.Console.WriteLine("That is not a legal move");
                System.Console.WriteLine();
                AskForMove();
            }
            else
            {
                // if legal move then pop off block in the from stack and push it onto the to stack
                Block movedBlock = from.Blocks.Pop();
                to.Blocks.Push(movedBlock);
            }
        }

        // function to check if move is legal or not based on block weight
        public bool IsLegal(Tower from, Tower to)
        {
            

            // user is trying to move from tower with no blocks
            if (from.Blocks.Count <= 0)
            {
                System.Console.WriteLine("There are no blocks in that tower to be moved.");
                return false;
            }

            // if there are no blocks on to tower, then move is legal
            if (to.Blocks.Count <= 0)
            return true;

            // check values to compare weights before moving to see if it is a legal move
            Block toBePopped = from.Blocks.Peek();
            Block toBePushed = to.Blocks.Peek();

            // // if nothing in the to tower, then move is legal
            // if (toBePushed == null)
            //     return true;
            // if weight of from block is less than to block, then move is legal
            if (toBePopped.Weight < toBePushed.Weight)
                return true;
            else
            // if move does not meet legal criteria, then it is illegal
                return false;
        }

        // function to check if user move results in a win
        public bool CheckForWin()
        {
            // if towers A and B both have no blocks, it means all blocks have been moved to tower C and user wins
            if (towers["A"].Blocks.Count == 0 && towers["B"].Blocks.Count == 0)
                return true;
            else
                return false;
        }
    }
}
