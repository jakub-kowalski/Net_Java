using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
       // public List<PokemonType> types { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
    }
   /* public class PokemonType
    {
        [Key]
        public int Id { get; set; }
        public PokemonTypeInfo type {get;set;}
    }
    public class PokemonTypeInfo
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }*/
}
