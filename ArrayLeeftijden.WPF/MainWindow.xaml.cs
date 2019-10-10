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

namespace ArrayLeeftijden.WPF
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
        int[] leeftijden;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            leeftijden = new int[4] { 18, 63, 42, 7 };
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            string[] maand = new string[12];
            maand[0] = "januari";  //waarde toekennen 
            //MessageBox.Show(string.Format("De eerste maand is {0} ", maand[0]));  //waarde ophalen 
            MessageBox.Show("De eerste maand is " + maand[0]);
        }

        private void BtnArr0_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("De eerste leeftijd is " + leeftijden[0]);
        }

        private void BtnArr1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("De tweede leeftijd is " + leeftijden[1]);

        }

        private void BtnArr2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("De derde leeftijd is " + leeftijden[2]);

        }

        private void BtnArr3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("De vierd leeftijd is " + leeftijden[3]);

        }

        private void BtnKaaprenVaarders_Click(object sender, RoutedEventArgs e)
        {
            // een array uitbreiden kan niet
            // een array kopieren naar een andere wel, daarna kunnen we de originele array opnieuw instantieren

            // we maken de originele array aan : 
            string[] origineel = new string[3] { "jan", "piet", "joris" };
            PrintKaaprenVaarders(origineel);

            // we maken een nieuwe array aan en kopieren de eerste naar de tweede
            string[] kopie = new string[3];
            origineel.CopyTo(kopie, 0);  // 0 betekent hier, vanaf index 0 in de originele array
            Console.WriteLine("=========================");

            // we instantieren de originele opnieuw
            origineel = new string[4];
            // we kopieren de tweede terug naar de eerste
            kopie.CopyTo(origineel, 0);

            origineel[3] = "corneel";
            PrintKaaprenVaarders(origineel);

        }

        void PrintKaaprenVaarders(string[] vaarders)
        {
            foreach(string vaarder in vaarders)
            {
                Console.WriteLine(vaarder);
            }
        }

        private void Btn2dimenties_Click(object sender, RoutedEventArgs e)
        {
            string[,] fullnames = new string[3, 2];
            fullnames[0, 0] = "De Deurwaerder";
            fullnames[0, 1] = "Jan";
            fullnames[1, 0] = "Bonne";
            fullnames[1, 1] = "Ilse";
            fullnames[2, 0] = "Dobbelaere";
            fullnames[2, 1] = "Benthe";
            PrintFullNames(fullnames);
        }
        //void PrintFullNames(string[,] namen)
        //{
        //    foreach(string naam in namen)
        //    {
        //        Console.WriteLine(naam);
        //    }
        //}

        void PrintFullNames(string[,] namen)
        {
           for(int r = 0; r <= namen.GetUpperBound(0); r++)
            {
                Console.WriteLine("Naam nr " + r.ToString() + " is " + namen[r, 0] + " " + namen[r, 1]);
            }
        }
    }
}
