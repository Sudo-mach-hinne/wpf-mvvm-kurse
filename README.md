# WPF MVVM Kurse

Lernprojekt aus der Umschulung zur Fachinformatikerin für Anwendungsentwicklung (FIAE).
Eine WPF-Anwendung nach dem MVVM-Muster zur Verwaltung von Kursen.

## Funktionen

- Anzeige aller Kurse in einer ListView
- Auswahl eines Kurses und Bearbeitung von Titel und Preis (Übernahme per Enter-Taste)
- Kategorie-Auswahl über eine ComboBox
- Zuweisung eines Dozenten (Vor- und Nachname) über eine ComboBox
- Löschen eines Kurses mit Bestätigungsdialog

## Verwendete Techniken

- WPF (XAML)
- MVVM-Muster (Model, View, ViewModel)
- Databinding
- ObservableCollection
- INotifyPropertyChanged

## Projektaufbau

| Schicht    | Datei / Klasse            | Aufgabe                                  |
|------------|---------------------------|------------------------------------------|
| Model      | `Kurs.cs`, `Dozent.cs`    | Daten und Datenstruktur                  |
| View       | `MainWindow.xaml`         | Oberfläche, Anzeige und Eingabe          |
| ViewModel  | `ViewModel.cs`            | Vermittlung zwischen Model und View      |

## Voraussetzungen

- Visual Studio 2022
- .NET (WPF)

## Lernziel

Einstieg in das MVVM-Muster mit Fokus auf Datenbindung, ObservableCollection und
INotifyPropertyChanged.
