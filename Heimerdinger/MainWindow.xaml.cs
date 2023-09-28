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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Heimerdinger
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Définition de trois variables qui correspondent au premier nombre, au second nombre et au symbole de calcul 
        public MainWindow()
        {
            InitializeComponent();
        }
        string N1 = "";
        string N2 = "";
        string N3 = "";


        // Fonction d'appel des chiffres: 1, 2, 3, 4, 5, 6, 7, 8, 9 et 0
        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "1";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "1";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "1";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "1";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "2";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "2";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "2";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "2";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "3";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "3";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "3";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "3";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "4";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "4";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "4";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "4";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "5";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "5";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "5";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "5";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "6";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "6";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "6";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "6";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "7";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "7";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "7";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "7";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "8";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "8";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "8";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "8";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            if (N1 == "" && N3 == "")
            {
                N1 = "9";
            }
            else if (N1 != "" && N3 == "")
            {
                N1 = N1 + "9";
            }
            else if (N2 == "" && N3 != "" && N3 != "^0,5")
            {
                N2 = "9";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "9";
            }
            TB_Display.Text = N1 + N3 + N2;
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            if (N1 != "" && N3 == "")
            {
                N1 = N1 + "0";
            }
            else if (N2 != "" && N3 != "" && N3 != "^0,5")
            {
                N2 = N2 + "0";
            }
            TB_Display.Text = N1+N3+N2;
        }


        // Fonction d'appel du clear
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            N3 = "";
            N2 = "";
            N1 = "";
            TB_Display.Text = N1 + N3 + N2;
        }


        // Fonction d'appel des symboles de calcul: +, -, *, /, ** et √
        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            N3 = "+";
            TB_Display.Text = N1 + N3;
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            N3 = "-";
            TB_Display.Text = N1 + N3;
        }

        private void BTN_Fois_Click(object sender, RoutedEventArgs e)

        {

            N3 = "*";

            TB_Display.Text = N1 + N3;

        }

        private void BTN_Slash_Click(object sender, RoutedEventArgs e)

        {

            N3 = "/";

            TB_Display.Text = N1 + N3;

        }

        private void BTN_Puiss_Click(object sender, RoutedEventArgs e)

        {
            N3 = "**";

            TB_Display.Text = N1 + N3;
        }

        private void BTN_Rac_Click(object sender, RoutedEventArgs e)
        {
            N3 = "^0,5";

            TB_Display.Text = N1+N3;
        }


        // Fonction d'appel du bouton égal
        private void BTN_egal_Click(object sender, RoutedEventArgs e)

        {

            if (N3 == "+")

            {

                float tot = float.Parse(N1) + float.Parse(N2);

                TB_Display.Text = tot.ToString();

            }

            if (N3 == "-")

            {

                float tot = float.Parse(N1) - float.Parse(N2);

                TB_Display.Text = tot.ToString();

            }

            if (N3 == "*")

            {

                float tot = float.Parse(N1) * float.Parse(N2);

                TB_Display.Text = tot.ToString();



            }

            if (N3 == "/")

            {

                float tot = float.Parse(N1) / float.Parse(N2);

                TB_Display.Text = tot.ToString();


            }
            if (N3 == "**")
            {

                float tot = (float)Math.Pow(float.Parse(N1), float.Parse(N2));
                TB_Display.Text = tot.ToString();
            }
            if (N3 == "^0,5" && N1 != "")
            {
                float tot = (float)Math.Sqrt(float.Parse(N1));
                TB_Display.Text = tot.ToString();
            }
        }
    }
}