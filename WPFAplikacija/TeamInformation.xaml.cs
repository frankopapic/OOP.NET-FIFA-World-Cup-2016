using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFAplikacija.lang;

namespace WPFAplikacija
{

    public partial class TeamInformation : Window
    {
        public TeamInformation(Team tim)
        {
            InitializeComponent();
            LoadData(tim);
        }

        private async void LoadData(Team team)
        {
            var nations = await GetData();
            Teams Nationalteam = new Teams();
            foreach (var drzava in nations)
            {
                if (drzava.Country == team.Country)
                {
                    Nationalteam = drzava;
                }
            }
            Init(Nationalteam);
        }
        private Task<List<Teams>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/teams/results");


                var result = restClient.Execute<Teams>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Teams>>(result.Content);

            });
        }
        private void Init(Teams Nationalteam)
        {
            DetaljiRepke(Nationalteam);
            //Prijevod();
        }

        private void DetaljiRepke(Teams nacija)
        {
            lblRepresentationName.Content = nacija.Country;
            lblRepresentationCode.Content = nacija.FifaCode;
            lblGamesPlayed.Content = nacija.GamesPlayed;
            lblGamesWon.Content = nacija.Wins;
            lblGamesLost.Content = nacija.Losses;
            lblGoalsScored.Content = nacija.GoalsFor;
            lblGoalsReceived.Content = nacija.GoalsAgainst;
            lblGoalDifference.Content = nacija.GoalDifferential;
        }

        private void Prijevod()
        {
            lbName.Content = MyResources.lblRepresentationName;
            lbCode.Content = MyResources.lblRepresentationCode;
            lbGames.Content = MyResources.lblGamesPlayed;
            lbWins.Content = MyResources.lblGamesWon;
            lbLost.Content = MyResources.lblGamesLost;
            lbGoals.Content = MyResources.lblGoalsScored;
            lbRecieved.Content = MyResources.lblGoalsReceived;
            lbDiff.Content = MyResources.lblGoalDifference;

        }
    }
}
