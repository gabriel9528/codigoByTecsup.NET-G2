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
    public partial class PantallaDos : Form
    {
        private Persona persona;
        public PantallaDos()
        {
            InitializeComponent();
            persona = new Persona();
        }

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        private void PantallaDos_Load(object sender, EventArgs e)
        {
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelEdad.Text = Convert.ToString(persona.Edad);
            labelDireccion.Text = persona.Direccion;
            labelGenero.Text = persona.Genero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
