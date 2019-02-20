using System;
using System.Collections.Generic;
using System.Collections;

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
            game.PrintBoard();
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
            foreach (KeyValuePair<string, Tower> item in towers)
            {
                string blocks = "";
                //System.Console.WriteLine(item.Key + ":" + item.Value.blocks);
                foreach ( Block block in item.Value.blocks)
                {
                    blocks += block.Weight.ToString();
                }
                System.Console.WriteLine(item.Key + " " + blocks);
            }
        }
        public void MovePiece()
        {

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
}
