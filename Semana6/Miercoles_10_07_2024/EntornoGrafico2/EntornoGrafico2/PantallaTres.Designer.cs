namespace EntornoGrafico2
{
    partial class PantallaTres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            buttonSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Edad, Direccion, Genero });
            dataGridView1.Location = new Point(54, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 249);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.Width = 150;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(637, 313);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(114, 37);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // PantallaTres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(dataGridView1);
            Name = "PantallaTres";
            Text = "PantallaTres";
            Load += PantallaTres_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Genero;
        private Button buttonSalir;
    }
}