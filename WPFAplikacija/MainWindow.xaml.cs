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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAplikacija
{

    public partial class MainWindow : Window
    {
        private const string HR = "hr",
                            EN = "en";
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

    private void Init()
    {
        btnLang.Content = HR;
    }
    private void btnLang_Click(object sender, RoutedEventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                SetLanguage(EN);
                btnLang.Content = "EN";
            }
            else
            {
                SetLanguage(HR);
                btnLang.Content = "HR";
            }
            ZapisiKulturu();
        }

        private void SetLanguage(string kultura)
        {
            try
            {
                //postavi lokalizaciju = prevodi
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                //postavi globalizaciju = datum,vrijeme,valute
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(@"..\..\..\Kultura.txt", btnLang.Content.ToString().ToLower());
        }


        private void imgWomen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ChooseTeams chooseTeams = new ChooseTeams();
            this.Visibility = Visibility.Hidden;
            chooseTeams.Show();
            WriteToFile("women");
        }
        private void WriteToFile(string source)
        {
            System.IO.File.WriteAllText(@"..\..\..\Source.txt", source);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radiobtn = sender as RadioButton;
            System.IO.File.WriteAllText(@"..\..\..\Res.txt", radiobtn.Content.ToString());
        }

        private void imgManBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ChooseTeams chooseTeams = new ChooseTeams();
            this.Visibility = Visibility.Hidden;
            chooseTeams.Show();
            WriteToFile("men");
        }
    }
}
