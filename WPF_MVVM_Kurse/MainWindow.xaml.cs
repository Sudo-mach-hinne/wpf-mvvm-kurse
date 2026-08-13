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

namespace WPF_MVVM_Kurse
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Wir erstellen ein neues Objekt vom Typ ViewModel
        ViewModel model = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();

            //Wir weisen das Viewmodel als Datenquelle dem Layout zu
            this.DataContext = model;
        }

        private void txtTitel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                model.Wahl.Titel = txtTitel.Text;
            }
        }

        private void txtPreis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (double.TryParse(txtPreis.Text, out double preis))
                {
                    model.Wahl.Preis = preis;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Messagebox für die Bestätigung
            MessageBoxResult result = MessageBox.Show("Wollen Sie wirklich löschen?", "Hinweis", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                model.Liste.Remove(model.Wahl);
            }
        }
    }
}