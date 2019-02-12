using System.Collections.Generic;
namespace Mastermind
{
        public class Game
    {
        private List<Row> rows = new List<Row> ();
        private string[] answer = new string[4];
        public Game(string[] answer)
        {
            this.answer = answer;
        }
    }
}