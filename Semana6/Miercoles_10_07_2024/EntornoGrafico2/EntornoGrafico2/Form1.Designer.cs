namespace EntornoGrafico2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            label2 = new Label();
            textBoxApellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxDireccion = new TextBox();
            label5 = new Label();
            comboBoxGenero = new ComboBox();
            buttonInsertar = new Button();
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            buttonPantallaDos = new Button();
            buttonPantallaTres = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(134, 35);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(259, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(134, 142);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(259, 23);
            textBoxEdad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 135);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(134, 90);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(259, 23);
            textBoxApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 83);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 232);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 6;
            label4.Text = "Genero";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(134, 188);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(259, 23);
            textBoxDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 179);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 8;
            label5.Text = "Direccion";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxGenero.Location = new Point(134, 239);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(259, 23);
            comboBoxGenero.TabIndex = 10;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Location = new Point(23, 314);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(96, 39);
            buttonInsertar.TabIndex = 11;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(161, 314);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(93, 39);
            buttonLimpiar.TabIndex = 12;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(301, 314);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(92, 39);
            buttonSalir.TabIndex = 13;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonPantallaDos
            // 
            buttonPantallaDos.Location = new Point(431, 35);
            buttonPantallaDos.Name = "buttonPantallaDos";
            buttonPantallaDos.Size = new Size(104, 78);
            buttonPantallaDos.TabIndex = 14;
            buttonPantallaDos.Text = "Pantalla Dos";
            buttonPantallaDos.UseVisualStyleBackColor = true;
            buttonPantallaDos.Click += buttonPantallaDos_Click;
            // 
            // buttonPantallaTres
            // 
            buttonPantallaTres.Location = new Point(431, 188);
            buttonPantallaTres.Name = "buttonPantallaTres";
            buttonPantallaTres.Size = new Size(104, 74);
            buttonPantallaTres.TabIndex = 15;
            buttonPantallaTres.Text = "Pantalla Tres";
            buttonPantallaTres.UseVisualStyleBackColor = true;
            buttonPantallaTres.Click += buttonPantallaTres_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(568, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 224);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPantallaTres);
            Controls.Add(buttonPantallaDos);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonInsertar);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(textBoxEdad);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FormEntornoGrafico";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private Label label2;
        private TextBox textBoxApellido;
        private Label label3;
        private Label label4;
        private TextBox textBoxDireccion;
        private Label label5;
        private ComboBox comboBoxGenero;
        private Button buttonInsertar;
        private Button buttonLimpiar;
        private Button buttonSalir;
        private Button buttonPantallaDos;
        private Button buttonPantallaTres;
        private PictureBox pictureBox1;
    }
}
