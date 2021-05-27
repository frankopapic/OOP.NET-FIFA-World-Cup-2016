using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class FavoriteTeamForm : Form
    {
        public FavoriteTeamForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var userControl = new Aplikacija.FavoriteTeam();
            panel1.Controls.Add(userControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
