using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LAB2
{
    internal class Pokedex:DbContext
    {
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        // public virtual DbSet<PokemonType> PokemonTypes { get; set; }
        // public virtual DbSet<PokemonTypeInfo> PokemonTypeInfos { get; set; }
        public Pokedex()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Pokedex.db");
        }
      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonType>().HasKey(pt => pt.Id);
            modelBuilder.Entity<PokemonTypeInfo>().HasKey(pt => pt.Id);
        }*/
    }
}
