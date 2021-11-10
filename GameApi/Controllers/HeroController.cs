using CharactersLib;
using GameApi.Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private GameData _heroDB = new GameData();
        private List<Hero> _heroList = new List<Hero>();

        public HeroController()
        {
            _heroList = _heroDB.GetAllHeroesFromDB();
        }

        [HttpGet("AllHeroes")]
        public List<Hero> GetHeroes()
        {
            return _heroList;
        }
        
        [HttpGet("HerobyName")]
        public Hero GetHeroByName(string lookupName) 
        {
            foreach(Hero h in this._heroList ) 
            {
                if ( h.HeroName == lookupName )
                {
                    return h;
                } 
            }

            return null;
        }

    }
}
