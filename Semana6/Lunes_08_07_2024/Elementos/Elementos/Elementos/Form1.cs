namespace Elementos
{
    public partial class FormElementos : Form
    {
        private int contador;
        public FormElementos()
        {
            InitializeComponent();
            contador = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checkbox
            if (checkBoxFemenino.Checked && checkBoxMasculino.Checked)
            {
                labelPrueba.Text = "Masculino y Femenino";
            }
            else if (checkBoxFemenino.Checked)
            {
                labelPrueba.Text = "Femenino";
            }
            else if (checkBoxMasculino.Checked)
            {
                labelPrueba.Text = "Masculino";
            }
            else
            {
                labelPrueba.Text = "Ninguno";
            }

            //RadioButton
            if (radioButtonSoltero.Checked)
            {
                labelEstadoCivil.Text = "Soltero";
            }
            else if (radioButtonCasado.Checked)
            {
                labelEstadoCivil.Text = "Casado";
            }
            else if (radioButtonDivorciado.Checked)
            {
                labelEstadoCivil.Text = "Divorciado";
            }
            else
            {
                labelEstadoCivil.Text = "No se marco nada";
            }

            //GroupBox-Genero
            if (radioButtonFemenino.Checked)
            {
                labelGenero.Text = "Femenino";
            }
            else if (radioButtonMasculino.Checked)
            {
                labelGenero.Text = "Masculino";
            }
            else
            {
                labelGenero.Text = "No se marco nada";
            }

            //GroupBox-Ciudad
            if (radioButtonArequipa.Checked)
            {
                labelCiudad.Text = "Arequipa";
            }
            else if (radioButtonLima.Checked)
            {
                labelCiudad.Text = "Lima";
            }
            else if (radioButtonCusco.Checked)
            {
                labelCiudad.Text = "Cusco";
            }
            else
            {
                labelCiudad.Text = "No se marco nada";
            }

            //ComboBox
            labelPais.Text = comboBox1.SelectedItem.ToString();


        }

        private void buttonListView_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Hola mundo");
        }

        private void buttonListBox_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Piura");
            string item = listBox1.SelectedItem.ToString();
            labelLIstBox.Text = item;
        }

        private void buttonProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void buttonDateTimePicker_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                labelDateTimePicker.Text = "Es fin de semana";
                labelDateTimePicker.ForeColor = Color.Red;
            }
            else
            {
                labelDateTimePicker.Text = "Es un dia de semana";
                labelDateTimePicker.ForeColor = Color.Blue;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            labelTimePicker.Text = contador.ToString();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void buttonDataGrigView_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.Rows.Add();
            dataGridView1.Rows[num].Cells[0].Value = textBoxNombres.Text;
            dataGridView1.Rows[num].Cells[1].Value = textBoxApellidos.Text;
            dataGridView1.Rows[num].Cells[2].Value = textBoxCalificaciones.Text;

            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxCalificaciones.Text = "";
        }
    }
}
