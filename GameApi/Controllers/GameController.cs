using GameApi.Database;
using GameLib;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private GameData _gameDB = new GameData();
        private List<GameResults> _gameList = new List<GameResults>();

        public GameController()
        {
            _gameList = _gameDB.GetAllGamesFromDB();
        }

        [HttpGet("AllGameResults")]
        public List<GameResults> GetGames()
        {
            return _gameList;
        }

        [HttpPost("AddGameResults")]
        public int AddGameResults(GameResults gameResults) 
        {
            // the database returns the number of rows affected, should be 1
            int rows = _gameDB.SaveGameResults(gameResults);
            return rows;
        }

    }
}
