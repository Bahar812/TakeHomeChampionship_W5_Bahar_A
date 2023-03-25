using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeChampionship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_PlayerPosition.Items.Add("GK");
            comboBox_PlayerPosition.Items.Add("LB");
            comboBox_PlayerPosition.Items.Add("RB");
            comboBox_PlayerPosition.Items.Add("DF");
            comboBox_PlayerPosition.Items.Add("DM");
            comboBox_PlayerPosition.Items.Add("MF");
            comboBox_PlayerPosition.Items.Add("LW");
            comboBox_PlayerPosition.Items.Add("RW");
            comboBox_PlayerPosition.Items.Add("SS");

            comboBoxChooseCountry.Items.Add("SPAIN");
            comboBoxChooseCountry.Items.Add("ITALY");

            comboBoxChooseTeam.Items.Add("Real Madrid");
            comboBoxChooseTeam.Items.Add("Atletico Madrid");
            comboBoxChooseTeam.Items.Add("Juventus");
            teamsByCountry.Add("SPAIN", new List<string> { "Real Madrid" });
            teamsByCountry["SPAIN"].Add("Atletico Madrid");
            teamsByCountry.Add("ITALY", new List<string> { "Juventus" });
            playersByTeam.Add("SPAIN" + "Real Madrid", new List<string>());
            playersByTeam["SPAIN" + "Real Madrid"].Add("(09)" + " " + "Benzema" + " "+ "(LW)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(01)" + " " + "Courtois" + " " + "(GK)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(02)" + " " + "Carvajal" + " " + "(DF)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(03)" + " " + "Militão" + " " + "(DF)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(04)" + " " + "Alaba" + " " + "(DF)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(05)" + " " + "Jesús" + " " + "(DF)" );
            playersByTeam["SPAIN" + "Real Madrid"].Add("(06)" + " " + "Nacho" + " " + "(DF)" );
            playersByTeam["SPAIN" + "Real Madrid"].Add("(08)" + " " + "Kroos" + " " + "(MF)" );
            playersByTeam["SPAIN" + "Real Madrid"].Add("(10)" + " " + "Modrić" + " " + "(MF)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(11)" + " " + "Asensio" + " " + "(LW)" );
            playersByTeam["SPAIN" + "Real Madrid"].Add("(12)" + " " + "Camavinga" + " " + "(MF)");
            playersByTeam["SPAIN" + "Real Madrid"].Add("(20)" + " " + "Vinícius" + " " + "(LW)");
            playersByTeam.Add("SPAIN" + "Atletico Madrid", new List<string>());
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(01)" + " " + "Ivo" + " " + "(GK)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(02)" + " " + "José" + " " + "(DF)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(03)" + " " + "Reguilón" + " " + "(DF)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(04)" + " " + "Kondogbia" + " " + "(MF)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(05)" + " " + "Paul" + " " + "(MF)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(06)" + " " + "Koke" + " " + "(MF)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(08)" + " " + "Griezmann" + " " + "(LW)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(09)" + " " + "Depay" + " " + "(LW)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(10)" + " " + "Ángel" + " " + "(LW)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(13)" + " " + "JanOblak" + " " + "(GK)");
            playersByTeam["SPAIN" + "Atletico Madrid"].Add("(17)" + " " + "Saúl" + " " + "(MF)");
            playersByTeam.Add("ITALY" + "Juventus", new List<string>());
            playersByTeam["ITALY" + "Juventus"].Add("(01)" + " " + "Szczęsny" + " " + "(GK)");
            playersByTeam["ITALY" + "Juventus"].Add("(02)" + " " + "Sciglio" + " " + "(DF)");
            playersByTeam["ITALY" + "Juventus"].Add("(03)" + " " + "Bremer" + " " + "(DF)");
            playersByTeam["ITALY" + "Juventus"].Add("(05)" + " " + "Locatelli" + " " + "(MF)");
            playersByTeam["ITALY" + "Juventus"].Add("(06)" + " " + "Danilo" + " " + "(DF)");
            playersByTeam["ITALY" + "Juventus"].Add("(07)" + " " + "Chiesa" + " " + "(LW)");
            playersByTeam["ITALY" + "Juventus"].Add("(09)" + " " + "Vlahović" + " " + "(LF)");
            playersByTeam["ITALY" + "Juventus"].Add("(10)" + " " + "Pogba" + " " + "(LF)");
            playersByTeam["ITALY" + "Juventus"].Add("(22)" + " " + "DiMaría" + " " + "(RW)");
            playersByTeam["ITALY" + "Juventus"].Add("(19)" + " " + "Bonucci" + " " + "(DF)");
            playersByTeam["ITALY" + "Juventus"].Add("(25)" + " " + "Rabiot" + " " + "(MF)");
        }

        class Team
        {
            private string teamName;
            public string TeamName { get { return teamName; } set { teamName = value; } }
            private string teamCountry;
            public string TeamCountry { get { return teamCountry; } set { teamCountry = value; } }
            private string teamCity;
            public string TeamCity { get { return teamCity; } set { teamCity = value; } }
            public List<Player> Players = new List<Player>();

        }

        class Player
        {
            private string playerName;
            public string PlayerName { get { return playerName; } set { playerName = value; } }
            private string playerPos;
            public string PlayerPos { get { return playerPos; } set { playerPos = value; } }
            private string playerNum;
            public string PlayerNum { get { return playerNum; } set { playerNum = value; } }   
        }

        Dictionary<string, List<string>> teamsByCountry = new Dictionary<string, List<string>>();
        // Buat dictionary untuk menyimpan tim dan pemain
        Dictionary<string, List<string>> playersByTeam = new Dictionary<string, List<string>>();
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            listBox_Player.Items.Clear();
            if(!string.IsNullOrEmpty(txtBoxTeamName.Text) && !string.IsNullOrEmpty(textBoxTeamCity.Text) && !string.IsNullOrEmpty(textBoxTeamCountry.Text))
            {
                Team tim = new Team();
                tim.TeamName = txtBoxTeamName.Text;
                tim.TeamCity = textBoxTeamCity.Text;
                tim.TeamCountry = textBoxTeamCountry.Text;

                // Cek jika team ada di dictionary
                if (playersByTeam.ContainsKey(tim.TeamCountry + tim.TeamName))
                {
                    MessageBox.Show("Team already exists.");
                    txtBoxTeamName.Text = "";
                    textBoxTeamCity.Text = "";
                    textBoxTeamCountry.Text = "";
                    return;
                }
                if(!playersByTeam.ContainsKey(tim.TeamCountry + tim.TeamName))
                {
                    if (teamsByCountry.ContainsKey(tim.TeamCountry))
                    {
                        // nambahin tim ke negara yg sudah ada
                        teamsByCountry[tim.TeamCountry].Add(tim.TeamName);
                    }
                    else
                    {
                        // tambahkan negara baru ke dictionary
                        teamsByCountry.Add(tim.TeamCountry, new List<string> { tim.TeamName });

                        // tambahkan negara ke combo box choose Country
                        comboBoxChooseCountry.Items.Add(tim.TeamCountry);
                    }
                    // Jika tim tidak ada, buat daftar pemain baru untuk tim tersebut
                    playersByTeam.Add(tim.TeamCountry + tim.TeamName, new List<string>());
                    comboBoxChooseTeam.Items.Add(tim.TeamName);
                }
            }
            else
            {
                MessageBox.Show("Gaboleh Kosongg");
            }
            txtBoxTeamName.Text = "";
            textBoxTeamCity.Text = "";
            textBoxTeamCountry.Text = "";
            comboBoxChooseTeam.Text = "";
            comboBoxChooseCountry.Text = "";
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox_PlayerName.Text) && !string.IsNullOrEmpty(textBox_PlayerNumber.Text))
            {
                List<string> playerNames = new List<string>();
                foreach (object item in listBox_Player.Items)
                {
                    string playerName = item.ToString().Split(' ')[1];
                    playerNames.Add(playerName);
                }

                if (playerNames.Contains(textBox_PlayerName.Text)) 
                {
                    MessageBox.Show("Player name already exists.");
                    textBox_PlayerName.Text = "";
                    textBox_PlayerNumber.Text = "";
                    comboBox_PlayerPosition.Text = "";
                    return;
                }
                else
                {
                    Player players = new Player();
                    Team tim = new Team();
                    players.PlayerName = textBox_PlayerName.Text;
                    players.PlayerNum = textBox_PlayerNumber.Text;
                    players.PlayerPos = comboBox_PlayerPosition.SelectedItem.ToString();
                    string teamName = comboBoxChooseTeam.SelectedItem.ToString();
                    string country = comboBoxChooseCountry.SelectedItem?.ToString();

                    // tambah pemain ke dalam list pemain
                    playersByTeam[country + teamName].Add("(" + players.PlayerNum + ")" + " " + players.PlayerName + " " + "(" + players.PlayerPos + ")");

                    // clear
                    textBox_PlayerName.Clear();
                    comboBoxChooseTeam_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("gaboleh kosong");
            }
            textBox_PlayerName.Text = "";
            textBox_PlayerNumber.Text = "";
            comboBox_PlayerPosition.Text = "";
        }

        private void comboBox_PlayerPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxChooseCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team tim = new Team();
            foreach(Player pemain in tim.Players)
            {
                listBox_Player.Items.Add(pemain.PlayerNum + " " + pemain.PlayerName + " " + pemain.PlayerPos);
            }
        }

        private void comboBoxChooseCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear
            comboBoxChooseTeam.Items.Clear();

            
            string selectedCountry = comboBoxChooseCountry.SelectedItem.ToString();

           
            List<string> teams = teamsByCountry[selectedCountry];


            // tambah team di combo box choose team
            foreach (string team in teams)
            {
                comboBoxChooseTeam.Items.Add(team);
            }

            // pilih index yang pertama by default
            comboBoxChooseTeam.SelectedIndex = 0;
        
        }

        private void comboBoxChooseTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the players ListBox
            string selectedTeam = comboBoxChooseTeam.SelectedItem.ToString();
            string country = comboBoxChooseCountry.SelectedItem?.ToString();
            if(selectedTeam != null)
            {
                listBox_Player.DataSource = null;
                listBox_Player.Items.Clear();
                listBox_Player.DataSource = playersByTeam[country + selectedTeam];
            }
            else
            {
                listBox_Player.DataSource = null;
            }
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            string teamName = comboBoxChooseTeam.SelectedItem?.ToString();
            string country = comboBoxChooseCountry.SelectedItem?.ToString();

            if (teamName != null && country != null)
            {
                // Check jika nama tim ada di dictionary
                if (playersByTeam.ContainsKey(country + teamName))
                {
                    // mendapatkan pemain dari selected listbox
                    string selectedPlayer = listBox_Player.SelectedItem?.ToString();

                    // cek apakah pemain udah kepilih
                    if (selectedPlayer != null)
                    {
                        // Check apakah pemain kurang dari 11
                        if (playersByTeam[country + teamName].Count <= 11)
                        {
                            // menampilkan pesan
                            MessageBox.Show("There must be at least 11 players on the team.");
                        }
                        else
                        {
                            // menghapus pemain dari list
                            playersByTeam[country + teamName].Remove(selectedPlayer);

                            // Update listbox
                            listBox_Player.DataSource = null;
                            listBox_Player.Items.Clear();
                            listBox_Player.DataSource = playersByTeam[country + teamName];
                        }
                    }
                }
                else
                {
                    // jika tim ga ada
                    MessageBox.Show("Team does not exist.");
                }
            }
        }
    }
}
