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
            
            player = new Player("Savaþçý", 120, 15);

            
            computer = new Computer("Bilgisayar", 100, 12);

            // ComboBox'a karakter isimlerini ekle
            cmbxCharacters.Items.Add("Savaþçý");
            cmbxCharacters.Items.Add("Büyücü");
            cmbxCharacters.Items.Add("Ork");
            cmbxCharacters.Items.Add("Elf");

            // Ýlk karakteri seçili yap
            cmbxCharacters.SelectedIndex = 0;

            Update();
        }
        private void saldirButton_Click(object sender, EventArgs e)
        {
            // Seçilen karakterin adýný al
            string selectedCharacter = cmbxCharacters.SelectedItem.ToString();

            // ComboBox'tan seçilen karaktere göre saldýrý iþlemlerini gerçekleþtir
            switch (selectedCharacter)
            {
                case "Savaþçý":
                    player = new Player("Savaþçý", 120, 15);
                    break;
                case "Büyücü":
                    player = new Player("Büyücü", 80, 20);
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

            // Bilgisayar saldýrý iþlemlerini gerçekleþtir
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
                MessageBox.Show("Oyun bitti! Kazandýnýz.");

            }

            // Formdaki kontrolleri güncelle
            Update();
        }
        private void Update()
        {
            // Label'lara saðlýk durumlarýný yaz
            computerHealthLabel.Text = $"Bilgisayar Saðlýk: {computer.Health}";
            userHealthLabel.Text = $"Oyuncu Saðlýk: {player.Health}";
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
