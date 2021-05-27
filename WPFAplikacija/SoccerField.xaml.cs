using CloudinaryDotNet.Actions;
using DataAccessLayer;
using DataAccessLayer.Models;
using QuickType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace WPFAplikacija
{

    public partial class SoccerField : Window
    {

        int rezHeight;
        int rezWidth;
        Team home;
        string away;

        public SoccerField(Team domaci, string gosti)
        {
            InitializeComponent();
            this.Loaded += Igraliste_Loaded;
            LoadData(domaci, gosti);
            home = domaci;
            away = gosti;
        }

        private void Igraliste_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\Res.txt"))
                {
                    String line = sr.ReadToEnd();
                    string[] parts = line.Split(':');
                    rezWidth = int.Parse(parts[0]);
                    rezHeight = int.Parse(parts[1]);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Nije moguce pronaci tekstualnu datoteku!");
                Console.WriteLine(ex.Message);
            }
            this.Width = rezWidth;
            this.Height = rezHeight;

        }


        private async void LoadData(Team domaci, string gosti)
        {
            DataAccess getData = new DataAccessLayer.DataAccess();

            var igraci = await getData.GetMatches();

            Matches utakmica = new Matches();

            foreach (var igrac in igraci)
            {
                if (igrac.HomeTeam.Country == domaci.Country || igrac.AwayTeam.Country == domaci.Country)
                {
                    if (igrac.HomeTeam.Country == gosti.ToString() || igrac.AwayTeam.Country == gosti.ToString())
                    {
                        utakmica = igrac;
                    }
                }
            }

            lblHome.Content = home.Country;
            lblGuest.Content = gosti;
            for (int i = 0; i < 11; i++)
            {
                if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {

                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackGKDomaci.Children.Add(new PlayerUC(number));

                    Button btnGK = new Button();
                    btnGK.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnGK.Height = 25;
                    btnGK.Width = 120;
                    btnGK.Background = System.Windows.Media.Brushes.Transparent;
                    btnGK.Foreground = System.Windows.Media.Brushes.White;
                    btnGK.Click += Igrac_Click;
                    stackGKDomaci.Children.Add(btnGK);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackDefDomaci.Children.Add(new PlayerUC(number));

                    Button btnDef = new Button();
                    btnDef.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnDef.Height = 25;
                    btnDef.Width = 120;
                    btnDef.Background = System.Windows.Media.Brushes.Transparent;
                    btnDef.Foreground = System.Windows.Media.Brushes.White;
                    btnDef.Click += Igrac_Click;
                    stackDefDomaci.Children.Add(btnDef);

                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackMidDomaci.Children.Add(new PlayerUC(number));


                    Button btnMid = new Button();
                    btnMid.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnMid.Height = 25;
                    btnMid.Width = 120;
                    btnMid.Background = System.Windows.Media.Brushes.Transparent;
                    btnMid.Foreground = System.Windows.Media.Brushes.White;
                    btnMid.Click += Igrac_Click;
                    stackMidDomaci.Children.Add(btnMid);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackFowDomaci.Children.Add(new PlayerUC(number));


                    Button btnFor = new Button();
                    btnFor.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnFor.Height = 25;
                    btnFor.Width = 120;
                    btnFor.Background = System.Windows.Media.Brushes.Transparent;
                    btnFor.Foreground = System.Windows.Media.Brushes.White;
                    btnFor.Click += Igrac_Click;
                    stackFowDomaci.Children.Add(btnFor);
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackGKGosti.Children.Add(new PlayerUC(number));


                    Button btnGK = new Button();
                    btnGK.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnGK.Height = 25;
                    btnGK.Width = 120;
                    btnGK.Background = System.Windows.Media.Brushes.Transparent;
                    btnGK.Foreground = System.Windows.Media.Brushes.White;
                    btnGK.Click += Igrac_Click;
                    stackGKGosti.Children.Add(btnGK);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackDefGosti.Children.Add(new PlayerUC(number));


                    Button btnDef = new Button();
                    btnDef.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnDef.Height = 25;
                    btnDef.Width = 120;
                    btnDef.Background = System.Windows.Media.Brushes.Transparent;
                    btnDef.Foreground = System.Windows.Media.Brushes.White;
                    btnDef.Click += Igrac_Click;
                    stackDefGosti.Children.Add(btnDef);

                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackMidGosti.Children.Add(new PlayerUC(number));


                    Button btnMid = new Button();
                    btnMid.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnMid.Height = 25;
                    btnMid.Width = 120;
                    btnMid.Background = System.Windows.Media.Brushes.Transparent;
                    btnMid.Foreground = System.Windows.Media.Brushes.White;
                    btnMid.Click += Igrac_Click;
                    stackMidGosti.Children.Add(btnMid);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    int number = (int)utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    stackFowGosti.Children.Add(new PlayerUC(number));


                    Button btnFor = new Button();
                    btnFor.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnFor.Height = 25;
                    btnFor.Width = 120;
                    btnFor.Background = System.Windows.Media.Brushes.Transparent;
                    btnFor.Foreground = System.Windows.Media.Brushes.White;
                    btnFor.Click += Igrac_Click;
                    stackFowGosti.Children.Add(btnFor);
                }
            }

        }

        private void Igrac_Click(object sender, RoutedEventArgs e)
        {
            string s = (sender as Button).Content.ToString();
            PlayerInfo prikaz = new PlayerInfo(s, home, away);
            prikaz.Show();
        }


    }
}
