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
        public MainWindow(){
                    
            InitializeComponent();
        }
            
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string vstup1 = txtCislo1.Text;
            string vstup2 = txtCislo2.Text;
            string vstup3 = txtCislo3.Text;

            double cislo1, cislo2, cislo3;
            if (!double.TryParse(vstup1, out cislo1))
            {
                //parsování neuspělo
                txtVystup.Text = "Neplatný vstup!";
            }
            else if (!double.TryParse(vstup2, out cislo2))
            {
                //parsování neuspělo
                txtVystup.Text = "Neplatný vstup!";
            }
            else if (!double.TryParse(vstup3, out cislo3))
            {
                //parsování neuspělo
                txtVystup.Text = "Neplatný vstup!";
            } else if (cislo2 > 12 || cislo1 > 31 )
            {
                txtVystup.Text = "Neplatne datum!";
            }
            else if (cislo3 < 2026)
            {
                txtVystup.Text = "Nevyšlo";
            }
            else if (cislo3 >= 2026)
            {
                txtVystup.Text = "Vyšlo";
            }
            else if (cislo2 < 11)
            {
                txtVystup.Text = "Nevyšlo";
            }
            else if (cislo2 >= 11)
            {
                txtVystup.Text = "Vyšlo";
            }
            else if (cislo1 < 19)
            {
                txtVystup.Text = "Nevyšlo";
            }
            else if (cislo1 >= 19)
            {
                txtVystup.Text = "Vyšlo";
            }
        }
    }
}