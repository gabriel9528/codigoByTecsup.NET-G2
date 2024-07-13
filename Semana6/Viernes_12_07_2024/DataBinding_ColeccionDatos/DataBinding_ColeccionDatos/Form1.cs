namespace DataBinding_ColeccionDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Universidad universidad = new Universidad("Universidad Peruana de Ciencias Aplicadas", "UPC", "Av. Salaverry 2255, San Isidro");
            Universidad universidad1 = new Universidad("Universidad Nacional de Ingenieria", "UNI", "Av, Tupac Amaru 210, Rimac");
            Universidad universidad2 = new Universidad("Universidad Nacional Mayor de San Marcos", "UNMSM", "Av. Venezuela s/n, Cercado de Lima");
            Universidad universidad3 = new Universidad("Pontificie Universidad Catolica del Peru", "PUCP", "Av. La Fontana 1250, La Molina");

            List<Universidad> listUniversidades = new List<Universidad>();
            listUniversidades.Add(universidad);
            listUniversidades.Add(universidad1);
            listUniversidades.Add(universidad2);
            listUniversidades.Add(universidad3);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listUniversidades;

            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "Acronimo";

            textBoxNombre.DataBindings.Add("Text", bindingSource, "Nombre");
            textBoxDireccion.DataBindings.Add("Text", bindingSource, "Direccion");

        }
    }
}
