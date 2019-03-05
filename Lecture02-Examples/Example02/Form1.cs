using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Example02
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;
        public int UserStarDust;
        public int UserCandy;

        public Form1()
        {
            InitializeComponent();
            UserStarDust = 100000;
            UserCandy = 5555;
            pokemon = new Pokemon()
            {
                Name = "妙蛙種子",
                CurrentHP = 50,
                HP = 60,
                Height = 6.94f,
                Types = new string[] { "草", "毒" },
                Weight = 0.76f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 25
            };
            NameLable.Text = pokemon.Name;
            HpLable.Text = pokemon.CurrentHP.ToString() + "/" +
                pokemon.HP + "HP";
            HeightLabel.Text = pokemon.Height.ToString();
            TypesLabel.Text = pokemon.Types[0] + "/" +
                pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - pokemon.PowerUpCandy;
            UserStarDust = UserStarDust - pokemon.PowerUpStardust;
            pokemon.HP = pokemon.HP + 10;
            pokemon.CurrentHP = pokemon.CurrentHP + 10;
            HpLable.Text = pokemon.CurrentHP.ToString() + "/" +
               pokemon.HP + "HP";
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - pokemon.EvolveCandy;
            pokemon = new Pokemon()
            {
                Name = "妙蛙草",
                CurrentHP = 150,
                HP = 250,
                Height = 10.94f,
                Types = new string[] { "草", "毒" },
                Weight = 1.87f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 100
            };
            NameLable.Text = pokemon.Name;
            HpLable.Text = pokemon.CurrentHP.ToString() + "/" +
                pokemon.HP + "HP";
            HeightLabel.Text = pokemon.Height.ToString();
            TypesLabel.Text = pokemon.Types[0] + "/" +
                pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardustLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }
    }
}