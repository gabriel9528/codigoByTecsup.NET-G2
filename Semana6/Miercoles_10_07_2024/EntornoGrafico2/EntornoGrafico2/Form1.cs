namespace EntornoGrafico2
{
    public partial class Form1 : Form
    {
        private ControladorPersona controladorPersona;
        private Persona persona;
        private List<Persona> listPersonas;
        public Form1()
        {
            InitializeComponent();
            controladorPersona = new ControladorPersona();
            persona = new Persona();
            listPersonas = new List<Persona>();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Persona newPersona = new Persona();
            newPersona.Nombre = textBoxNombre.Text;
            newPersona.Apellido = textBoxApellido.Text;
            newPersona.Edad = Convert.ToInt32(textBoxEdad.Text);
            newPersona.Direccion = textBoxDireccion.Text;
            newPersona.Genero = Convert.ToString(comboBoxGenero.Items[comboBoxGenero.SelectedIndex]);

            persona = newPersona;
            controladorPersona.AgregarPersona(persona);
            listPersonas = controladorPersona.ObtenerPersonas();

            MessageBox.Show("Bienvenido/a " + newPersona.Nombre + " " + newPersona.Apellido + " de " + newPersona.Edad);

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";
            textBoxDireccion.Text = "";
            comboBoxGenero.SelectedIndex = 0;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPantallaDos_Click(object sender, EventArgs e)
        {
            PantallaDos pantallaDos = new PantallaDos();
            pantallaDos.Persona = persona;
            pantallaDos.ShowDialog();
        }

        private void buttonPantallaTres_Click(object sender, EventArgs e)
        {
            PantallaTres pantallaTres = new PantallaTres();
            pantallaTres.ListPersonas = listPersonas;
            pantallaTres.ShowDialog();
        }
    }
}
