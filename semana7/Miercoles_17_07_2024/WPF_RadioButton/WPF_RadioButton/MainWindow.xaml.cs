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

namespace WPF_RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void radioButtonRojo_Click(object sender, RoutedEventArgs e)
        {
            elipseRoja.Visibility = Visibility.Visible;
            elipseAmarilla.Visibility = Visibility.Hidden;
            elipseVerde.Visibility = Visibility.Hidden;
        }

        private void radioButtonAmarillo_Click(object sender, RoutedEventArgs e)
        {
            elipseRoja.Visibility = Visibility.Hidden;
            elipseAmarilla.Visibility = Visibility.Visible;
            elipseVerde.Visibility = Visibility.Hidden;
        }

        private void radioButtonVerde_Click(object sender, RoutedEventArgs e)
        {
            elipseRoja.Visibility = Visibility.Hidden;
            elipseAmarilla.Visibility = Visibility.Hidden;
            elipseVerde.Visibility = Visibility.Visible;
        }
    }
}