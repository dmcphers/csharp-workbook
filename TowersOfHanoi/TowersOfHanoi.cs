using System;
using System.Collections.Generic;
using System.Collections;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Game game = new Game();
            game.PrintBoard();
        }
    }
    class Block
    {
         public int Weight{ get; private set;}
         public Block (int weight)
         {
             this.Weight = weight;
         }
    }
   
    class Game
    {
        Dictionary<string, Tower> towers = new Dictionary<string, Tower>();
        public Game ()
        {
            Tower towerA = new Tower();
            Tower towerB = new Tower();
            Tower towerC = new Tower();
            towers["A"] = towerA;
            towers["B"] = towerB;
            towers["C"] = towerC;
            towerA.blocks.Push(new Block(1));
            towerA.blocks.Push(new Block(2));
            towerA.blocks.Push(new Block(3));
            towerA.blocks.Push(new Block(4));

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
        public Stack blocks = new Stack();
    }
}
