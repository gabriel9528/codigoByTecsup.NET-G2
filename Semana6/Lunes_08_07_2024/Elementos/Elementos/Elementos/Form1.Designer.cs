namespace Elementos
{
    partial class FormElementos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElementos));
            ListViewItem listViewItem1 = new ListViewItem("Arequipa");
            ListViewItem listViewItem2 = new ListViewItem("Cusco");
            ListViewItem listViewItem3 = new ListViewItem("Tarapoto");
            labelPrueba = new Label();
            button1 = new Button();
            checkBoxMasculino = new CheckBox();
            checkBoxFemenino = new CheckBox();
            radioButtonSoltero = new RadioButton();
            radioButtonCasado = new RadioButton();
            radioButtonDivorciado = new RadioButton();
            labelEstadoCivil = new Label();
            groupBox1 = new GroupBox();
            labelGenero = new Label();
            radioButtonFemenino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            groupBox2 = new GroupBox();
            labelCiudad = new Label();
            radioButtonCusco = new RadioButton();
            radioButtonLima = new RadioButton();
            radioButtonArequipa = new RadioButton();
            comboBox1 = new ComboBox();
            labelPais = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            buttonListView = new Button();
            listBox1 = new ListBox();
            buttonListBox = new Button();
            labelLIstBox = new Label();
            progressBar1 = new ProgressBar();
            buttonProgressBar = new Button();
            dateTimePicker1 = new DateTimePicker();
            buttonDateTimePicker = new Button();
            labelDateTimePicker = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonIniciar = new Button();
            buttonStop = new Button();
            labelTimePicker = new Label();
            dataGridView1 = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            textBoxNombres = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxCalificaciones = new TextBox();
            labelNombres = new Label();
            labelApellidos = new Label();
            labelCalificaciones = new Label();
            buttonDataGrigView = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelPrueba
            // 
            labelPrueba.AutoSize = true;
            labelPrueba.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrueba.Location = new Point(20, 164);
            labelPrueba.Name = "labelPrueba";
            labelPrueba.Size = new Size(87, 31);
            labelPrueba.TabIndex = 0;
            labelPrueba.Text = "Sexo";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(23, 33);
            button1.Name = "button1";
            button1.Size = new Size(144, 37);
            button1.TabIndex = 1;
            button1.Text = "boton Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxMasculino
            // 
            checkBoxMasculino.AutoSize = true;
            checkBoxMasculino.Location = new Point(23, 90);
            checkBoxMasculino.Name = "checkBoxMasculino";
            checkBoxMasculino.Size = new Size(120, 26);
            checkBoxMasculino.TabIndex = 2;
            checkBoxMasculino.Text = "Masculino";
            checkBoxMasculino.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemenino
            // 
            checkBoxFemenino.AutoSize = true;
            checkBoxFemenino.Location = new Point(23, 122);
            checkBoxFemenino.Name = "checkBoxFemenino";
            checkBoxFemenino.Size = new Size(111, 26);
            checkBoxFemenino.TabIndex = 3;
            checkBoxFemenino.Text = "Femenino";
            checkBoxFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoltero
            // 
            radioButtonSoltero.AutoSize = true;
            radioButtonSoltero.Location = new Point(198, 33);
            radioButtonSoltero.Name = "radioButtonSoltero";
            radioButtonSoltero.Size = new Size(96, 26);
            radioButtonSoltero.TabIndex = 4;
            radioButtonSoltero.TabStop = true;
            radioButtonSoltero.Text = "Soltero";
            radioButtonSoltero.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasado
            // 
            radioButtonCasado.AutoSize = true;
            radioButtonCasado.Location = new Point(198, 65);
            radioButtonCasado.Name = "radioButtonCasado";
            radioButtonCasado.Size = new Size(91, 26);
            radioButtonCasado.TabIndex = 5;
            radioButtonCasado.TabStop = true;
            radioButtonCasado.Text = "Casado";
            radioButtonCasado.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivorciado
            // 
            radioButtonDivorciado.AutoSize = true;
            radioButtonDivorciado.Location = new Point(198, 97);
            radioButtonDivorciado.Name = "radioButtonDivorciado";
            radioButtonDivorciado.Size = new Size(124, 26);
            radioButtonDivorciado.TabIndex = 6;
            radioButtonDivorciado.TabStop = true;
            radioButtonDivorciado.Text = "Divorciado";
            radioButtonDivorciado.UseVisualStyleBackColor = true;
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Location = new Point(198, 144);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(125, 22);
            labelEstadoCivil.TabIndex = 7;
            labelEstadoCivil.Text = "Estado Civil";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelGenero);
            groupBox1.Controls.Add(radioButtonFemenino);
            groupBox1.Controls.Add(radioButtonMasculino);
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 169);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genero";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(35, 125);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(115, 22);
            labelGenero.TabIndex = 2;
            labelGenero.Text = "labelGenero";
            // 
            // radioButtonFemenino
            // 
            radioButtonFemenino.AutoSize = true;
            radioButtonFemenino.Location = new Point(14, 64);
            radioButtonFemenino.Name = "radioButtonFemenino";
            radioButtonFemenino.Size = new Size(110, 26);
            radioButtonFemenino.TabIndex = 1;
            radioButtonFemenino.TabStop = true;
            radioButtonFemenino.Text = "Femenino";
            radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(17, 33);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(119, 26);
            radioButtonMasculino.TabIndex = 0;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelCiudad);
            groupBox2.Controls.Add(radioButtonCusco);
            groupBox2.Controls.Add(radioButtonLima);
            groupBox2.Controls.Add(radioButtonArequipa);
            groupBox2.Location = new Point(199, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 160);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ciudad";
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(47, 135);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(71, 22);
            labelCiudad.TabIndex = 3;
            labelCiudad.Text = "Ciudad";
            // 
            // radioButtonCusco
            // 
            radioButtonCusco.AutoSize = true;
            radioButtonCusco.Location = new Point(13, 87);
            radioButtonCusco.Name = "radioButtonCusco";
            radioButtonCusco.Size = new Size(81, 26);
            radioButtonCusco.TabIndex = 2;
            radioButtonCusco.TabStop = true;
            radioButtonCusco.Text = "Cusco";
            radioButtonCusco.UseVisualStyleBackColor = true;
            // 
            // radioButtonLima
            // 
            radioButtonLima.AutoSize = true;
            radioButtonLima.Location = new Point(13, 55);
            radioButtonLima.Name = "radioButtonLima";
            radioButtonLima.Size = new Size(70, 26);
            radioButtonLima.TabIndex = 1;
            radioButtonLima.TabStop = true;
            radioButtonLima.Text = "Lima";
            radioButtonLima.UseVisualStyleBackColor = true;
            // 
            // radioButtonArequipa
            // 
            radioButtonArequipa.AutoSize = true;
            radioButtonArequipa.Location = new Point(14, 27);
            radioButtonArequipa.Name = "radioButtonArequipa";
            radioButtonArequipa.Size = new Size(109, 26);
            radioButtonArequipa.TabIndex = 0;
            radioButtonArequipa.TabStop = true;
            radioButtonArequipa.Text = "Arequipa";
            radioButtonArequipa.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Peru", "Chile", "Colombia", "Ecuador" });
            comboBox1.Location = new Point(383, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 30);
            comboBox1.TabIndex = 10;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(383, 81);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(60, 22);
            labelPais.TabIndex = 11;
            labelPais.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.WaitCursor;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(383, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 266);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(633, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(323, 163);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonListView
            // 
            buttonListView.Location = new Point(862, 207);
            buttonListView.Name = "buttonListView";
            buttonListView.Size = new Size(94, 33);
            buttonListView.TabIndex = 14;
            buttonListView.Text = "Agregar";
            buttonListView.UseVisualStyleBackColor = true;
            buttonListView.Click += buttonListView_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Items.AddRange(new object[] { "Puno", "Arequipa" });
            listBox1.Location = new Point(633, 253);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(318, 92);
            listBox1.TabIndex = 15;
            // 
            // buttonListBox
            // 
            buttonListBox.Location = new Point(770, 361);
            buttonListBox.Name = "buttonListBox";
            buttonListBox.Size = new Size(181, 33);
            buttonListBox.TabIndex = 16;
            buttonListBox.Text = "Agregar ListBox";
            buttonListBox.UseVisualStyleBackColor = true;
            buttonListBox.Click += buttonListBox_Click;
            // 
            // labelLIstBox
            // 
            labelLIstBox.AutoSize = true;
            labelLIstBox.ForeColor = Color.Red;
            labelLIstBox.Location = new Point(636, 358);
            labelLIstBox.Name = "labelLIstBox";
            labelLIstBox.Size = new Size(60, 22);
            labelLIstBox.TabIndex = 17;
            labelLIstBox.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Cursor = Cursors.No;
            progressBar1.Location = new Point(20, 439);
            progressBar1.Maximum = 1000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(360, 23);
            progressBar1.TabIndex = 18;
            progressBar1.Value = 50;
            // 
            // buttonProgressBar
            // 
            buttonProgressBar.Location = new Point(199, 468);
            buttonProgressBar.Name = "buttonProgressBar";
            buttonProgressBar.Size = new Size(181, 33);
            buttonProgressBar.TabIndex = 19;
            buttonProgressBar.Text = "ProgressBar";
            buttonProgressBar.UseVisualStyleBackColor = true;
            buttonProgressBar.Click += buttonProgressBar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 547);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(368, 28);
            dateTimePicker1.TabIndex = 20;
            // 
            // buttonDateTimePicker
            // 
            buttonDateTimePicker.Location = new Point(253, 598);
            buttonDateTimePicker.Name = "buttonDateTimePicker";
            buttonDateTimePicker.Size = new Size(127, 31);
            buttonDateTimePicker.TabIndex = 21;
            buttonDateTimePicker.Text = "Comprobar";
            buttonDateTimePicker.UseVisualStyleBackColor = true;
            buttonDateTimePicker.Click += buttonDateTimePicker_Click;
            // 
            // labelDateTimePicker
            // 
            labelDateTimePicker.AutoSize = true;
            labelDateTimePicker.Location = new Point(17, 607);
            labelDateTimePicker.Name = "labelDateTimePicker";
            labelDateTimePicker.Size = new Size(94, 22);
            labelDateTimePicker.TabIndex = 22;
            labelDateTimePicker.Text = "DateTime";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(395, 494);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(92, 36);
            buttonIniciar.TabIndex = 23;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(493, 494);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(101, 36);
            buttonStop.TabIndex = 24;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelTimePicker
            // 
            labelTimePicker.AutoSize = true;
            labelTimePicker.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimePicker.Location = new Point(444, 453);
            labelTimePicker.Name = "labelTimePicker";
            labelTimePicker.Size = new Size(102, 35);
            labelTimePicker.TabIndex = 25;
            labelTimePicker.Text = "Timer";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombres, Apellidos, Calificacion });
            dataGridView1.Location = new Point(624, 553);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(392, 150);
            dataGridView1.TabIndex = 26;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "Calificacion";
            Calificacion.Name = "Calificacion";
            // 
            // textBoxNombres
            // 
            textBoxNombres.Location = new Point(624, 519);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.Size = new Size(100, 28);
            textBoxNombres.TabIndex = 27;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(770, 519);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(100, 28);
            textBoxApellidos.TabIndex = 28;
            // 
            // textBoxCalificaciones
            // 
            textBoxCalificaciones.Location = new Point(916, 519);
            textBoxCalificaciones.Name = "textBoxCalificaciones";
            textBoxCalificaciones.Size = new Size(100, 28);
            textBoxCalificaciones.TabIndex = 29;
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.Location = new Point(624, 492);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(87, 22);
            labelNombres.TabIndex = 30;
            labelNombres.Text = "Nombres";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Location = new Point(770, 494);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(93, 22);
            labelApellidos.TabIndex = 31;
            labelApellidos.Text = "Apellidos";
            // 
            // labelCalificaciones
            // 
            labelCalificaciones.AutoSize = true;
            labelCalificaciones.Location = new Point(878, 494);
            labelCalificaciones.Name = "labelCalificaciones";
            labelCalificaciones.Size = new Size(138, 22);
            labelCalificaciones.TabIndex = 32;
            labelCalificaciones.Text = "Calificaciones";
            // 
            // buttonDataGrigView
            // 
            buttonDataGrigView.BackColor = Color.FromArgb(0, 192, 0);
            buttonDataGrigView.ForeColor = Color.White;
            buttonDataGrigView.Location = new Point(624, 453);
            buttonDataGrigView.Name = "buttonDataGrigView";
            buttonDataGrigView.Size = new Size(392, 36);
            buttonDataGrigView.TabIndex = 33;
            buttonDataGrigView.Text = "Agregar";
            buttonDataGrigView.UseVisualStyleBackColor = false;
            buttonDataGrigView.Click += buttonDataGrigView_Click;
            // 
            // FormElementos
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1040, 715);
            Controls.Add(buttonDataGrigView);
            Controls.Add(labelCalificaciones);
            Controls.Add(labelApellidos);
            Controls.Add(labelNombres);
            Controls.Add(textBoxCalificaciones);
            Controls.Add(textBoxApellidos);
            Controls.Add(textBoxNombres);
            Controls.Add(dataGridView1);
            Controls.Add(labelTimePicker);
            Controls.Add(buttonStop);
            Controls.Add(buttonIniciar);
            Controls.Add(labelDateTimePicker);
            Controls.Add(buttonDateTimePicker);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonProgressBar);
            Controls.Add(progressBar1);
            Controls.Add(labelLIstBox);
            Controls.Add(buttonListBox);
            Controls.Add(listBox1);
            Controls.Add(buttonListView);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(labelPais);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelEstadoCivil);
            Controls.Add(radioButtonDivorciado);
            Controls.Add(radioButtonCasado);
            Controls.Add(radioButtonSoltero);
            Controls.Add(checkBoxFemenino);
            Controls.Add(checkBoxMasculino);
            Controls.Add(button1);
            Controls.Add(labelPrueba);
            Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormElementos";
            Text = "Femenino";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrueba;
        private Button button1;
        private CheckBox checkBoxMasculino;
        private CheckBox checkBoxFemenino;
        private RadioButton radioButtonSoltero;
        private RadioButton radioButtonCasado;
        private RadioButton radioButtonDivorciado;
        private Label labelEstadoCivil;
        private GroupBox groupBox1;
        private Label labelGenero;
        private RadioButton radioButtonFemenino;
        private RadioButton radioButtonMasculino;
        private GroupBox groupBox2;
        private Label labelCiudad;
        private RadioButton radioButtonCusco;
        private RadioButton radioButtonLima;
        private RadioButton radioButtonArequipa;
        private ComboBox comboBox1;
        private Label labelPais;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Button buttonListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListBox listBox1;
        private Button buttonListBox;
        private Label labelLIstBox;
        private ProgressBar progressBar1;
        private Button buttonProgressBar;
        private DateTimePicker dateTimePicker1;
        private Button buttonDateTimePicker;
        private Label labelDateTimePicker;
        private System.Windows.Forms.Timer timer1;
        private Button buttonIniciar;
        private Button buttonStop;
        private Label labelTimePicker;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Calificacion;
        private TextBox textBoxNombres;
        private TextBox textBoxApellidos;
        private TextBox textBoxCalificaciones;
        private Label labelNombres;
        private Label labelApellidos;
        private Label labelCalificaciones;
        private Button buttonDataGrigView;
    }
}
