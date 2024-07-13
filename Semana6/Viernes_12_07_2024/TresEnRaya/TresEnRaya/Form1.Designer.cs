namespace TresEnRaya
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            buttonExit = new Button();
            buttonReset = new Button();
            buttonNewGame = new Button();
            panel4 = new Panel();
            labelPlayer0 = new Label();
            labelPlayerX = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(85, 14);
            label1.Name = "label1";
            label1.Size = new Size(770, 65);
            label1.TabIndex = 0;
            label1.Text = "JUEGO DE TRES EN RAYA- CON WF";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(13, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 457);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(buttonExit);
            panel5.Controls.Add(buttonReset);
            panel5.Controls.Add(buttonNewGame);
            panel5.Location = new Point(495, 195);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 221);
            panel5.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.OrangeRed;
            buttonExit.Location = new Point(212, 105);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(198, 97);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.ForeColor = Color.OrangeRed;
            buttonReset.Location = new Point(16, 105);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(190, 97);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonNewGame.ForeColor = Color.OrangeRed;
            buttonNewGame.Location = new Point(16, 16);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(394, 83);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "NEW GAME";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(labelPlayer0);
            panel4.Controls.Add(labelPlayerX);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(495, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 167);
            panel4.TabIndex = 1;
            // 
            // labelPlayer0
            // 
            labelPlayer0.AutoSize = true;
            labelPlayer0.BackColor = Color.White;
            labelPlayer0.BorderStyle = BorderStyle.Fixed3D;
            labelPlayer0.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayer0.ForeColor = Color.OrangeRed;
            labelPlayer0.Location = new Point(247, 96);
            labelPlayer0.Name = "labelPlayer0";
            labelPlayer0.Size = new Size(56, 67);
            labelPlayer0.TabIndex = 3;
            labelPlayer0.Text = "0";
            // 
            // labelPlayerX
            // 
            labelPlayerX.AutoSize = true;
            labelPlayerX.BackColor = Color.White;
            labelPlayerX.BorderStyle = BorderStyle.Fixed3D;
            labelPlayerX.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerX.ForeColor = Color.OrangeRed;
            labelPlayerX.Location = new Point(247, 15);
            labelPlayerX.Name = "labelPlayerX";
            labelPlayerX.Size = new Size(56, 67);
            labelPlayerX.TabIndex = 2;
            labelPlayerX.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(235, 65);
            label3.TabIndex = 1;
            label3.Text = "Player 0: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(238, 65);
            label2.TabIndex = 0;
            label2.Text = "Player X: ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(13, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 406);
            panel3.TabIndex = 0;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(17, 267);
            button7.Name = "button7";
            button7.Size = new Size(120, 120);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Red;
            button8.Location = new Point(158, 267);
            button8.Name = "button8";
            button8.Size = new Size(120, 120);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(309, 267);
            button9.Name = "button9";
            button9.Size = new Size(120, 120);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(17, 141);
            button4.Name = "button4";
            button4.Size = new Size(120, 120);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(158, 141);
            button5.Name = "button5";
            button5.Size = new Size(120, 120);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(309, 141);
            button6.Name = "button6";
            button6.Size = new Size(120, 120);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(309, 15);
            button3.Name = "button3";
            button3.Size = new Size(120, 120);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(158, 15);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(17, 15);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(962, 596);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label labelPlayerX;
        private Label label3;
        private Label label2;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonNewGame;
        private Label labelPlayer0;
    }
}
