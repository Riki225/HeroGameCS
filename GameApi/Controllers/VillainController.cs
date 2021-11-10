using CharactersLib;
using GameApi.Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VillainController : ControllerBase
    {
        private GameData _villainDB = new GameData();
        private List<Villain> _villainList = new List<Villain>();

        public VillainController()
        {
            this._villainList = _villainDB.GetAllVillainsFromDB();
        }

        [HttpGet("AllVillains")]
        public List <Villain> GetVillains()
        {
            return this._villainList;
        }

          [HttpGet("VillainbyName")]
        public Villain GetVillainByName(string lookupName) 
        {
            foreach(Villain v in this._villainList ) 
            {
                if ( v.VillainName == lookupName )
                {
                    return v;
                } 
            }

            return null;
        }

    }
}
