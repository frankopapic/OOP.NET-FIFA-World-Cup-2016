using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikacija.Lang;
using DataAccessLayer;

namespace Aplikacija
{
    public partial class NationalTeams : Form
    {
        public NationalTeams()
        {
            InitializeComponent();
        }

        private void NationalTeams_Load(object sender, EventArgs e)
        {
            LoadLanguages();
            LoadData();
        }

        private void LoadLanguages()
        {
            lblFavorite.Text = MyResources.lblChooseTeam;
        }

        private async void LoadData()
        {
            DataAccess data = new DataAccessLayer.DataAccess();

            var Teams = await data.GetTeams();

            foreach (var Team in Teams)
            {
                cbTeams.Items.Add($"{Team.Country} {Team.FifaCode} {Team.GroupLetter}");
            }
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Teams.txt");
            string selectedValue = cbTeams.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);
            new FavoriteTeamForm().Show();
            this.Hide();
        }
    }
}
