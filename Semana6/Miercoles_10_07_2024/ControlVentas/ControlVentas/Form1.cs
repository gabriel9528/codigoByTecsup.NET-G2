using System.Collections;

namespace ControlVentas
{
    public partial class Form1 : Form
    {
        //Inicializar lista de Porductos
        static string[] productos = { "Celular", "Laptop", "Monitor", "Televisor", "Lavadora" };

        ArrayList listProductos = new ArrayList(productos);

        //Instanciar mi clase Ventas
        Venta venta = new Venta();

        double Total = 0;

        public Form1()
        {
            InitializeComponent();
            MostrarFecha();
            MostrarHora();
            LimpiarDatos();
            LlenarProductos();

        }


        private void MostrarFecha()
        {
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void MostrarHora()
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void LimpiarDatos()
        {
            textBoxCliente.Text = "";
            comboBoxProducto.Text = "Seleccione un producto";
            textBoxCantidad.Text = "";
            labelPrecio.Text = "";
            textBoxCantidad.Text = "";

            textBoxCliente.Focus();
        }

        public void LlenarProductos()
        {
            foreach (var item in listProductos)
            {
                comboBoxProducto.Items.Add(item);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar la venta?",
                "Ventas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarDatos();
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            venta.Producto = comboBoxProducto.Text;
            venta.Cantidad = Convert.ToInt32(textBoxCantidad.Text);

            ///Mostrar resultados
            ListViewItem fila = new ListViewItem(venta.Producto);
            fila.SubItems.Add(venta.Cantidad.ToString());
            fila.SubItems.Add(venta.AsignarPrecio().ToString("C"));
            fila.SubItems.Add(venta.CalcularSubTotal().ToString("C"));
            fila.SubItems.Add(venta.CalcularDescuento().ToString("C"));
            fila.SubItems.Add(venta.CalcularNeto().ToString("C"));

            listViewResultados.Items.Add(fila);

            Total += venta.CalcularNeto();

            label1Resultado.Text = Total.ToString("C");

            LimpiarDatos();
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            venta.Producto = comboBoxProducto.Text;
            labelPrecio.Text = venta.AsignarPrecio().ToString();
        }
    }
}
