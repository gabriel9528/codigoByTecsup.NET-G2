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
            this.dataGridViewFlight = new System.Windows.Forms.DataGridView();
            this.buttonRefreshFlights = new System.Windows.Forms.Button();
            this.buttonDeleteFlight = new System.Windows.Forms.Button();
            this.buttonUpdateFlight = new System.Windows.Forms.Button();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.comboBoxFlightGeneral = new System.Windows.Forms.ComboBox();
            this.comboBoxAirPlaneType = new System.Windows.Forms.ComboBox();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxAirline = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxFlightNumberUsers = new System.Windows.Forms.ComboBox();
            this.comboBoxUserGeneral = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonRefreshUsers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlight)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewFlight);
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
            this.tabPage1.Size = new System.Drawing.Size(696, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFlight
            // 
            this.dataGridViewFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlight.Location = new System.Drawing.Point(21, 190);
            this.dataGridViewFlight.Name = "dataGridViewFlight";
            this.dataGridViewFlight.Size = new System.Drawing.Size(654, 175);
            this.dataGridViewFlight.TabIndex = 16;
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
            // buttonDeleteFlight
            // 
            this.buttonDeleteFlight.Location = new System.Drawing.Point(568, 142);
            this.buttonDeleteFlight.Name = "buttonDeleteFlight";
            this.buttonDeleteFlight.Size = new System.Drawing.Size(107, 23);
            this.buttonDeleteFlight.TabIndex = 14;
            this.buttonDeleteFlight.Text = "buttonDeleteFlight";
            this.buttonDeleteFlight.UseVisualStyleBackColor = true;
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
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(437, 24);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(238, 23);
            this.buttonAddFlight.TabIndex = 12;
            this.buttonAddFlight.Text = "Add Flight";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            // 
            // comboBoxFlightGeneral
            // 
            this.comboBoxFlightGeneral.FormattingEnabled = true;
            this.comboBoxFlightGeneral.Location = new System.Drawing.Point(437, 79);
            this.comboBoxFlightGeneral.Name = "comboBoxFlightGeneral";
            this.comboBoxFlightGeneral.Size = new System.Drawing.Size(238, 21);
            this.comboBoxFlightGeneral.TabIndex = 11;
            // 
            // comboBoxAirPlaneType
            // 
            this.comboBoxAirPlaneType.FormattingEnabled = true;
            this.comboBoxAirPlaneType.Location = new System.Drawing.Point(152, 144);
            this.comboBoxAirPlaneType.Name = "comboBoxAirPlaneType";
            this.comboBoxAirPlaneType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxAirPlaneType.TabIndex = 10;
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Location = new System.Drawing.Point(152, 63);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(162, 20);
            this.textBoxFlightNumber.TabIndex = 8;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(152, 102);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(162, 20);
            this.textBoxDestination.TabIndex = 7;
            // 
            // textBoxAirline
            // 
            this.textBoxAirline.Location = new System.Drawing.Point(152, 28);
            this.textBoxAirline.Name = "textBoxAirline";
            this.textBoxAirline.Size = new System.Drawing.Size(162, 20);
            this.textBoxAirline.TabIndex = 6;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airline";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonRefreshUsers);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Controls.Add(this.buttonDeleteUser);
            this.tabPage2.Controls.Add(this.buttonUpdateUser);
            this.tabPage2.Controls.Add(this.buttonAddUser);
            this.tabPage2.Controls.Add(this.comboBoxUserGeneral);
            this.tabPage2.Controls.Add(this.comboBoxFlightNumberUsers);
            this.tabPage2.Controls.Add(this.textBoxEmail);
            this.tabPage2.Controls.Add(this.textBoxAddress);
            this.tabPage2.Controls.Add(this.textBoxAge);
            this.tabPage2.Controls.Add(this.textBoxNameUser);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Flight Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Location = new System.Drawing.Point(122, 33);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(163, 20);
            this.textBoxNameUser.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(122, 154);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(163, 20);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(122, 115);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(163, 20);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(122, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // comboBoxFlightNumberUsers
            // 
            this.comboBoxFlightNumberUsers.FormattingEnabled = true;
            this.comboBoxFlightNumberUsers.Location = new System.Drawing.Point(122, 191);
            this.comboBoxFlightNumberUsers.Name = "comboBoxFlightNumberUsers";
            this.comboBoxFlightNumberUsers.Size = new System.Drawing.Size(163, 21);
            this.comboBoxFlightNumberUsers.TabIndex = 10;
            // 
            // comboBoxUserGeneral
            // 
            this.comboBoxUserGeneral.FormattingEnabled = true;
            this.comboBoxUserGeneral.Location = new System.Drawing.Point(360, 110);
            this.comboBoxUserGeneral.Name = "comboBoxUserGeneral";
            this.comboBoxUserGeneral.Size = new System.Drawing.Size(258, 21);
            this.comboBoxUserGeneral.TabIndex = 11;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(360, 29);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(258, 23);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(360, 188);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(124, 23);
            this.buttonUpdateUser.TabIndex = 13;
            this.buttonUpdateUser.Text = "Update User";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(494, 188);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(124, 23);
            this.buttonDeleteUser.TabIndex = 14;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(26, 238);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(592, 152);
            this.dataGridViewUsers.TabIndex = 15;
            // 
            // buttonRefreshUsers
            // 
            this.buttonRefreshUsers.Location = new System.Drawing.Point(525, 416);
            this.buttonRefreshUsers.Name = "buttonRefreshUsers";
            this.buttonRefreshUsers.Size = new System.Drawing.Size(93, 23);
            this.buttonRefreshUsers.TabIndex = 16;
            this.buttonRefreshUsers.Text = "Refresh Users";
            this.buttonRefreshUsers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlight)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewFlight;
        private System.Windows.Forms.Button buttonRefreshFlights;
        private System.Windows.Forms.Button buttonDeleteFlight;
        private System.Windows.Forms.Button buttonUpdateFlight;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox comboBoxUserGeneral;
        private System.Windows.Forms.ComboBox comboBoxFlightNumberUsers;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonRefreshUsers;
    }
}

