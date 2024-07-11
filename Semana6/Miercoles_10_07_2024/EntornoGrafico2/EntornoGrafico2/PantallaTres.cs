using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntornoGrafico2
{
    public partial class PantallaTres : Form
    {
        private List<Persona> listPersonas;
        public PantallaTres()
        {
            InitializeComponent();
            listPersonas = new List<Persona>();
        }

        public List<Persona> ListPersonas
        {
            get { return listPersonas; }
            set { listPersonas = value; }
        }

        private void PantallaTres_Load(object sender, EventArgs e)
        {
            int fila = dataGridView1.Rows.Add();

            foreach (Persona personita in listPersonas)
            {
                dataGridView1.Rows[fila].Cells[0].Value = personita.Nombre;
                dataGridView1.Rows[fila].Cells[1].Value = personita.Apellido;
                dataGridView1.Rows[fila].Cells[2].Value = personita.Edad;
                dataGridView1.Rows[fila].Cells[3].Value = personita.Direccion;
                dataGridView1.Rows[fila].Cells[4].Value = personita.Genero;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
