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

        private SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

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
                command.CommandText = "Select * from Flight";
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridViewFlight.DataSource = dataTable;

                comboBoxFlightGeneral.DataSource = dataTable;
                comboBoxFlightGeneral.DisplayMember = "FlighNumber";
                comboBoxFlightGeneral.ValueMember = "Id";   

                comboBoxAirPlaneType.DataSource = dataTable;
                comboBoxAirPlaneType.DisplayMember = "AirPlaneTyple";
                comboBoxAirPlaneType.ValueMember = "Id";

                comboBoxFlightNumberUsers.DataSource = dataTable;
                comboBoxFlightNumberUsers.DisplayMember = "FlighNumber";
                comboBoxFlightNumberUsers.ValueMember = "Id";


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

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataFlight();

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }
    }
}
