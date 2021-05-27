using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataAccessLayer;
using QuickType;
using WPFAplikacija.lang;

namespace WPFAplikacija
{

    public partial class ChooseTeams : Window
    {
        public ChooseTeams()
        {
            InitializeComponent();
            LoadData();
            Init();
        }

        private void Init()
        {
            Prijevod();
        }


        private void Prijevod()
        {
            lblChooseTeams.Content = MyResources.lblChooseTeams;
            lbDomaciTim.Content = MyResources.lbDomaciTim;
            lbGostujuciTim.Content = MyResources.lbGostujuciTim;
        }

        List<Matches> matchesList;
        private async void LoadData()
        {
            DataAccess dataAccess = new DataAccessLayer.DataAccess();

            var Reprezentacije = await dataAccess.GetMatches();
            matchesList = Reprezentacije;
            List<Team> teams = new List<Team>();
            for (int i = 0; i < 16; i++)
            {
                teams.Add(Reprezentacije[i].HomeTeam);
                teams.Add(Reprezentacije[i].AwayTeam);
            }
            foreach (var team in teams)
            {
                cbHome.Items.Add(team);
            }
        }
        private void cbHome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbGuest.Items.Clear();
            var Reprezentacije = cbHome.SelectedValue as Team;
            for (int i = 0; i < matchesList.Count(); i++)
            {
                if (matchesList[i].HomeTeam.Country == Reprezentacije.Country)
                {
                    cbGuest.Items.Add(matchesList[i].AwayTeam.Country);
                }
                else if (matchesList[i].AwayTeam.Country == Reprezentacije.Country)
                {
                    cbGuest.Items.Add(matchesList[i].HomeTeam.Country);
                }
            }
        }

        private void Info_MouseDown(object sender, RoutedEventArgs e)
        {
            var Domaci = cbHome.SelectedValue as Team;
            if (Domaci == null)
            {
                MessageBox.Show("Odaberite Reprezentaciju!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var TeamInformation = new TeamInformation(Domaci);
            TeamInformation.Show();
        }

        private void Next_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            var home = cbHome.SelectedValue as Team;
            var soccerField = new SoccerField(home, cbGuest.SelectedItem.ToString());
            this.Visibility = Visibility.Hidden;
            soccerField.Show();
        }

    }
}
