using System.Windows;

namespace Windrichtingen.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum WindRichting { Oost, Zuid, Noord, West };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnToonVoorspelling_Click(object sender, RoutedEventArgs e)
        {
            int huidigeWindNr = (int)WindRichting.Oost;
            string huidigeWind = WindRichting.Oost.ToString();
            lblVoorspelling.Content = "Huidige wind = " + huidigeWind + " (nr. " + huidigeWindNr + ")\n";

            int windVoorMorgenNr = (int)WindRichting.West;
            string windVoorMorgen = WindRichting.West.ToString();
            lblVoorspelling.Content += "Wind voor morgen = " + windVoorMorgen + " (nr. " + windVoorMorgenNr + ")\n";

            WindRichting richtingNul = (WindRichting)0;
            lblVoorspelling.Content += "Wind met index 0 = " + richtingNul.ToString();
        }
    }
}
