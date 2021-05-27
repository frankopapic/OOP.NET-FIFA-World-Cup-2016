using Aplikacija.Lang;
using DataAccessLayer;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class PlayerInfo : Form
    {
       
        public PlayerInfo()
        {
            InitializeComponent();
            LoadData();
            LoadLanguages();
        }
        private void Igraci_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadLanguages()
        {
            btnNext.Text = MyResources.btnNext;
            btnDodajSliku.Text = MyResources.btnDodajSliku;
            btnSave.Text = MyResources.btnSave;

        }
        private async void LoadData()
        {
            DataAccess dataAccessForm = new DataAccessLayer.DataAccess();

            string drzava;
            string kod;
            string grupa;

            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Teams.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');

            if (parts.Length == 3)
            {
                drzava = parts[0];
                kod = parts[1];
                grupa = parts[2];
            }
            else
            {
                drzava = parts[0] + " " + parts[1];
                kod = parts[2];
                grupa = parts[3];
            }

            lbDrzava.Text = drzava;
            lbKod.Text = kod;

            var Matches = await dataAccessForm.GetMatches();

            List<StartingEleven> ListPlayers = new List<StartingEleven>();

            for (int i = 0; i < 16; i++)
            {
                if (Matches[i].AwayTeamCountry == drzava)
                {
                    for (int j = 0; j < Matches[i].AwayTeamStatistics.StartingEleven.Count; j++)
                    {
                        ListPlayers.Add(Matches[i].AwayTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < Matches[i].AwayTeamStatistics.Substitutes.Count; j++)
                    {
                        ListPlayers.Add(Matches[i].AwayTeamStatistics.Substitutes[j]);
                    }
                }
                else if (Matches[i].HomeTeamCountry == drzava)
                {
                    for (int j = 0; j < Matches[i].HomeTeamStatistics.StartingEleven.Count; j++)
                    {
                        ListPlayers.Add(Matches[i].HomeTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < Matches[i].HomeTeamStatistics.Substitutes.Count; j++)
                    {
                        ListPlayers.Add(Matches[i].HomeTeamStatistics.Substitutes[j]);
                    }
                }

            }

            foreach (var Player in ListPlayers)
            {
                lboxIgraci.Items.Add(Player);
            }
        }

        private void PlayerInfo_Load(object sender, EventArgs e)
        {

        }

        private void lboxIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxIgraci.Text = " ";
            string lines = lboxIgraci.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 5)
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = parts[1];
                tbBroj.Text = parts[2];
                tbPozicija.Text = parts[3];
                string kapetan = parts[4];
                if (kapetan == "TRUE")
                {
                    tbKapetan.Text = "KAPETAN";
                }
                else
                {
                    tbKapetan.Text = "";
                }
            }
            else if (parts.Length == 6)
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = parts[1] + " " + parts[2];
                tbBroj.Text = parts[3];
                tbPozicija.Text = parts[4];
                if (parts[5] == "TRUE")
                {
                    tbKapetan.Text = "KAPETAN";
                }
            }
            else
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = "";
                tbBroj.Text = parts[1];
                tbPozicija.Text = parts[2];
                if (parts[3] == "TRUE")
                {
                    tbKapetan.Text = "KAPETAN";
                }
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Img", lboxIgraci.SelectedItem.ToString())))
            {
                pboxIgrac.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Img", lboxIgraci.SelectedItem.ToString()));
            }
            else
            {
                pboxIgrac.Image = Aplikacija.Properties.Resources.women;
            }
            
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbSave.Text = open.FileName;
                    pboxIgrac.Image = new Bitmap(open.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Greska", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                File.Copy(tbSave.Text, Path.Combine(Environment.CurrentDirectory, @"..\..\..\Img", lboxIgraci.SelectedItem.ToString()), true);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            new RankList().Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(tbSave.Text, Path.Combine(@"..\..\..\Img", Path.GetFileName(tbSave.Text)), true);
            MessageBox.Show("Uspjesno spremanje", "Uspjesno", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
