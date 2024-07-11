namespace ControlVentas
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
            groupBox1 = new GroupBox();
            textBoxCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelFecha = new Label();
            labelHora = new Label();
            groupBox2 = new GroupBox();
            buttonRegistrar = new Button();
            buttonCancelar = new Button();
            labelPrecio = new Label();
            label9 = new Label();
            textBoxCantidad = new TextBox();
            label8 = new Label();
            comboBoxProducto = new ComboBox();
            label7 = new Label();
            listViewResultados = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Precio = new ColumnHeader();
            SubTotal = new ColumnHeader();
            Descuento = new ColumnHeader();
            Neto = new ColumnHeader();
            label10 = new Label();
            label1Resultado = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(6, 76);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(464, 29);
            textBoxCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 37);
            label1.TabIndex = 1;
            label1.Text = "Control de Ventas de Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(540, 70);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(819, 70);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "HORA";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(540, 135);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(54, 21);
            labelFecha.TabIndex = 4;
            labelFecha.Text = "Fecha";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHora.Location = new Point(819, 135);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(47, 21);
            labelHora.TabIndex = 5;
            labelHora.Text = "Hora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonRegistrar);
            groupBox2.Controls.Add(buttonCancelar);
            groupBox2.Controls.Add(labelPrecio);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxCantidad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBoxProducto);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(27, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(871, 146);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la venta";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Gold;
            buttonRegistrar.Location = new Point(751, 88);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(103, 44);
            buttonRegistrar.TabIndex = 7;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Yellow;
            buttonCancelar.Location = new Point(751, 29);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(103, 42);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(656, 88);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(0, 21);
            labelPrecio.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(656, 37);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 4;
            label9.Text = "Precio";
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(504, 85);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 29);
            textBoxCantidad.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(513, 40);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 2;
            label8.Text = "Cantidad";
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(12, 71);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(459, 29);
            comboBoxProducto.TabIndex = 1;
            comboBoxProducto.SelectedIndexChanged += comboBoxProducto_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 37);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 0;
            label7.Text = "Producto";
            // 
            // listViewResultados
            // 
            listViewResultados.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad, Precio, SubTotal, Descuento, Neto });
            listViewResultados.Location = new Point(26, 381);
            listViewResultados.Name = "listViewResultados";
            listViewResultados.Size = new Size(872, 177);
            listViewResultados.TabIndex = 7;
            listViewResultados.UseCompatibleStateImageBehavior = false;
            listViewResultados.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 120;
            // 
            // SubTotal
            // 
            SubTotal.Text = "SubTotal";
            SubTotal.Width = 120;
            // 
            // Descuento
            // 
            Descuento.Text = "Descuento";
            Descuento.Width = 120;
            // 
            // Neto
            // 
            Neto.Text = "Neto";
            Neto.Width = 120;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(594, 579);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 8;
            label10.Text = "Total Neto";
            // 
            // label1Resultado
            // 
            label1Resultado.AutoSize = true;
            label1Resultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Resultado.Location = new Point(741, 579);
            label1Resultado.Name = "label1Resultado";
            label1Resultado.Size = new Size(0, 25);
            label1Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(947, 627);
            Controls.Add(label1Resultado);
            Controls.Add(label10);
            Controls.Add(listViewResultados);
            Controls.Add(groupBox2);
            Controls.Add(labelHora);
            Controls.Add(labelFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxCliente;
        private Label label3;
        private Label label4;
        private Label labelFecha;
        private Label labelHora;
        private GroupBox groupBox2;
        private Label labelPrecio;
        private Label label9;
        private TextBox textBoxCantidad;
        private Label label8;
        private ComboBox comboBoxProducto;
        private Label label7;
        private Button buttonRegistrar;
        private Button buttonCancelar;
        private ListView listViewResultados;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Precio;
        private ColumnHeader SubTotal;
        private ColumnHeader Descuento;
        private ColumnHeader Neto;
        private Label label10;
        private Label label1Resultado;
    }
}
