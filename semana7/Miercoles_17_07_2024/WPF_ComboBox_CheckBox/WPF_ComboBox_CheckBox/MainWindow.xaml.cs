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

namespace WPF_ComboBox_CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> listaCapitales = new List<Capitales>();
            listaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            listaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            listaCapitales.Add(new Capitales { NombreCapital = "Buenos Aires" });
            listaCapitales.Add(new Capitales { NombreCapital = "Bogota" });
            listaCapitales.Add(new Capitales { NombreCapital = "Quito" });

            Capitales.ItemsSource = listaCapitales;
        }

        private void TodasCapitales_Checked(object sender, RoutedEventArgs e)
        {
            Lima.IsChecked = true;
            Madrid.IsChecked = true;
            BuenosAires.IsChecked = true;
            Bogota.IsChecked = true;
            Quito.IsChecked = true;
        }

        private void TodasCapitales_Unchecked(object sender, RoutedEventArgs e)
        {
            Lima.IsChecked = false;
            Madrid.IsChecked = false;
            BuenosAires.IsChecked = false;
            Bogota.IsChecked = false;
            Quito.IsChecked = false;
        }


        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if(Lima.IsChecked == true && Madrid.IsChecked == true && BuenosAires.IsChecked == true && Bogota.IsChecked == true && Quito.IsChecked == true)
            {
                TodasCapitales.IsChecked = true;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }
        }

        private void Individual_UnChecked(object sender, RoutedEventArgs e)
        {
            if (Lima.IsChecked == false && Madrid.IsChecked == false && BuenosAires.IsChecked == false && Bogota.IsChecked == false && Quito.IsChecked == false)
            {
                TodasCapitales.IsChecked = false;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }
        }
    }
}