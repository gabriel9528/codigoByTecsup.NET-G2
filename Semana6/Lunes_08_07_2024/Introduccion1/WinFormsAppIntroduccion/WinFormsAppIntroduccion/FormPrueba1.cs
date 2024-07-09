namespace WinFormsAppIntroduccion
{
    public partial class FormPrueba1 : Form
    {
        public FormPrueba1()
        {
            InitializeComponent();
            firstNameLabel.Text = "Pedrooooo";
            secondNameLabel.Text = "Picapiedra";
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonFullName_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Bienvenido {textBoxFirstName.Text}, {textBoxLastName.Text}");
            //progressBar1.Value += 10;
            //Form2 form2 = new Form2();
            //form2.Show();
            toolStripProgressBar1.Value += 10;
            toolStripStatusLabel1.Text = $"Progress: {toolStripProgressBar1.Value}%";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
