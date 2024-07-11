namespace WinFormsAppIntroduccion_Resumen
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
            buttonLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelResultado = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            buttonCalcular = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.SteelBlue;
            buttonLimpiar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.ForeColor = SystemColors.ButtonHighlight;
            buttonLimpiar.Location = new Point(139, 236);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(106, 37);
            buttonLimpiar.TabIndex = 0;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseMnemonic = false;
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 26);
            label1.Name = "label1";
            label1.Size = new Size(475, 37);
            label1.TabIndex = 1;
            label1.Text = "SUMA DE DOS NUMEROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 85);
            label2.Name = "label2";
            label2.Size = new Size(179, 24);
            label2.TabIndex = 2;
            label2.Text = "Primer Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 131);
            label3.Name = "label3";
            label3.Size = new Size(192, 24);
            label3.TabIndex = 3;
            label3.Text = "Segundo Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(204, 178);
            label4.Name = "label4";
            label4.Size = new Size(127, 24);
            label4.TabIndex = 4;
            label4.Text = "Resultado";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(367, 162);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 44);
            labelResultado.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(346, 92);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(281, 23);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(346, 136);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(281, 23);
            textBoxSecondName.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.DarkGreen;
            buttonCalcular.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcular.ForeColor = Color.White;
            buttonCalcular.Location = new Point(331, 236);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(106, 37);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseMnemonic = false;
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Fuchsia;
            buttonSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = SystemColors.ButtonHighlight;
            buttonSalir.Location = new Point(521, 236);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(106, 37);
            buttonSalir.TabIndex = 9;
            buttonSalir.Text = "Salir";
            buttonSalir.UseMnemonic = false;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLimpiar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelResultado;
        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private Button buttonCalcular;
        private Button buttonSalir;
    }
}
