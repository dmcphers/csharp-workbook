using System;
namespace Mastermind
{
    class Row
    {
        public Ball[] balls = new Ball[4];
        public Row (Ball[] balls)
        {
            this.balls = balls;
        } 

        public string Balls{
            get {
                foreach (var ball in this.balls)
                 {
                     Console.WriteLine(ball.Letter);
                }
                return "";
            }
        }
    }
}