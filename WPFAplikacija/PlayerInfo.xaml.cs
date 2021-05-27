using DataAccessLayer;
using DataAccessLayer.Models;
using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// <summary>
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        public PlayerInfo(string s, Team home, string away)
        {
            InitializeComponent();
            Task task = LoadData(s, home, away);
            init();

        }

        private void init()
        {
            Prijevod();
        }

        private void Prijevod()
        {
            lbName.Content = MyResources.lblPlayerName;
            lbNumber.Content = MyResources.lblPlayerNumber;
            lbPosition.Content = MyResources.lblPlayerPosition;
            lbGoals.Content = MyResources.lblGoalsScored;
            lbYellow.Content = MyResources.lblPlayerYellowCards;
        }

        private async Task LoadData(string s, Team home, string away)
        {
            DataAccess getData = new DataAccessLayer.DataAccess();

            var igraci = await getData.GetMatches();

            StartingEleven odabrani = new StartingEleven();

            Matches utakmica = new Matches();

            foreach (var igrac in igraci)
            {
                if (igrac.HomeTeam.Country == home.Country || igrac.AwayTeam.Country == home.Country)
                {
                    if (igrac.HomeTeam.Country == away.ToString() || igrac.AwayTeam.Country == away.ToString())
                    {
                        utakmica = igrac;
                    }
                }

                foreach (var player in utakmica.HomeTeamStatistics.StartingEleven)
                {
                    if (player.Name == s)
                    {
                        odabrani = player;
                    }
                }
                foreach (var player in utakmica.AwayTeamStatistics.StartingEleven)
                {
                    if (player.Name == s)
                    {
                        odabrani = player;
                    }
                }

                int brojGolova = 0;
                int brojZutih = 0;

                foreach (var dogadaj in utakmica.HomeTeamEvents)
                {
                    if (dogadaj.TypeOfEvent == TypeOfEvent.Goal || dogadaj.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojGolova++;
                        }
                    }
                    if (dogadaj.TypeOfEvent == TypeOfEvent.YellowCard || dogadaj.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojZutih++;
                        }
                    }
                }
                foreach (var dogadaj in utakmica.AwayTeamEvents)
                {
                    if (dogadaj.TypeOfEvent == TypeOfEvent.Goal || dogadaj.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojGolova++;
                        }
                    }
                    if (dogadaj.TypeOfEvent == TypeOfEvent.YellowCard || dogadaj.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojZutih++;
                        }
                    }
                }

               
                lblPlayerName.Content = odabrani.Name;
                lblPlayerNumber.Content = odabrani.ShirtNumber;
                lblPlayerPosition.Content = odabrani.Position;
                lblPlayerGoalsScored.Content = brojGolova;
                lblPlayerYellowCards.Content = brojZutih;
            }


        }

    }
}
