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

namespace Bowling_Statistics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //For Total
            double total = 0;
            total = (int)(Convert.ToInt64(Game1Box.Text) + Convert.ToInt64(Game2Box.Text) + Convert.ToInt64(Game3Box.Text));
            TotalBox.Text = "Total: " + Convert.ToString(total);

            //For Average
            double average = 0;
            average = (int)(Convert.ToInt64(Game1Box.Text) + Convert.ToInt64(Game2Box.Text) + Convert.ToInt64(Game3Box.Text)) / 3;
            AverageBox.Text = "Average: " + Convert.ToString(average);

            //For Handicap
            double handicap = 0;
            handicap = (200 - average) * 0.8;
            HandiCapBox.Text = "Handicap: " + Convert.ToString(handicap);

            //For High Game
            if(Game1Box.Text == Game2Box.Text)
            {
                HighGameBox.Text = "High Game: Tie";
            }
            else if (Game2Box.Text == Game3Box.Text)
            {
                HighGameBox.Text = "High Game: Tie";
            }
            else if (Game1Box.Text == Game3Box.Text)
            {
                HighGameBox.Text = "High Game: Tie";
            }
            else
            {
                if (Convert.ToDouble(Game1Box.Text) > Convert.ToDouble(Game2Box.Text))
                {
                    if (Convert.ToDouble(Game1Box.Text) > Convert.ToDouble(Game3Box.Text))
                    {
                        HighGameBox.Text = "High Game: 1";
                    }
                    else
                    {
                        HighGameBox.Text = "High Game: 3";
                    }
                }
                else if (Convert.ToDouble(Game2Box.Text) > Convert.ToDouble(Game3Box.Text))
                {
                    HighGameBox.Text = "High Game: 2";
                }
                else
                {
                    HighGameBox.Text = "High Game: 3";
                }
            }
        }
                

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NameBox.Text = "Name";
            Game1Box.Text = "0";
            Game2Box.Text = "0";
            Game3Box.Text = "0";

            TotalBox.Text = "Total:";
            AverageBox.Text = "Average:";
            HandiCapBox.Text = "Handicap:";
            HighGameBox.Text = "High Game:";

            if (MaleRadio.IsChecked == true)
            {
                MaleRadio.IsChecked = false;
            }

            if (FemaleRadio.IsChecked == true)
            {
                FemaleRadio.IsChecked = false;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MaleRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (FemaleRadio.IsChecked == true)
            {
                FemaleRadio.IsChecked = false;
            }
        }

        private void FemaleRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (MaleRadio.IsChecked == true)
            {
                MaleRadio.IsChecked = false;
            }
        }
    }
}
