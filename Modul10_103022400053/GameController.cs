using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400053
{
    [Route("api/Game")]
    [ApiController]
    public class GameController : Controller
    {
        private static readonly List<Game> games = new List<Game>
        {
            new Game
            {
                id = 1,
                Nama="Valorant",
                Developer="Riot Games",
                TahunRilis=2020,
                Genre="FPS",
                Rating=8.5,
                Platform=["PC"],
                Mode=["Multiplayer"],
                IsOnline=true,
                Harga=0
            },
            new Game
            {
                id = 2,
                Nama="GTA V",
                Developer="Rockstar Games",
                TahunRilis=2013,
                Genre="Open World",
                Rating=9.5,
                Platform=["PC", "PS4", "PS5", "Xbox"],
                Mode=["Singleplayer","Multiplayer"],
                IsOnline=true,
                Harga=300000
            },
            new Game
            {
                id = 3,
                Nama="The Witcher 3",
                Developer="CD Projekt Red",
                TahunRilis=2015,
                Genre="RPG",
                Rating=9.7,
                Platform=["PC", "PS4", "PS5", "Xbox", "Switch"],
                Mode=["Singleplayer"],
                IsOnline=false,
                Harga=250000
            }
        };
        [HttpGet]
        public IEnumerable<Game> Get() { return games; }
        [HttpPost]
        public void Post([FromBody] Game newgame) 
        {
            games.Add(newgame);
        }
        [HttpGet("{id}")]
        public Game Get(int id)
        {
            return games[id];
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game updateGame)
        {
            games[id] = updateGame;
        }
        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            games.Remove(games[id]);
        }
    }
}
