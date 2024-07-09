namespace WinFormsAppIntroduccion
{
    partial class FormPrueba1
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
            buttonFullName = new Button();
            colorDialog1 = new ColorDialog();
            firstNameLabel = new Label();
            secondNameLabel = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            progressBar1 = new ProgressBar();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            buttonSalir = new Button();
            button1 = new Button();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonFullName
            // 
            buttonFullName.BackColor = Color.FromArgb(0, 0, 64);
            buttonFullName.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFullName.ForeColor = Color.White;
            buttonFullName.Location = new Point(1410, 808);
            buttonFullName.Margin = new Padding(15, 17, 15, 17);
            buttonFullName.Name = "buttonFullName";
            buttonFullName.Padding = new Padding(0, 115, 0, 0);
            buttonFullName.RightToLeft = RightToLeft.No;
            buttonFullName.Size = new Size(1205, 608);
            buttonFullName.TabIndex = 2;
            buttonFullName.Text = "FullName";
            buttonFullName.UseVisualStyleBackColor = false;
            buttonFullName.Click += buttonFullName_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(1540, 310);
            firstNameLabel.Margin = new Padding(15, 0, 15, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(313, 86);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "firstName";
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new Point(1545, 556);
            secondNameLabel.Margin = new Padding(15, 0, 15, 0);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new Size(415, 86);
            secondNameLabel.TabIndex = 5;
            secondNameLabel.Text = "SecondName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(1965, 235);
            textBoxFirstName.Margin = new Padding(15, 17, 15, 17);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(484, 93);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(1965, 482);
            textBoxLastName.Margin = new Padding(15, 17, 15, 17);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(484, 93);
            textBoxLastName.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1410, 1645);
            progressBar1.Margin = new Padding(15, 17, 15, 17);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1205, 132);
            progressBar1.TabIndex = 6;
            progressBar1.Value = 50;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 206);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(5, 0, 70, 0);
            statusStrip1.Size = new Size(690, 98);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(500, 92);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 93);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 57);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(30, 11, 0, 11);
            menuStrip1.Size = new Size(690, 41);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 19);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(190, 740);
            buttonSalir.Margin = new Padding(15, 17, 15, 17);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(375, 132);
            buttonSalir.TabIndex = 9;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(177, 120);
            button1.Name = "button1";
            button1.Size = new Size(326, 136);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormPrueba1
            // 
            AutoScaleDimensions = new SizeF(35F, 86F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(690, 304);
            Controls.Add(button1);
            Controls.Add(buttonSalir);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(progressBar1);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(secondNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(buttonFullName);
            Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(15, 17, 15, 17);
            Name = "FormPrueba1";
            Padding = new Padding(0, 57, 0, 0);
            Text = "Form Prueba 1";
            MouseHover += Form1_MouseHover;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFullName;
        private ColorDialog colorDialog1;
        private Label firstNameLabel;
        private Label secondNameLabel;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private ProgressBar progressBar1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button buttonSalir;
        private Button button1;
    }
}
