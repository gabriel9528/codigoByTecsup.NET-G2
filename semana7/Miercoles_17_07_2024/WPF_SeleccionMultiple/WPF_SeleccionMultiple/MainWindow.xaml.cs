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

namespace WPF_SeleccionMultiple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblaciones> listaPoblaciones = new List<Poblaciones>
            {
                new Poblaciones { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 27, Temperatura2 = 25 },
                new Poblaciones { Poblacion1 = "Sevilla", Poblacion2 = "Valencia", Temperatura1 = 37, Temperatura2 = 30 },
                new Poblaciones { Poblacion1 = "Bilbao", Poblacion2 = "Santander", Temperatura1 = 30, Temperatura2 = 15 },
                new Poblaciones { Poblacion1 = "Zaragoza", Poblacion2 = "Teruel", Temperatura1 = 25, Temperatura2 = 16 }
            };
            ListBoxPoblaciones.ItemsSource = listaPoblaciones;
        }



        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListBoxPoblaciones.SelectedItem != null)
            {
                var seleccion = ListBoxPoblaciones.SelectedItem as Poblaciones;
                if (seleccion != null)
                {
                    MessageBox.Show(
                        $"{seleccion.Poblacion1} {seleccion.Temperatura1} °C, " +
                        $"{seleccion.Poblacion2} {seleccion.Temperatura2} °C, " +
                        $"Diferencia de temperatura: {seleccion.DiferenciaTemperatura} °C"
                        );
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna población");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ListBoxPoblaciones.SelectedItem != null)
            {
                var seleccion = ListBoxPoblaciones.SelectedItem as Poblaciones;
                if(seleccion != null)
                {
                    MessageBox.Show(
                        $"{seleccion.Poblacion1} {seleccion.Temperatura1} °C, " +
                        $"{seleccion.Poblacion2} {seleccion.Temperatura2} °C, " +
                        $"Diferencia de temperatura: {seleccion.DiferenciaTemperatura} °C"
                        );
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna población");
            }
        }
    }
}