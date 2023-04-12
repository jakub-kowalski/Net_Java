using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public List<PokemonType> types { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
    }
    public class PokemonType
    {
        public PokemonTypeInfo type {get;set;}
    }
    public class PokemonTypeInfo
    {
        public string name { get; set; }
    }
}
