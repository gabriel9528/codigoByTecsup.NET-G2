using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModeloDesconectadoUsingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private List<string> listAircrafts = new List<string>();

        DataSet1 dataSet1 = new DataSet1();

        //*-----------------------------------Flights-----------------------------------*//
        DataSet1TableAdapters.FlightsTableAdapter flightsTableAdapter = 
            new DataSet1TableAdapters.FlightsTableAdapter();

        DataSet1.FlightsDataTable flightsDataTable =
            new DataSet1.FlightsDataTable();

        //*-----------------------------------Users-----------------------------------*//
        DataSet1TableAdapters.UsersTableAdapter usersTableAdapter =
            new DataSet1TableAdapters.UsersTableAdapter();

        DataSet1.UsersDataTable usersDataTable =
            new DataSet1.UsersDataTable();

        public MainWindow()
        {
            InitializeComponent();
            listAircrafts.Clear();
            listAircrafts.Add("Boeing 737");
            listAircrafts.Add("Boeing 747");
            listAircrafts.Add("Boeing 757");
            listAircrafts.Add("Boeing 767");
            listAircrafts.Add("Boeing 777");
            listAircrafts.Add("Airbus 120");
            listAircrafts.Add("Airbus 900");
            listAircrafts.Add("Airbus 1000");

            comboBoxAircraft.ItemsSource = listAircrafts;
            RefreshDataGridFlights();
        }

        private void RefreshDataGridFlights()
        {
            flightsTableAdapter.Fill(dataSet1.Flights);

            flightsTableAdapter.Fill(flightsDataTable);

            dataGridFlights.ItemsSource = flightsDataTable;

            comboBoxFlights.ItemsSource = flightsDataTable;
            comboBoxFlights.DisplayMemberPath = "FlightNumber";
            comboBoxFlights.SelectedValuePath = "Id";

            comboBoxNextFlight.ItemsSource = flightsDataTable;
            comboBoxNextFlight.DisplayMemberPath = "FlightNumber";
            comboBoxNextFlight.SelectedValuePath = "Id";
        }

        private void comboBoxFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
