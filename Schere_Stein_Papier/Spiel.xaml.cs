using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Schere_Stein_Papier
{
    /// <summary>
    /// Interaktionslogik für Spiel.xaml
    /// </summary>
    public partial class Spiel : Window
    {
        int[] score = new int[2] { 0, 0 };
        public Spiel()
        {
            InitializeComponent();
        }

        private void Schere_Click(object sender, RoutedEventArgs e)
        {

            //Player
            BitmapImage PlayerSchere = new BitmapImage();
            PlayerSchere.BeginInit();
            PlayerSchere.UriSource = new Uri("Schere.gif", UriKind.Relative);
            PlayerSchere.EndInit();
            IMG_Player.Stretch = Stretch.Fill;
            IMG_Player.Source = PlayerSchere;
            Random rn = new Random();
            int spieler = rn.Next(1, 4);

            switch (spieler)
            {
                case 1:
                    //Schere
                    BitmapImage ComputerSchere = new BitmapImage();
                    ComputerSchere.BeginInit();
                    ComputerSchere.UriSource = new Uri("Schere.gif", UriKind.Relative);
                    ComputerSchere.EndInit();
                    IMG_Computer.Source = ComputerSchere;
                    MessageBox.Show("Gleichstand!", "Spielergebnis:");
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
                case 2:
                    //Papier
                    BitmapImage ComputerPapier = new BitmapImage();
                    ComputerPapier.BeginInit();
                    ComputerPapier.UriSource = new Uri("Papier.jpg", UriKind.Relative);
                    ComputerPapier.EndInit();
                    IMG_Computer.Source = ComputerPapier;
                    MessageBox.Show("Gewonnen!", "Spielergebnis:");
                    score[0] = score[0] + 1;
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
                case 3:
                    //Stein
                    BitmapImage ComputerStein = new BitmapImage();
                    ComputerStein.BeginInit();
                    ComputerStein.UriSource = new Uri("Stein.jpg", UriKind.Relative);
                    ComputerStein.EndInit();
                    IMG_Computer.Source = ComputerStein;
                    MessageBox.Show("Verloren!", "Spielergebnis:");
                    score[1] = score[1] + 1;
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
            }


        }

        private void Stein_Click(object sender, RoutedEventArgs e)
        {
            //Player
            BitmapImage PlayerStein = new BitmapImage();
            PlayerStein.BeginInit();
            PlayerStein.UriSource = new Uri("Stein.jpg", UriKind.Relative);
            PlayerStein.EndInit();
            IMG_Player.Stretch = Stretch.Fill;
            IMG_Player.Source = PlayerStein;
            Random rn = new Random();
            int spieler = rn.Next(1, 4);

            switch (spieler)
            {
                case 1:
                    //Schere
                    BitmapImage ComputerSchere = new BitmapImage();
                    ComputerSchere.BeginInit();
                    ComputerSchere.UriSource = new Uri("Schere.gif", UriKind.Relative);
                    ComputerSchere.EndInit();
                    IMG_Computer.Source = ComputerSchere;
                    MessageBox.Show("Gewonnen!", "Spielergebnis:");
                    score[0] = score[0] + 1;
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
                case 2:
                    //Papier
                    BitmapImage ComputerPapier = new BitmapImage();
                    ComputerPapier.BeginInit();
                    ComputerPapier.UriSource = new Uri("Papier.jpg", UriKind.Relative);
                    ComputerPapier.EndInit();
                    IMG_Computer.Source = ComputerPapier;
                    MessageBox.Show("Verloren!", "Spielergebnis:");
                    score[1] = score[1] + 1;
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
                case 3:
                    //Stein
                    BitmapImage ComputerStein = new BitmapImage();
                    ComputerStein.BeginInit();
                    ComputerStein.UriSource = new Uri("Stein.jpg", UriKind.Relative);
                    ComputerStein.EndInit();
                    IMG_Computer.Source = ComputerStein;
                    MessageBox.Show("Gleichstand!", "Spielergebnis:");
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
            }
        }

        private void Papier_Click(object sender, RoutedEventArgs e)
        {
            //Player
            BitmapImage PlayerPapier = new BitmapImage();
            PlayerPapier.BeginInit();
            PlayerPapier.UriSource = new Uri("Papier.jpg", UriKind.Relative);
            PlayerPapier.EndInit();
            IMG_Player.Stretch = Stretch.Fill;
            IMG_Player.Source = PlayerPapier;
            Random rn = new Random();
            int spieler = rn.Next(1, 4);

            switch (spieler)
            {
                case 1:
                    //Schere
                    BitmapImage ComputerSchere = new BitmapImage();
                    ComputerSchere.BeginInit();
                    ComputerSchere.UriSource = new Uri("Schere.gif", UriKind.Relative);
                    ComputerSchere.EndInit();
                    IMG_Computer.Source = ComputerSchere;
                    MessageBox.Show("Verloren!", "Spielergebnis:");
                    score[1] = score[1] + 1;
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
                case 2:
                    //Papier
                    BitmapImage ComputerPapier = new BitmapImage();
                    ComputerPapier.BeginInit();
                    ComputerPapier.UriSource = new Uri("Papier.jpg", UriKind.Relative);
                    ComputerPapier.EndInit();
                    IMG_Computer.Source = ComputerPapier;
                    MessageBox.Show("Gleichstand!", "Spielergebnis:");
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
                case 3:
                    //Stein
                    BitmapImage ComputerStein = new BitmapImage();
                    ComputerStein.BeginInit();
                    ComputerStein.UriSource = new Uri("Stein.jpg", UriKind.Relative);
                    ComputerStein.EndInit();
                    IMG_Computer.Source = ComputerStein;
                    MessageBox.Show("Gewonnen!", "Spielergebnis:");
                    score[0] = score[0] + 1;
                    LBL_Player_Score.Content = score[0];
                    LBL_Computer_Score.Content = score[1];
                    break;
            }
        }

        private void Neues_Spiel_Click(object sender, RoutedEventArgs e)
        {
            score = new int[2] { 0, 0 };
            IMG_Computer.Source = null;
            IMG_Player.Source = null;
            LBL_Player_Score.Content = score[0];
            LBL_Computer_Score.Content= score[1];
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sergio Inga (Eckert-Schulen, ITFA1, 2023)", "Copyright by:");
        }
    }
}
