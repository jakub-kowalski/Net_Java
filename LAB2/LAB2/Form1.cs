using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task<string> downloadPokemon()
        {
            string nameOrId = readName.Text.ToLower();
            using var client = new HttpClient();
            string call = $"https://pokeapi.co/api/v2/pokemon/{nameOrId}";
            var response = await client.GetAsync(call);
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            displayData.Text = "";
            try
            {
                var json = await downloadPokemon();
                readName.Text = "";
                var pokemon = JsonSerializer.Deserialize<Pokemon>(json);

                displayData.Text = "Name: " + pokemon.name + Environment.NewLine;
                displayData.Text += "Pokedex ID: #" + pokemon.id.ToString() + Environment.NewLine;
                /*displayData.Text += "Types: ";
                foreach (var type in pokemon.types)
                    displayData.Text += type.type.name + ", ";*/
               // displayData.Text = displayData.Text.TrimEnd(',', ' ') + Environment.NewLine;
                displayData.Text += "Height: " + pokemon.height.ToString() + Environment.NewLine;
                displayData.Text += "Weight: " + pokemon.weight.ToString() + Environment.NewLine;

                //  using (var context = new Pokedex())
                //{
                var context = new Pokedex();
                   /* var newPokemon = new Pokemon
                    {
                        name = pokemon.name,
                        height = pokemon.height,
                        weight = pokemon.weight,
                        id = pokemon.id
                    };*/

                    context.Pokemons.Add(new Pokemon
                    {
                        name = pokemon.name,
                        height = pokemon.height,
                        weight = pokemon.weight,
                        id = pokemon.id
                    });
                    context.SaveChanges();
               // }
            }
            catch
            {
                MessageBox.Show("Nie uda³o siê wczytaæ informacji o pokemonie. Spróbuj ponownie.");
            }

        }
    }
}