using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Kurse
{
    //die Klasse implementiert eine Interface
    //das Interface gibt vor, welches Ereignis die Klasse definieren muss
    //dieses Ereignis wird vom View für Reaktion und Änderungen verwendet
    internal class Kurs:INotifyPropertyChanged

    {
        private string _titel;
        public string Titel
        {
            get
            {
                return _titel;
            }
        
            set
            {
                _titel = value;
                //wir führen die Methode aus, die vom interface kommt
                // weil die Eigenschaft mit set geändert wurde
                // ? -- wurde eine Methode hinterlegt, Invoke -- wenn ja, ausführen
                //Übergabe: 1. bei DIESEM Objekt wurde etwas geändert
                //Übergabe: 2. es wurde die Eigenschaft Titel geändert
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Titel)));
            }
                
        }
        private string _kategorie;
        public string Kategorie
        {
            get { return _kategorie; }
            set
            {
                _kategorie = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Kategorie)));
            }
        }

        private double _preis;
        public double Preis
        {
            get { return _preis; }
            set
            {
                _preis = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Preis)));
            }
        }

        private Dozent _dozent;
        public Dozent Dozent
        {
            get { return _dozent; }
            set
            {
                _dozent = value;
                //wir führen die Methode aus, die vom interface kommt
                // weil die Eigenschaft mit set geändert wurde
                // ? -- wurde eine Methode hinterlegt, Invoke -- wenn ja, ausführen
                //Übergabe: 1. bei DIESEM Objekt wurde etwas geändert
                //Übergabe: 2. es wurde die Eigenschaft Titel geändert
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dozent)));
            }
        }

        //PropertyChangedEventHandler ist der Delegat (welche Übergabe und Rückgabe muss eine Methode haben.)
        //PropertyChanged ist die Referenz auf eine Methode
        //Die Methode wird intern definiert vom MainWindow / View
        // wir legen fest, wann die Methode ausgeführt werden soll
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
