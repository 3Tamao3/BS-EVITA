using System.Printing;
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

namespace _1USAWPF
{
    public partial class MainWindow : Window
    {
        //Konstruktor | info für mich
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<double> _zahlen = new List<double>();
        private double _mitZaehlerSumme = 0;
        private double _mitZaehlerMittelwert = 0;

        private void LiterBerechnen(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput.Text = "";
                double liter = Convert.ToDouble(LiterInput.Text);
                double preis = Convert.ToDouble(PreisProLiter.Text);
                double netto = liter * preis;
                double mwst = netto * 0.2;
                double gesamtkosten = netto + mwst;

                GesamtkostenOutput.Text = gesamtkosten.ToString("F2");
                NettoOutput.Text = netto.ToString("F2");
                MwstOutput.Text = mwst.ToString("F2");
                LiterInput.Clear();
                PreisProLiter.Clear();
            }
            catch
            {
                ErrorOutput.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }

        private void RechteckBerechnen(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput1.Text = "";
                double rechteckA = Convert.ToInt32(InputA.Text);
                double rechteckB = Convert.ToInt32(InputB.Text);

                ABoxOutput.Text = InputA.Text;
                BBoxOutput.Text = InputB.Text;

                double rechteckErgebnis = Math.Sqrt(rechteckA * rechteckA + rechteckB * rechteckB);
                RechteckOutput.Text = rechteckErgebnis.ToString("F2");
                DBoxOutput.Text = RechteckOutput.Text;
                InputA.Clear();
                InputB.Clear();
            }
            catch
            {
                ErrorOutput1.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }

        private void WarenwertBerechnen(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput2.Text = "";
                double warenwert = Convert.ToDouble(WarenwertInput.Text);
                double mwst;
                double warenwertErgebnis;

                if (warenwert >= 500)
                {
                    double rabattBetrag = warenwert * 0.05;
                    mwst = (warenwert * 0.95) * 0.2;
                    warenwertErgebnis = (warenwert - rabattBetrag) + mwst;

                    RabattOutput.Text = $"5% Rabatt angewendet (-{rabattBetrag}€ von {warenwert}€)";
                    MwstOutput2.Text = mwst.ToString("F2");
                    ErgebnisOutput.Text = warenwertErgebnis.ToString("F2");
                }
                else
                {
                    mwst = warenwert * 0.2;
                    RabattOutput.Text = "";
                    warenwertErgebnis = warenwert + mwst;
                    MwstOutput2.Text = mwst.ToString("F2");
                    ErgebnisOutput.Text = warenwertErgebnis.ToString("F2");
                }
            }
            catch
            {
                ErrorOutput2.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }

        private void EuklidischeBerechnen(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput3.Text = "";
                double a = Convert.ToDouble(EuklidischeInputA.Text);
                double b = Convert.ToDouble(EuklidischeInputB.Text);
                double r;
                double originalA = a;
                double originalB = b;
                while (b != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }

                double kgv = (originalA * originalB) / a;

                EuklidischeOutput.Text = kgv.ToString("F2");
                EuklidischeInputA.Clear();
                EuklidischeInputB.Clear();
            }
            catch
            {
                ErrorOutput3.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }
        private void QuadratZahlButton(object sender, RoutedEventArgs e)
        {
            string output = "";
            for (int i = 1; i < 11; i++)
            {
                int quadrat = i * i;
                output += i + " -> " + quadrat + " \n";
            }
            QuadratZahlenOutput.Text = output;
        }
        private void HirschButton(object sender, RoutedEventArgs e)
        {
            string output = "";
            double hirsche = 300;
            int newLineCount = 0;
            for (int i = 2025; i <= 2040; i++)
            {
                hirsche = (hirsche * 1.06) - 20;
                output += $"| {i} -> {hirsche:F0} Hirsche | ";
                newLineCount++;
                if (newLineCount % 2 == 0)
                {
                    output += "\n";
                }
            }
            HirschOutput.Text = output;
        }
        private void ZinsenButton(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput4.Text = "";
                string output = "";
                double kapital = Convert.ToDouble(KapitalInput.Text);
                double zinsen = Convert.ToDouble(ZinsenInput.Text) / 100;
                for (int jahr = 2025; jahr < 2034; jahr++)
                {
                    kapital = kapital * (1 + zinsen);
                    output += $"{jahr} = {kapital:F2}€ ({zinsen * 100:F0}%)\n";
                }
                ZinsenOutput.Text = output;
                KapitalInput.Clear();
                ZinsenInput.Clear();
            }
            catch
            {
                ErrorOutput4.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }
        private void BauernhofAnzeigen(object sender, RoutedEventArgs e)
        {
            int tiere = 0;
            int kuehe = 0;
            int schafe = 0;
            int ziegen = 8;
            schafe = ziegen * 2;
            kuehe = schafe + 5;
            tiere = kuehe + ziegen + schafe;
            BauernhofOutput.Text = $"{kuehe} Kühe\n+\n{schafe} Schafe\n+\n{ziegen} Ziegen\n=\n{tiere} Tiere";
        }
        private void UmfangUndFlaecheAusrechnen(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput5.Text = "";
                double radius = Convert.ToDouble(RadiusInput.Text);
                double umfang = radius * 3.14 * 2;
                double flaeche = 3.14 * radius * radius;
                UmfangOutput.Text = umfang.ToString("F2");
                UCircleOutput.Text = UmfangOutput.Text;
                FlaecheOutput.Text = flaeche.ToString("F2");
                ACircleOutput.Text = FlaecheOutput.Text;
                RadiusInput.Clear();
            }
            catch
            {
                ErrorOutput5.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }
        private void SummeUndMittelwertButton(object sender, RoutedEventArgs e)
        {
            try
            {
                ErrorOutput6.Text = "";
                double eingabeZahl = Convert.ToDouble(ZahlInput.Text);
                if (eingabeZahl < 0)
                {
                    double summe = _zahlen.Sum();
                    double mittelwert = summe / _zahlen.Count;
                    SummeOutput.Text = summe.ToString();
                    MittelwertOutput.Text = mittelwert.ToString();
                    _zahlen.Clear();
                    _mitZaehlerSumme = 0;
                    _mitZaehlerMittelwert = 0;
                }
                _mitZaehlerSumme += eingabeZahl;
                _mitZaehlerMittelwert += 1;
                _zahlen.Add(eingabeZahl);
                ZahlenListeOutput.Text = string.Join(", ", _zahlen);
                MitZaehlerSummeOutput.Text = _mitZaehlerSumme.ToString();
                MitZaehlerMittelwerOutput.Text = _mitZaehlerMittelwert.ToString();
            }
            catch
            {
                ErrorOutput6.Text = $"YOOOOOO das kannst du nicht machen";
            }
        }
        private void DameBrettAnzeige(object sender, RoutedEventArgs e)
        {
            string output = "";
            for (int i = 1; i < 9; i++)
            {
                for (int j = 65; j < 73; j++)
                {
                    output += $"{i}{(char)j} ";
                }
                output += "\n";
            }
            DameBrettOutput.Text = output;
        }
    }
}