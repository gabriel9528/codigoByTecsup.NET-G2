namespace modeloConectadoWindowsForms
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAirline = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.comboBoxAirPlaneType = new System.Windows.Forms.ComboBox();
            this.comboBoxFlightGeneral = new System.Windows.Forms.ComboBox();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.buttonUpdateFlight = new System.Windows.Forms.Button();
            this.buttonDeleteFlight = new System.Windows.Forms.Button();
            this.buttonRefreshFlights = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonRefreshFlights);
            this.tabPage1.Controls.Add(this.buttonDeleteFlight);
            this.tabPage1.Controls.Add(this.buttonUpdateFlight);
            this.tabPage1.Controls.Add(this.buttonAddFlight);
            this.tabPage1.Controls.Add(this.comboBoxFlightGeneral);
            this.tabPage1.Controls.Add(this.comboBoxAirPlaneType);
            this.tabPage1.Controls.Add(this.textBoxFlightNumber);
            this.tabPage1.Controls.Add(this.textBoxDestination);
            this.tabPage1.Controls.Add(this.textBoxAirline);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AirPlane Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "FlightNumber";
            // 
            // textBoxAirline
            // 
            this.textBoxAirline.Location = new System.Drawing.Point(152, 28);
            this.textBoxAirline.Name = "textBoxAirline";
            this.textBoxAirline.Size = new System.Drawing.Size(162, 20);
            this.textBoxAirline.TabIndex = 6;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(152, 102);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(162, 20);
            this.textBoxDestination.TabIndex = 7;
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Location = new System.Drawing.Point(152, 63);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(162, 20);
            this.textBoxFlightNumber.TabIndex = 8;
            // 
            // comboBoxAirPlaneType
            // 
            this.comboBoxAirPlaneType.FormattingEnabled = true;
            this.comboBoxAirPlaneType.Location = new System.Drawing.Point(152, 144);
            this.comboBoxAirPlaneType.Name = "comboBoxAirPlaneType";
            this.comboBoxAirPlaneType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxAirPlaneType.TabIndex = 10;
            // 
            // comboBoxFlightGeneral
            // 
            this.comboBoxFlightGeneral.FormattingEnabled = true;
            this.comboBoxFlightGeneral.Location = new System.Drawing.Point(437, 79);
            this.comboBoxFlightGeneral.Name = "comboBoxFlightGeneral";
            this.comboBoxFlightGeneral.Size = new System.Drawing.Size(238, 21);
            this.comboBoxFlightGeneral.TabIndex = 11;
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(437, 24);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(238, 23);
            this.buttonAddFlight.TabIndex = 12;
            this.buttonAddFlight.Text = "Add Flight";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateFlight
            // 
            this.buttonUpdateFlight.Location = new System.Drawing.Point(437, 144);
            this.buttonUpdateFlight.Name = "buttonUpdateFlight";
            this.buttonUpdateFlight.Size = new System.Drawing.Size(107, 23);
            this.buttonUpdateFlight.TabIndex = 13;
            this.buttonUpdateFlight.Text = "UpdateFlight";
            this.buttonUpdateFlight.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFlight
            // 
            this.buttonDeleteFlight.Location = new System.Drawing.Point(568, 142);
            this.buttonDeleteFlight.Name = "buttonDeleteFlight";
            this.buttonDeleteFlight.Size = new System.Drawing.Size(107, 23);
            this.buttonDeleteFlight.TabIndex = 14;
            this.buttonDeleteFlight.Text = "buttonDeleteFlight";
            this.buttonDeleteFlight.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshFlights
            // 
            this.buttonRefreshFlights.Location = new System.Drawing.Point(568, 392);
            this.buttonRefreshFlights.Name = "buttonRefreshFlights";
            this.buttonRefreshFlights.Size = new System.Drawing.Size(107, 23);
            this.buttonRefreshFlights.TabIndex = 15;
            this.buttonRefreshFlights.Text = "Refresh Flights";
            this.buttonRefreshFlights.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 175);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAddFlight;
        private System.Windows.Forms.ComboBox comboBoxFlightGeneral;
        private System.Windows.Forms.ComboBox comboBoxAirPlaneType;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxAirline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefreshFlights;
        private System.Windows.Forms.Button buttonDeleteFlight;
        private System.Windows.Forms.Button buttonUpdateFlight;
    }
}

