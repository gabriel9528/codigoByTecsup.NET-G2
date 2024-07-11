namespace EntornoGrafico2
{
    partial class PantallaDos
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
            label1 = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            label3 = new Label();
            labelEdad = new Label();
            label5 = new Label();
            labelDireccion = new Label();
            label7 = new Label();
            labelGenero = new Label();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 58);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(321, 58);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 30);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(321, 117);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(96, 30);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.OutlineButton;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 117);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdad.Location = new Point(321, 172);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(61, 30);
            labelEdad.TabIndex = 6;
            labelEdad.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 172);
            label5.Name = "label5";
            label5.Size = new Size(61, 30);
            label5.TabIndex = 5;
            label5.Text = "Edad";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDireccion.Location = new Point(321, 234);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(105, 30);
            labelDireccion.TabIndex = 8;
            labelDireccion.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(179, 234);
            label7.Name = "label7";
            label7.Size = new Size(105, 30);
            label7.TabIndex = 7;
            label7.Text = "Direccion";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGenero.Location = new Point(321, 285);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(84, 30);
            labelGenero.TabIndex = 10;
            labelGenero.Text = "Genero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(179, 285);
            label9.Name = "label9";
            label9.Size = new Size(84, 30);
            label9.TabIndex = 9;
            label9.Text = "Genero";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 299);
            button1.Name = "button1";
            button1.Size = new Size(104, 49);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PantallaDos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelGenero);
            Controls.Add(label9);
            Controls.Add(labelDireccion);
            Controls.Add(label7);
            Controls.Add(labelEdad);
            Controls.Add(label5);
            Controls.Add(labelApellido);
            Controls.Add(label3);
            Controls.Add(labelNombre);
            Controls.Add(label1);
            Name = "PantallaDos";
            Text = "PantallaDos";
            Load += PantallaDos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNombre;
        private Label labelApellido;
        private Label label3;
        private Label labelEdad;
        private Label label5;
        private Label labelDireccion;
        private Label label7;
        private Label labelGenero;
        private Label label9;
        private Button button1;
    }
}