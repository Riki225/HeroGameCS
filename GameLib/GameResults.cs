using System;

namespace GameLib
{
    public class GameResults
    {
        public int GameResultsID { get; set; }
        public DateTime Created { get; set; }
        public string WinnerName { get; set; }
        public GameResults() { } //empty constructor used for adding to database

        public GameResults(int GameResultsID, DateTime Created, string WinnerName)
        {
            this.GameResultsID = GameResultsID;
            this.Created = Created;
            this.WinnerName = WinnerName;
        }
    }
}
