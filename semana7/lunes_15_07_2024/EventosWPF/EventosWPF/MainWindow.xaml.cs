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

namespace EventosWPF
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

        private void buton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Button 1");
        }

        private void buton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Button 2");
        }

        private void buton3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Button 3");
        }

        //private void Panel_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Soy Panel");
        //}

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Soy Panel");
        }
    }
}