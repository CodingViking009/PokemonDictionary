using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWpfWithAPI
{
    internal class Pokemon(string id, string name, string type)
    {
        public string Id { get; set; } = id;
        public string Name { get; set;} = name;
        public string Type { get; set;} = type;
        public string ImgPath { get; set; }

        public void FillImgPath()
        {
            ImgPath = $"https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/detail/{Id}.png";
        }

        public override string ToString()
        {
            return $"{Name}:\n" +
                   $"Pokemon Index: {Id}\tTyp: {Type}";
        }
    }
}
