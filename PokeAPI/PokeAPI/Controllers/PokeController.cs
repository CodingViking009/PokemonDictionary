using Microsoft.AspNetCore.Mvc;

namespace PokeAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PokeController : ControllerBase
    {
        private static readonly List<Pokemon> PokemonList = new List<Pokemon>()
        {
           new Pokemon { Id = 001, Name = "Bisasam", Typ = "Grass/Poison" },
           new Pokemon { Id = 002, Name = "Bisaknosp", Typ = "Grass/Poison" },
           new Pokemon { Id = 003, Name = "Bisaflor", Typ = "Grass/Poison" },
           new Pokemon { Id = 004, Name = "Glumanda", Typ = "Fire" },
           new Pokemon { Id = 005, Name = "Glutexo", Typ = "Fire" },
           new Pokemon { Id = 006, Name = "Glurak", Typ = "Fire/Flying" },
           new Pokemon { Id = 007, Name = "Schiggy", Typ = "Water" },
           new Pokemon { Id = 008, Name = "Schillok", Typ = "Water" },
           new Pokemon { Id = 009, Name = "Turtok", Typ = "Water" },
           new Pokemon { Id = 010, Name = "Raupy", Typ = "Bug" },
           new Pokemon { Id = 011, Name = "Safcon", Typ = "Bug" },
           new Pokemon { Id = 012, Name = "Smettbo", Typ = "Bug/Flying" },
           new Pokemon { Id = 013, Name = "Hornliu", Typ = "Bug/Poison" },
           new Pokemon { Id = 014, Name = "Kokuna", Typ = "Bug/Poison" },
           new Pokemon { Id = 015, Name = "Bibor", Typ = "Bug/Poison" },
           new Pokemon { Id = 016, Name = "Taubsi", Typ = "Normal/Flying" },
           new Pokemon { Id = 017, Name = "Tauboga", Typ = "Normal/Flying" },
           new Pokemon { Id = 018, Name = "Tauboss", Typ = "Normal/Flying" },
           new Pokemon { Id = 019, Name = "Rattfratz", Typ = "Normal" },
           new Pokemon { Id = 020, Name = "Rattikarl", Typ = "Normal" },
           new Pokemon { Id = 021, Name = "Habitak", Typ = "Normal/Flying" },
           new Pokemon { Id = 022, Name = "Ibitak", Typ = "Normal/Flying" },
           new Pokemon { Id = 023, Name = "Rettan", Typ = "Poison" },
           new Pokemon { Id = 024, Name = "Arbok", Typ = "Poison" },
           new Pokemon { Id = 025, Name = "Pikachu", Typ = "Electric" },
           new Pokemon { Id = 026, Name = "Raichu", Typ = "Electric" },
           new Pokemon { Id = 027, Name = "Sandan", Typ = "Ground" },
           new Pokemon { Id = 028, Name = "Sandamer", Typ = "Ground" },
           new Pokemon { Id = 029, Name = "Nidoran♀", Typ = "Poison" },
           new Pokemon { Id = 030, Name = "Nidorina", Typ = "Poison" },
           new Pokemon { Id = 031, Name = "Nidoqueen", Typ = "Poison/Ground" },
           new Pokemon { Id = 032, Name = "Nidoran♂", Typ = "Poison" },
           new Pokemon { Id = 033, Name = "Nidorino", Typ = "Poison" },
           new Pokemon { Id = 034, Name = "Nidoking", Typ = "Poison/Ground" },
           new Pokemon { Id = 035, Name = "Piepi", Typ = "Fairy" },
           new Pokemon { Id = 036, Name = "Pixi", Typ = "Fairy" },
           new Pokemon { Id = 037, Name = "Vulpix", Typ = "Fire" },
           new Pokemon { Id = 038, Name = "Vulnona", Typ = "Fire" },
           new Pokemon { Id = 039, Name = "Pummeluff", Typ = "Normal/Fairy" },
           new Pokemon { Id = 040, Name = "Knuddeluff", Typ = "Normal/Fairy" },
           new Pokemon { Id = 041, Name = "Zubat", Typ = "Poison/Flying" },
           new Pokemon { Id = 042, Name = "Golbat", Typ = "Poison/Flying" },
           new Pokemon { Id = 043, Name = "Myrapla", Typ = "Grass/Poison" },
           new Pokemon { Id = 044, Name = "Duflor", Typ = "Grass/Poison" },
           new Pokemon { Id = 045, Name = "Giflor", Typ = "Grass/Poison" },
           new Pokemon { Id = 046, Name = "Paras", Typ = "Bug/Grass" },
           new Pokemon { Id = 047, Name = "Parasek", Typ = "Bug/Grass" },
           new Pokemon { Id = 048, Name = "Bluzuk", Typ = "Bug/Poison" },
           new Pokemon { Id = 049, Name = "Omot", Typ = "Bug/Poison" },
           new Pokemon { Id = 050, Name = "Digda", Typ = "Ground" },
           new Pokemon { Id = 100, Name = "Voltobal", Typ = "Electric" },
           new Pokemon { Id = 101, Name = "Lektrobal", Typ = "Electric" },
           new Pokemon { Id = 150, Name = "Mewtu", Typ = "Psychic" }

        };



        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            return PokemonList;
        }
    }
}
