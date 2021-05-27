using DataAccessLayer;
using DataAccessLayer.Models;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class RankList : Form
    {
        private List<Matches> Matches { get; set; }
		private List<Player> Players { get; set; } = new List<Player>();
        public RankList()
        {
            InitializeComponent();


        }

        private void RankList_Load(object sender, EventArgs e)
        {
            LoadList();
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

			Matches = await dataAccessForm.GetMatchesForCountry(kod);
            foreach (var plyr in startingElevens)
            {
                Player player = new Player { PlayerSE = plyr };
				LoadPlayer(player, Matches, new Teams { FifaCode = kod });
				Players.Add(player);
				FillLboxIgraci();
                
            }
        }

        private void FillLboxIgraci()
		{
			lboxIgraci.Items.Clear();
            foreach (var player in Players)
			{
				lboxIgraci.Items.Add(player);
			}
		}

        private void lboxIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxIgraci.Text = " ";
            string lines = lboxIgraci.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 6)
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = parts[1];
                tbBroj.Text = parts[2];
                tbPozicija.Text = parts[3];
                tbYellowCard.Text = parts[4];
                tbGoals.Text = parts[5];
                
            }
            else if (parts.Length == 7)
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = parts[1] + " " + parts[2];
                tbBroj.Text = parts[3];
                tbPozicija.Text = parts[4];
                tbYellowCard.Text = parts[5];
                tbGoals.Text = parts[6];
            }
            else
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = "";
                tbBroj.Text = parts[1];
                tbPozicija.Text = parts[2];
                tbYellowCard.Text = parts[3];
                tbGoals.Text = parts[4];
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Img\", lboxIgraci.SelectedItem.ToString())))
            {
                pboxIgrac.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Img\", lboxIgraci.SelectedItem.ToString()));
            }
            else
            {
                pboxIgrac.Image = Aplikacija.Properties.Resources.women;
            }

        }

        public void LoadPlayer(Player player, List<Matches> matches, Teams representation)
        {
            foreach (var match in matches)
            {
                if (match.HomeTeam.Code == representation.FifaCode)
                {
                    foreach (var matchEvent in match.HomeTeamEvents)
                        if (matchEvent.Player.Equals(player.PlayerSE.Name))
                        {
                            if (matchEvent.TypeOfEvent == TypeOfEvent.YellowCard)
                                ++player.YellowCards;

                            if (matchEvent.TypeOfEvent == TypeOfEvent.Goal || matchEvent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                                ++player.GoalsScored;
                        }
                }
                else if (match.AwayTeam.Code == representation.FifaCode)
                {
                    foreach (var matchEvent in match.AwayTeamEvents)
                        if (matchEvent.Player.Equals(player.PlayerSE.Name))
                        {
                            if (matchEvent.TypeOfEvent == TypeOfEvent.YellowCard)
                                ++player.YellowCards;

                            if (matchEvent.TypeOfEvent == TypeOfEvent.Goal || matchEvent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                                ++player.GoalsScored;
                        }
                }
            }
        }

        private void btnYellowSort_Click(object sender, EventArgs e)
        {
            Players.Sort(new YellowCardsAscComparer());
            FillLboxIgraci();
        }

        private void btnGoalsSort_Click(object sender, EventArgs e)
        {
            Players.Sort(new GoalsScoredAscComparer());
            FillLboxIgraci();
        }

        private StringReader myReader;

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Najbolji_Strijelci(e);
        }

        private void Najbolji_Strijelci(PrintPageEventArgs e)
        {
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.lboxIgraci.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                float yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            myBrush.Dispose();
        }
        private void BtnPrintGolovi_Click(object sender, EventArgs e)
            {
                printDialog.Document = printDocument;
                string strText = "";
                foreach (object x in lboxIgraci.Items)
                {
                    strText = strText + x.ToString() + "\n";
                }

                myReader = new StringReader(strText);
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    this.printDocument.Print();
                }
            }
        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == System.Drawing.Printing.PrintAction.PrintToPrinter)
            {
                MessageBox.Show("Gotovo je printanje", "Uspjesno!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void izađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pROMJENIPRVENSTVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
