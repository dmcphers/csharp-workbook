using System.Collections.Generic;
using System;
namespace Mastermind
{
    public class Game
    {
        private List<Row> rows = new List<Row> ();
        private string[] answer = new string[4];
        public int guesses;
        public Game(string[] answer, int guesses)
        {
            this.answer = answer;
            this.guesses = guesses;
        }
    

        public string Score (Row row) {
            string[] answerClone = (string[])this.answer.Clone();
            // red is correct letter and correct position
            // white is correcct letters minus red
            // this.answer => ["a", "b", "c", "d"]
            // row.balls => [{ Letter: "c" }, { Letter: "b" }, {Letter: "d" }, {Letter: "a" }]
            int red = 0;
            for (int i = 0; i < 4; i++) {
                if (answerClone[i] == row.balls[i].Letter) {
                    red++;
                }
               

            }
            //  if (red == 4)
            //  {
            //      bool win = true;
            //      Console.WriteLine("You won!");
            //  }

            int white = 0;
            for (int i = 0; i < 4; i++) {
                int foundIndex = Array.IndexOf (answerClone, row.balls[i].Letter);
                if (foundIndex > -1) {
                    white++;
                    answerClone[foundIndex] = null;
                }
            }

            return $"{red} - {white - red}";
        }

        public void AddRow (Row row){
            this.rows.Add(row);
            //Console.WriteLine("row added");
        }

        public string Rows {
            get {
                foreach (var row in this.rows) {
                    Console.Write (row.Balls);
                    Console.WriteLine(Score (row));
                }
                return "";
            }
        }
    }
}