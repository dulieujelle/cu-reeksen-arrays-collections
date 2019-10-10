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

namespace _04_Lists
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

        private void BtnListKaapren_Click(object sender, RoutedEventArgs e)
        {
            string kaaprenVaarders;

            List<string> vaarders = new List<string>();
            vaarders.Add("Jan");
            vaarders.Add("Piet");
            vaarders.Add("Joris");
            vaarders.Add("Korneel");

            kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] + "\nDie hebben baarden, zij varen mee.";
            MessageBox.Show(kaaprenVaarders, "Niet gesorteerd");

            vaarders.Sort();
            kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] + "\nDie hebben baarden, zij varen mee.";
            MessageBox.Show(kaaprenVaarders, "Gesorteerd");

            vaarders.Add("Marieke");
            kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] + "\nDie hebben baarden, zij varen mee, behalve " + vaarders[4];
            MessageBox.Show(kaaprenVaarders, "en dan nog ... marieke");

            vaarders.Remove("Jan");
            kaaprenVaarders = vaarders[0] + ", " + vaarders[1] + ", " + vaarders[2] + " en " + vaarders[3] + "\nDie hebben baarden, zij varen mee."; MessageBox.Show(kaaprenVaarders, "Zonder jan");



        }

        private void BtnDictionary_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> vrienden = new Dictionary<string, int>();

            vrienden.Add("Emmanuel", 40);
            vrienden.Add("Angela", 42);
            vrienden.Add("Donald", 25);

            string output = "";
            output += "De leeftijd van Emmanuel is " + vrienden["Emmanuel"] + "\n";
            output += "De tweede vriend(in) in de rij is " + vrienden.Keys.ElementAt(1) + "\n";
            output += "De derde vriend is " + vrienden.Keys.ElementAt(2) + " en is " + vrienden.Values.ElementAt(2) + " jaar ";
            lblOutput.Content = output;
        }
    }
}
