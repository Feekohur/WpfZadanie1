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

namespace WpfZadanie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maszyna maszyna;
        public MainWindow()
        {
            InitializeComponent();
            maszyna = new Maszyna();
        }

        private void Wrzuc_Click(object sender, RoutedEventArgs e)
        {
            if (Tekst.Text == "")
            {
                MessageBox.Show("Nie można dodać pustego napisu!");
                Wynik.Content = "Wystąpił błąd!\n";
                Wynik.Content += "Metoda: Wrzuc()\n";
                Wynik.Content += maszyna.Zawartosc();
            }
            else
            {
                maszyna.Dodaj(Tekst.Text);
                Wynik.Content = "Dodano napis: " + Tekst.Text +"\n";
                Wynik.Content += "Metoda: Wrzuc()\n";
                Wynik.Content += maszyna.Zawartosc();
            }
            
        }

        private void Wyjmij_Click(object sender, RoutedEventArgs e)
        {
            if (maszyna.CzySaKupony())
            {
                string element = maszyna.Losuj();
                Wynik.Content = "Wylosowany napis: " + element + "\n";
                Wynik.Content += "Metoda: Wyjmij()\n";
                Wynik.Content += maszyna.Zawartosc();
            }
            else
            {
                MessageBox.Show("Nie ma elementów w maszynie!");
                Wynik.Content = "Wystąpił błąd!\n";
                Wynik.Content += "Metoda: Wyjmij()\n";
                Wynik.Content += maszyna.Zawartosc();
            }
            
        }

    }
}
