using System.Collections.Generic;
using System;
namespace Mastermind
{
    public class Game
    {
        // instantiate a new list of row type
        private List<Row> rows = new List<Row> ();
        // instantiate a new string of size 4 that will hold answer
        private string[] Answer = new string[4];
        public int Guesses;
        // game constructor that accepts the random answer and number of guesses
        public Game(string[] answer, int guesses)
        {
            this.Answer = answer;
            this.Guesses = guesses;
        }
    
        // pass in user selected balls(letters) and compares the balls(letters) and their positions to the
        // letter in the answer
        public string Score (Row row) {
            string[] answerClone = (string[])this.Answer.Clone();
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

            int white = 0;
            for (int i = 0; i < 4; i++) {
                int foundIndex = Array.IndexOf (answerClone, row.balls[i].Letter);
                if (foundIndex > -1) {
                    white++;
                    answerClone[foundIndex] = null;
                }
            }
            // return score to function call
            return $"{red} - {white - red}";
        }

        // pass in user selected balls(letters) to a new row
        public void AddRow (Row row){
            this.rows.Add(row);
        }

        // function that prints out each letter user chose and the resulting score for that turn
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