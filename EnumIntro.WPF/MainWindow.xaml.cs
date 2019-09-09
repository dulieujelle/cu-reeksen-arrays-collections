using System.Windows;

namespace EnumIntro.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Seizoen { Herfst, Winter, Lente, Zomer }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnToonEnumWaarde_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Seizoen.Zomer.ToString());
        }
    }
}
