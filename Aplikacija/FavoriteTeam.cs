using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using System.IO;
using QuickType;
using Aplikacija.Lang;

namespace Aplikacija
{
    public partial class FavoriteTeam : UserControl
    {
        public FavoriteTeam()
        {
            InitializeComponent();
            LoadLanguages();
        }

        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadLanguages()
        {
            lblAllPlayers.Text = MyResources.lblAllPlayers;
            lblSelectedPlayers.Text = MyResources.lblSelectedPlayers;
            btnAdd.Text = MyResources.btnAdd;
            btnDelete.Text = MyResources.btnDelete;
            btnSave.Text = MyResources.btnSave;
        }

        private async void LoadList()
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
            
            var Matches = await dataAccessForm.GetMatches();

            lbDrzava.Text = drzava;
            lbKod.Text = kod;
            lbGrupa.Text = grupa;

            List<StartingEleven> startingElevens = new List<StartingEleven>();

            for (int i = 0; i < 16; i++)
            {
                if (Matches[i].AwayTeamCountry == drzava)
                {
                    for (int j = 0; j < Matches[i].AwayTeamStatistics.StartingEleven.Count; j++)
                    {
                        startingElevens.Add(Matches[i].AwayTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < Matches[i].AwayTeamStatistics.Substitutes.Count; j++)
                    {
                        startingElevens.Add(Matches[i].AwayTeamStatistics.Substitutes[j]);
                    }
                }
                else if (Matches[i].HomeTeamCountry == drzava)
                {
                    for (int j = 0; j < Matches[i].HomeTeamStatistics.StartingEleven.Count; j++)
                    {
                        startingElevens.Add(Matches[i].HomeTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < Matches[i].HomeTeamStatistics.Substitutes.Count; j++)
                    {
                        startingElevens.Add(Matches[i].HomeTeamStatistics.Substitutes[j]);
                    }
                }

            }

            foreach (var Player in startingElevens)
            {
                lboxPlayerList.Items.Add(Player);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var player = lboxPlayerList.SelectedItem;

            if (player == null)
            {
                return;
            }
            
            lboxFavoriteList.Items.Add(player);
            lboxPlayerList.Items.Remove(player);
           
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var player = lboxFavoriteList.SelectedItem;

            if (player == null)
            {
                return;
            }

            lboxFavoriteList.Items.Remove(player);
            lboxPlayerList.Items.Add(player);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\Favorite.txt";

            StreamWriter SaveFile = new StreamWriter(path);
            foreach (var item in lboxFavoriteList.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.ToString();
            SaveFile.Close();

            new PlayerInfo().Show();
            this.Hide();
        }
    }
}
