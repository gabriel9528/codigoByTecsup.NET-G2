namespace DataBinding2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Departamento> listDepartamentos = new List<Departamento>();
            Departamento departamento1 = new Departamento("Ingenierias");
            departamento1.Add(new Estudiante("Juan Oritz", "calle Azufral 300"));
            departamento1.Add(new Estudiante("Maria Flores", "Av. Circunvalacion 508"));
            listDepartamentos.Add(departamento1);

            Departamento departamento2 = new Departamento("Ciencias");
            departamento2.Add(new Estudiante("Pedro Perez", "calle 5 de Mayo 100"));
            departamento2.Add(new Estudiante("Ana Lopez", "Av. 20 de Noviembre 200"));
            departamento2.Add(new Estudiante("Rosa Martinez", "calle 10 de Abril 300"));
            listDepartamentos.Add(departamento2);

            BindingSource comboBoxBindingSource = new BindingSource();
            BindingSource listBoxBindingSource = new BindingSource();

            comboBoxBindingSource.DataSource = listDepartamentos;

            listBoxBindingSource.DataSource = comboBoxBindingSource;
            listBoxBindingSource.DataMember = "ListEstudiantes";

            comboBox1.DataSource = comboBoxBindingSource;
            comboBox1.DisplayMember = "NombreDepartamento";

            listBox1.DataSource = listBoxBindingSource;
            listBox1.DisplayMember = "Nombre";

            textBox1.DataBindings.Add("Text", listBoxBindingSource, "Direccion");
        }
    }
}
