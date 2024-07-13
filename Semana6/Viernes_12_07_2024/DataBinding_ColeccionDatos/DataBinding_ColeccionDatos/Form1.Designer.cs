namespace DataBinding_ColeccionDatos
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
            labelAcronimo = new Label();
            labelNombre = new Label();
            labelDireccion = new Label();
            comboBox1 = new ComboBox();
            textBoxNombre = new TextBox();
            textBoxDireccion = new TextBox();
            SuspendLayout();
            // 
            // labelAcronimo
            // 
            labelAcronimo.AutoSize = true;
            labelAcronimo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAcronimo.Location = new Point(182, 72);
            labelAcronimo.Name = "labelAcronimo";
            labelAcronimo.Size = new Size(103, 30);
            labelAcronimo.TabIndex = 0;
            labelAcronimo.Text = "Acronimo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(68, 128);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(217, 30);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre - Universidad";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDireccion.Location = new Point(171, 182);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(114, 32);
            labelDireccion.TabIndex = 2;
            labelDireccion.Text = "Direccion";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(302, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(304, 132);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(229, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(304, 191);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(229, 23);
            textBoxDireccion.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxNombre);
            Controls.Add(comboBox1);
            Controls.Add(labelDireccion);
            Controls.Add(labelNombre);
            Controls.Add(labelAcronimo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAcronimo;
        private Label labelNombre;
        private Label labelDireccion;
        private ComboBox comboBox1;
        private TextBox textBoxNombre;
        private TextBox textBoxDireccion;
    }
}
