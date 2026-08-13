using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Kurse
{
    //enthält alle Daten, die in der Anzeige verwendet werden (namentlich)
    //WICHTIG: Der View reagiert selbstständig, wenn sich die Daten hier ändern
    internal class ViewModel
    {
        //Der Typ für die Erstellung einer Liste enthält die Möglichkeit
        // auf die Ereignisse Add() und Remove() zu reagieren
        //das funktioniert im Hintergrund
        //dieser View erkennt den Typ und legt selber fest, wie er bei Add() und Remove() reagieren möchte
        public ObservableCollection<Kurs> Liste { get; set; }

        //get: ich zeige den ausgewählten Kurs in der Liste an
        //set: wenn der User einen anderen Kurs auswählt, dann ändert sich die Wahl
        //Ich möchte den ausgewählten Kus separat anzeigen lassen
        public Kurs Wahl { get; set; }

        //die Auswahlmöglichkeiten für die Kategorie in der ComboBox
        public ObservableCollection<string> Kategorien { get; set; }
        public ObservableCollection<Dozent> Dozentenliste { get; set; }

        public ViewModel()
        {
            Liste = new ObservableCollection<Kurs>();
            Liste.Add(new Kurs { Titel = "Prog CS", Kategorie = "IT", Preis = 499.99 });
            Liste.Add(new Kurs { Titel = "Kochen mit Jochen", Kategorie = "Haushalt", Preis = 150.99 });

            Kategorien = new ObservableCollection<string> { "IT", "Haushalt", "Tiere", "Sprachen", "Kochen" };

            Dozentenliste = new ObservableCollection<Dozent>();
            Dozentenliste.Add(new Dozent { Nachname = "Rochen", Vorname = "Jochen"});
            Dozentenliste.Add(new Dozent { Nachname = "Byte", Vorname = "Veit"});
        }

    }
}