using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Dictionary<string, string> _telefonbuch = new()
        {
            {"Pony", "+233 663 213123" },
            {"Adam", "+4213 661 2713818" },
            {"Zov", "+41343 662 21301231" }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TelefonbuchAnzeigen(object sender, RoutedEventArgs e)
        {
            nummerText.Text = string.Empty;
            foreach (var user in _telefonbuch)
            {
                nummerText.Text += $"{user.Key} >>> {user.Value}\n";
                zähler.Text = $"Einträge >{_telefonbuch.Count}";
            }
        }

        private void TelefonbuchSuche(object sender, RoutedEventArgs e)
        {
            nummerText.Text = string.Empty;
            zähler.Text = string.Empty;
            string sucheUser = suchBox.Text.Trim();

            if (_telefonbuch.ContainsKey(sucheUser))
            {
                string telefonNummer = _telefonbuch[sucheUser];
                nummerText.Text = $"{sucheUser} >>> {telefonNummer}";
            }
            else
            {
                nummerText.Text = $"{sucheUser} nicht gefunden.";
            }
            suchBox.Clear();
        }

        private void TelefonbuchHinzufuegen(object sender, RoutedEventArgs e)
        {
            nummerText.Text = string.Empty;
            zähler.Text = string.Empty;
            string name = telefonbuchNameInput.Text.Trim();
            string number = phoneNumberInput.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                nummerText.Text = "Bitte Name und Telefonnummer eingeben";
                return;
            }

            if (_telefonbuch.ContainsKey(name))
            {
                nummerText.Text = $"{name} existiert schon";
            }
            else
            {
                _telefonbuch.Add(name, number);
                nummerText.Text = $"{name} → {number}\nAdded";
            }

            telefonbuchNameInput.Clear();
            phoneNumberInput.Clear();
        }

        private void TelefonbuchLöschen(object sender, RoutedEventArgs e)
        {
            zähler.Text = string.Empty;
            _telefonbuch.Clear();
            nummerText.Text = "Telefonbuch wurde geleert.";
        }
    }
}