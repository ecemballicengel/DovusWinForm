using Microsoft.VisualBasic.Devices;
using System.Numerics;

namespace DovusWinForm
{
    public partial class Form1 : Form
    {
        private Player player;
        private Computer computer;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void cmbxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var characters = cmbxCharacters.Items;


        }
        private void InitializeGame()
        {
            
            player = new Player("Sava���", 120, 15);

            
            computer = new Computer("Bilgisayar", 100, 12);

            // ComboBox'a karakter isimlerini ekle
            cmbxCharacters.Items.Add("Sava���");
            cmbxCharacters.Items.Add("B�y�c�");
            cmbxCharacters.Items.Add("Ork");
            cmbxCharacters.Items.Add("Elf");

            // �lk karakteri se�ili yap
            cmbxCharacters.SelectedIndex = 0;

            Update();
        }
        private void saldirButton_Click(object sender, EventArgs e)
        {
            // Se�ilen karakterin ad�n� al
            string selectedCharacter = cmbxCharacters.SelectedItem.ToString();

            // ComboBox'tan se�ilen karaktere g�re sald�r� i�lemlerini ger�ekle�tir
            switch (selectedCharacter)
            {
                case "Sava���":
                    player = new Player("Sava���", 120, 15);
                    break;
                case "B�y�c�":
                    player = new Player("B�y�c�", 80, 20);
                    break;
                case "Elf":
                    player = new Player("Elf", 100, 12);
                    break;
                case "Ork":
                    player = new Player("Ork", 90, 18);
                    break;
                default:
                    break;
            }

            // Bilgisayar sald�r� i�lemlerini ger�ekle�tir
            bool userHit = player.Attack();
            if (userHit)
            {
                
                computer.Health -= player.AttackPower;
                if(computer.Health < 0) { computer.Health = 0; }
            }
            else
            {
                MessageBox.Show("Iskaladiniz");
            }

            bool computerHit = computer.Attack();
            if (computerHit)
            {
                player.Health -= computer.AttackPower;
                if (player.Health < 0) { player.Health = 0; }
            }
            else
            {
                MessageBox.Show("Iskaladi");
            }

            if (player.Health <= 0)
            {
                MessageBox.Show("Oyun bitti! Kaybettiniz.");

            }
            if (computer.Health <= 0)
            {
                MessageBox.Show("Oyun bitti! Kazand�n�z.");

            }

            // Formdaki kontrolleri g�ncelle
            Update();
        }
        private void Update()
        {
            // Label'lara sa�l�k durumlar�n� yaz
            computerHealthLabel.Text = $"Bilgisayar Sa�l�k: {computer.Health}";
            userHealthLabel.Text = $"Oyuncu Sa�l�k: {player.Health}";
        }

        private void userHealthLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Character(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public virtual bool Attack()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0; 
        }
    }

    public class Player : Character
    {
        public Player(string name, int health, int attackPower) : base(name, health, attackPower)
        {
        }
    }

    public class Computer : Character
    {
        public Computer(string name, int health, int attackPower) : base(name, health, attackPower)
        {
        }
    }
}
