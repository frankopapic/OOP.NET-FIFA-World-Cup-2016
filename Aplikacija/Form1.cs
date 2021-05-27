using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class Form1 : Form
    {
        private const string HR = "hr",
                            EN = "en";
        public Form1()
        {
            init();
            InitializeComponent();
        }

        private void init()
        {
            if (System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Kultura.txt")) == EN)
            {
                PostaviKulturu(EN);
            }
            else
            {
                PostaviKulturu(HR);
            }
        }

        private void PostaviKulturu(string kultura)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);

                foreach (Control control in Controls)
                {
                    var resursi = new ComponentResourceManager(typeof(Form1));
                    resursi.ApplyResources(control, control.Name, new CultureInfo(kultura));
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);
                btnLanguage.BackgroundImage = Aplikacija.Properties.Resources.uk;
            }
            else
            {
                PostaviKulturu(HR);
                btnLanguage.BackgroundImage = Aplikacija.Properties.Resources.croatia;
            }
            ZapisiKulturu();
        }

        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Kultura.txt"), btnLanguage.Text.ToLower());
        }

        private void btnRussia_Click(object sender, EventArgs e)
        {
            if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Teams.txt")).Length == 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Favorite.txt")).Length == 0)
            {
                new NationalTeams().Show();
            }
            else if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Teams.txt")).Length != 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Favorite.txt")).Length == 0)
            {
                new FavoriteTeam().Show();
            }
            else
            {
                new PlayerInfo().Show();
            }
            this.Hide();
            ZapisiSource("men");

        }

        private void btnFrance_Click(object sender, EventArgs e)
        {
            if(new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Teams.txt")).Length == 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Favorite.txt")).Length == 0)
            {
                new NationalTeams().Show();
            }
            else if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Teams.txt")).Length != 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Favorite.txt")).Length == 0)
            {
                new FavoriteTeam().Show();
            }
            else
            {
                new PlayerInfo().Show();
            }
            this.Hide();
            ZapisiSource("women");
        }

        private void ZapisiSource(string source)
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\Source.txt"), source);
        }
    }
}
