using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dictionary<string, string> _telefonbuch = new()
        {
            {"Max", "+43 664 1234567" },
            {"Lisa", "+43 664 7654321" },
            {"Emma", "+43 664 9876543" }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PhoneDisplay(object sender, RoutedEventArgs e)
        {
            phoneDisplayText.Text = string.Empty; 
            foreach (var item in _telefonbuch)
            {
                phoneDisplayText.Text += $"{item.Key} -> {item.Value}\n";
                phoneCount.Text = $"Count: {_telefonbuch.Count}";
            }
        }

        private void PhoneSearch(object sender, RoutedEventArgs e)
        {
            phoneDisplayText.Text = string.Empty;
            phoneCount.Text = string.Empty;
            string searchUser = searchBox.Text.Trim();

            if (_telefonbuch.ContainsKey(searchUser))
            {
                string phoneNumber = _telefonbuch[searchUser];
                phoneDisplayText.Text = $"{searchUser} -> {phoneNumber}";
            }
            else
            {
                phoneDisplayText.Text = $"Kein Eintrag für {searchUser} gefunden.";
            }
            searchBox.Clear();
        }

        private void PhoneAdd(object sender, RoutedEventArgs e)
        {
            phoneDisplayText.Text = string.Empty;
            phoneCount.Text = string.Empty;
            string name = phoneNameInput.Text.Trim();
            string number = phoneNumberInput.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                phoneDisplayText.Text = "Bitte sowohl Namen als auch Telefonnummer eingeben.";
                return;
            }

            if (_telefonbuch.ContainsKey(name))
            {
                phoneDisplayText.Text = $"Eintrag für {name} existiert bereits.";
            }
            else
            {
                _telefonbuch.Add(name, number);
                phoneDisplayText.Text = $"Eintrag hinzugefügt-> \n {name} → {number}";
            }

            phoneNameInput.Clear();
            phoneNumberInput.Clear();
        }

        private void PhoneDelete(object sender, RoutedEventArgs e)
        {
            phoneCount.Text = string.Empty;
            _telefonbuch.Clear();
            phoneDisplayText.Text = "Telefonbuch wurde geleert.";
        }
    }
}