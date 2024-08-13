using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeloConectadoWindowsForms
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection();
        private string connectionString = @"Data Source=DESKTOP-K0JSV0G\SQLEXPRESS;
                                    Initial Catalog=modeloConectadoWindowsForms;
                                    Integrated Security=True";

        private SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataFlight();
            RefreshDataUsers();
            RefreshDataFlightAirPlaneType();

        }


        #region Flight
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void RefreshDataFlight()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-K0JSV0G\SQLEXPRESS;
                                    Initial Catalog=modeloConectadoWindowsForms;
                                    Integrated Security=True");

            command = connection.CreateCommand();
            try
            {
                connection.Open();

                // DataTable para el comboBoxFlightGeneral
                command = connection.CreateCommand();
                command.CommandText = "Select * from Flight";
                SqlDataReader readerFlight = command.ExecuteReader();
                DataTable dataTableFlight = new DataTable();
                dataTableFlight.Load(readerFlight);

                dataGridViewFlight.DataSource = dataTableFlight;

                comboBoxFlightGeneral.DataSource = dataTableFlight;
                comboBoxFlightGeneral.DisplayMember = "FlighNumber";
                comboBoxFlightGeneral.ValueMember = "Id";

                comboBoxFlightNumberUsers.DataSource = dataTableFlight;
                comboBoxFlightNumberUsers.DisplayMember = "FlighNumber";
                comboBoxFlightNumberUsers.ValueMember = "Id";

                

                readerFlight.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void RefreshDataFlightAirPlaneType()
        {
            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();

            try
            {
                connection.Open();

                // DataTable para el comboBoxFlightGeneral
                command = connection.CreateCommand();
                command.CommandText = "Select * from Flight";
                SqlDataReader readerFlight = command.ExecuteReader();
                DataTable dataTableFlight = new DataTable();
                dataTableFlight.Load(readerFlight);

                dataGridViewFlight.DataSource = dataTableFlight;

                comboBoxAirPlaneType.DataSource = dataTableFlight;
                comboBoxAirPlaneType.DisplayMember = "AirPlaneTyple";
                comboBoxAirPlaneType.ValueMember = "Id";

                readerFlight.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            string airline = textBoxAirline.Text;
            string flightNumber = textBoxFlightNumber.Text;
            string destination = textBoxDestination.Text;
            //string airPlaneType = comboBoxAirPlaneType.SelectedItem.ToString();
            string airPlaneType = string.Empty;
            DataRowView selectedRow = (DataRowView)comboBoxAirPlaneType.SelectedItem;
            if(selectedRow != null)
            {
                airPlaneType = selectedRow["AirPlaneTyple"].ToString();
            }

            if(string.IsNullOrEmpty(airline) || string.IsNullOrEmpty(flightNumber) 
                || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(airPlaneType))
            {
                MessageBox.Show("Es necesario completar todos los campos");
                return;
            }

            connection.ConnectionString = connectionString;
            command = new SqlCommand("Insert into Flight(Airline, FlighNumber, Destination, AirPlaneTyple)" +
                "values(@Airline, @FlightNumber, @Destination, @AirplaneType)", connection);

            command.Parameters.AddWithValue("@Airline", airline);
            command.Parameters.AddWithValue(@"FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@AirplaneType", airPlaneType);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo registrado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }

        }

        private bool isAirPlaneTypeSelectionChanging = false;

        private void comboBoxFlightGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isAirPlaneTypeSelectionChanging)
            {
                DataRowView selectedRow = (DataRowView)comboBoxFlightGeneral.SelectedItem;
                if (selectedRow != null)
                {
                    int selectedFlighById = Convert.ToInt32(selectedRow["Id"]);
                    if (selectedFlighById > 0)
                    {
                        LoadFlightDetails(selectedFlighById);

                        string airPlaneType = selectedRow["AirPlaneTyple"].ToString();

                        // Buscar el índice en comboBoxAirPlaneType que coincida con el valor de airPlaneType
                        for (int i = 0; i < comboBoxAirPlaneType.Items.Count; i++)
                        {
                            DataRowView item = (DataRowView)comboBoxAirPlaneType.Items[i];
                            if (item["AirPlaneTyple"].ToString() == airPlaneType)
                            {
                                comboBoxAirPlaneType.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }
            }
        }


        private void comboBoxAirPlaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LoadFlightDetails(int id)
        {
            //Verificar y establecer la cadena de conexion
            if(connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = connectionString;
            }

            command = connection.CreateCommand();
            try
            {
                
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                
                string query = "Select * from Flight where Id = @FlightId";
                command.CommandText = query;
                command.Parameters.AddWithValue("@FlightId", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBoxAirline.Text = reader["Airline"].ToString();
                    textBoxFlightNumber.Text = reader["FlighNumber"].ToString();
                    textBoxDestination.Text = reader["Destination"].ToString();
                    comboBoxAirPlaneType.SelectedValue = reader["AirPlaneTyple"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void buttonUpdateFlight_Click(object sender, EventArgs e)
        {
            if(comboBoxFlightGeneral.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un vuelo para actualizar");
                return;
            }

            int id = Convert.ToInt32(comboBoxFlightGeneral.SelectedValue);
            string airline = textBoxAirline.Text;
            string flightNumber = textBoxFlightNumber.Text;
            string destination = textBoxDestination.Text;

            string airPlaneType = string.Empty;
            DataRowView selectedRow = (DataRowView)comboBoxAirPlaneType.SelectedItem;
            if (selectedRow != null)
            {
                airPlaneType = selectedRow["AirPlaneTyple"].ToString();
            }

            if (string.IsNullOrEmpty(airline) || string.IsNullOrEmpty(flightNumber)
                || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(airPlaneType))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
                return;
            }

            connection.ConnectionString = connectionString;
            command = new SqlCommand("Update Flight set Airline = @Airline, FlighNumber = @FlightNumber, " +
                "Destination = @Destination, AirplaneTyple = @AirplaneType where Id = @Id", connection);

            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Airline", airline);
            command.Parameters.AddWithValue(@"FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@AirplaneType", airPlaneType);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }
        }

        private void buttonDeleteFlight_Click(object sender, EventArgs e)
        {
            if(comboBoxFlightGeneral.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un vuelo para eliminar");
                return;
            }

            int id = (int)comboBoxFlightGeneral.SelectedValue;

            connection.ConnectionString = connectionString;
            command = new SqlCommand("Delete from Flight where Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo eliminado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }

        }

        #endregion

        #region Users

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void RefreshDataUsers()
        {
            connection.ConnectionString = connectionString;
            command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "Select * from Users";

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridViewUsers.DataSource = dataTable;

                    comboBoxUserGeneral.DataSource = dataTable;
                    comboBoxUserGeneral.DisplayMember = "Name";
                    comboBoxUserGeneral.ValueMember = "Id";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        #endregion

    }
}
