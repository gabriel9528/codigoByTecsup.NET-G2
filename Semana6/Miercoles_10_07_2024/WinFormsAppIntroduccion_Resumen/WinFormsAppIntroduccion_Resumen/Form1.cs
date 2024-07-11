namespace WinFormsAppIntroduccion_Resumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBoxFirstName.Text);
            int numero2 = Convert.ToInt32(textBoxSecondName.Text);

            int suma = numero1 + numero2;

            labelResultado.Text = suma.ToString();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxSecondName.Text = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
