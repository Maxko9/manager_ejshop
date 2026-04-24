using System.Collections.ObjectModel;
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

namespace manžer_ejshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Produkt> Sklad = new ObservableCollection<Produkt>();

        public MainWindow()
        {
            InitializeComponent();
            Sklad.Add(new Produkt(20, "Brumík", 50));
            Sklad.Add(new Produkt(30, "Kofola", 100));
            Sklad.Add(new Produkt(20, "Vinea", 37));
            Sklad.Add(new Produkt(3, "Rohlajz", 500));
            Sklad.Add(new Produkt(20, "Šunka", 100));
            Sklad.Add(new Produkt(40, "Máslo", 25));

            dgSklad.ItemsSource = Sklad;
            lblProduktyNaProdej.ItemsSource = Sklad;
        }

        //tlacitko pridat do skladu
        private void btnPridatDoSkladu_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNovyProduktName.Text) && double.TryParse(txtNovyProduktCena.Text, out double cena) && int.TryParse(txtNovyProduktMnozstvi.Text, out int mnozstvi))
            {
                Sklad.Add(new Produkt(cena, txtNovyProduktName.Text, mnozstvi));
                txtNovyProduktName.Clear();
                txtNovyProduktCena.Clear();
                txtNovyProduktMnozstvi.Clear();
            }
            else
            {
                MessageBox.Show("Zadejte správné jméno, cenu a množství zboží");
            }
        }
    }
}       