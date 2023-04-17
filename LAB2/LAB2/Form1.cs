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
        private async Task<string> downloadRandomPokemon()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 905);
            using var client = new HttpClient();
            string call = $"https://pokeapi.co/api/v2/pokemon/{randomNumber}";
            var response = await client.GetAsync(call);
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        private void printData(Pokemon pokemon)
        {
            displayData.Text = "Name: " + pokemon.name + Environment.NewLine;
            displayData.Text += "Pokedex ID: #" + pokemon.id.ToString() + Environment.NewLine;
            displayData.Text += "Height: " + pokemon.height.ToString() + Environment.NewLine;
            displayData.Text += "Weight: " + pokemon.weight.ToString() + Environment.NewLine;

            // check if image file exists
            //tring imagePath = AppDomain.CurrentDomain.BaseDirectory + "images\\" + pokemon.name.ToLower() + ".png";
            string imagePath = @"C:\Users\DawidZaj¹c(259386)\source\repos\Net_Java\LAB2\LAB2\images";
            imagePath = Path.Combine(imagePath, pokemon.name.ToLower() + ".png");

            if (File.Exists(imagePath))
            {
                // remove existing pictureBox before loading new one
                foreach (Control control in Controls)
                {
                    if (control is PictureBox)
                    {
                        Controls.Remove(control);
                        control.Dispose();
                    }
                }

                // load and display the image
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Width = 200;
                pictureBox.Height = 200;
                Controls.Add(pictureBox);
                pictureBox.Location = new Point(300, 50);
            }
        }

        private Pokedex pokedex;

        private async void button1_Click(object sender, EventArgs e)
        {
            displayData.Text = "";
            try
            {
                var nameOrId = readName.Text.ToLower();
                pokedex = new Pokedex();

                // Sprawdzenie, czy pokemon istnieje w bazie danych
                var pokemon = pokedex.Pokemons.FirstOrDefault(p => p.name.ToLower() == nameOrId || p.id.ToString() == nameOrId);

                if (pokemon != null)
                {
                    printData(pokemon);
                }
                else
                {
                    var json = await downloadPokemon();
                    pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                    readName.Text = "";

                    printData(pokemon);

                    // Dodanie nowego pokemona do bazy danych
                    try
                    {
                        pokedex.Pokemons.Add(new Pokemon()
                        {
                            name = pokemon.name,
                            height = pokemon.height,
                            weight = pokemon.weight,
                            id = pokemon.id
                        });
                        pokedex.SaveChanges();
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {
                        MessageBox.Show("B³¹d dodawania Pokemona do bazy danych: " + ex.InnerException.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nie uda³o siê wczytaæ informacji o pokemonie. Spróbuj ponownie.");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            displayData.Text = "";
            try
            {
                var nameOrId = readName.Text.ToLower();
                pokedex = new Pokedex();

                // Sprawdzenie, czy pokemon istnieje w bazie danych
                var pokemon = pokedex.Pokemons.FirstOrDefault(p => p.name.ToLower() == nameOrId || p.id.ToString() == nameOrId);

                if (pokemon != null)
                {
                    printData(pokemon);
                }
                else
                {
                    var json = await downloadRandomPokemon();
                    pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                    readName.Text = "";

                    printData(pokemon);

                    // Dodanie nowego pokemona do bazy danych
                    try
                    {
                        pokedex.Pokemons.Add(new Pokemon()
                        {
                            name = pokemon.name,
                            height = pokemon.height,
                            weight = pokemon.weight,
                            id = pokemon.id
                        });
                        pokedex.SaveChanges();
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {
                        MessageBox.Show("B³¹d dodawania Pokemona do bazy danych: " + ex.InnerException.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nie uda³o siê wczytaæ informacji o pokemonie. Spróbuj ponownie.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}