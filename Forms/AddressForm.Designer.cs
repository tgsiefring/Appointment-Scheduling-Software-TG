namespace Appointment
{
    partial class AddressForm
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
			this.addressView = new System.Windows.Forms.DataGridView();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.cityLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.addressLabel = new System.Windows.Forms.Label();
			this.address2Label = new System.Windows.Forms.Label();
			this.zipLabel = new System.Windows.Forms.Label();
			this.phoneLabel = new System.Windows.Forms.Label();
			this.addressBox = new System.Windows.Forms.TextBox();
			this.address2Box = new System.Windows.Forms.TextBox();
			this.zipBox = new System.Windows.Forms.TextBox();
			this.phoneBox = new System.Windows.Forms.TextBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.updateButton = new System.Windows.Forms.Button();
			this.calendarButton = new System.Windows.Forms.Button();
			this.appointmentButton = new System.Windows.Forms.Button();
			this.addressButton = new System.Windows.Forms.Button();
			this.cityButton = new System.Windows.Forms.Button();
			this.countryButton = new System.Windows.Forms.Button();
			this.customerButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.reportButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.addressView)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// addressView
			// 
			this.addressView.AllowUserToAddRows = false;
			this.addressView.AllowUserToDeleteRows = false;
			this.addressView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.addressView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.addressView.Location = new System.Drawing.Point(380, 27);
			this.addressView.MultiSelect = false;
			this.addressView.Name = "addressView";
			this.addressView.ReadOnly = true;
			this.addressView.RowHeadersVisible = false;
			this.addressView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.addressView.Size = new System.Drawing.Size(515, 248);
			this.addressView.TabIndex = 0;
			this.addressView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressView_CellClick);
			this.addressView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AddressView_DataBindingComplete);
			// 
			// cmbCity
			// 
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(16, 96);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(121, 21);
			this.cmbCity.TabIndex = 1;
			this.cmbCity.TextChanged += new System.EventHandler(this.CmbCity_TextChanged);
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(38, 131);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(24, 13);
			this.cityLabel.TabIndex = 2;
			this.cityLabel.Text = "City";
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(98, 245);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(36, 50);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(45, 13);
			this.addressLabel.TabIndex = 4;
			this.addressLabel.Text = "Address";
			// 
			// address2Label
			// 
			this.address2Label.AutoSize = true;
			this.address2Label.Location = new System.Drawing.Point(38, 90);
			this.address2Label.Name = "address2Label";
			this.address2Label.Size = new System.Drawing.Size(54, 13);
			this.address2Label.TabIndex = 5;
			this.address2Label.Text = "Address 2";
			// 
			// zipLabel
			// 
			this.zipLabel.AutoSize = true;
			this.zipLabel.Location = new System.Drawing.Point(36, 169);
			this.zipLabel.Name = "zipLabel";
			this.zipLabel.Size = new System.Drawing.Size(50, 13);
			this.zipLabel.TabIndex = 6;
			this.zipLabel.Text = "Zip Code";
			// 
			// phoneLabel
			// 
			this.phoneLabel.AutoSize = true;
			this.phoneLabel.Location = new System.Drawing.Point(38, 207);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(48, 13);
			this.phoneLabel.TabIndex = 7;
			this.phoneLabel.Text = "Phone #";
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(16, 16);
			this.addressBox.Name = "addressBox";
			this.addressBox.Size = new System.Drawing.Size(121, 20);
			this.addressBox.TabIndex = 8;
			this.addressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
			this.addressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressBox_KeyPress);
			// 
			// address2Box
			// 
			this.address2Box.Location = new System.Drawing.Point(16, 56);
			this.address2Box.Name = "address2Box";
			this.address2Box.Size = new System.Drawing.Size(121, 20);
			this.address2Box.TabIndex = 9;
			// 
			// zipBox
			// 
			this.zipBox.Location = new System.Drawing.Point(16, 135);
			this.zipBox.Name = "zipBox";
			this.zipBox.Size = new System.Drawing.Size(121, 20);
			this.zipBox.TabIndex = 10;
			this.zipBox.TextChanged += new System.EventHandler(this.ZipBox_TextChanged);
			this.zipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipBox_KeyPress);
			// 
			// phoneBox
			// 
			this.phoneBox.Location = new System.Drawing.Point(16, 173);
			this.phoneBox.Name = "phoneBox";
			this.phoneBox.Size = new System.Drawing.Size(121, 20);
			this.phoneBox.TabIndex = 11;
			this.phoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
			this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(820, 281);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 12;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(190, 274);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 13;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.addressBox);
			this.panel1.Controls.Add(this.address2Box);
			this.panel1.Controls.Add(this.cmbCity);
			this.panel1.Controls.Add(this.phoneBox);
			this.panel1.Controls.Add(this.zipBox);
			this.panel1.Location = new System.Drawing.Point(98, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(167, 212);
			this.panel1.TabIndex = 14;
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(190, 245);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 15;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(177, 438);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 32;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(665, 326);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 31;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(421, 326);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 30;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(299, 326);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 29;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(177, 326);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 28;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(543, 326);
			this.customerButton.Name = "customerButton";
			this.customerButton.Size = new System.Drawing.Size(116, 106);
			this.customerButton.TabIndex = 27;
			this.customerButton.Text = "Manage Customers";
			this.customerButton.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel2.Controls.Add(this.reportButton);
			this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Location = new System.Drawing.Point(165, 312);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(631, 252);
			this.panel2.TabIndex = 33;
			// 
			// reportButton
			// 
			this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.reportButton.Location = new System.Drawing.Point(12, 186);
			this.reportButton.Name = "reportButton";
			this.reportButton.Size = new System.Drawing.Size(604, 54);
			this.reportButton.TabIndex = 27;
			this.reportButton.Text = "View Reports";
			this.reportButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(820, 541);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 34;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AddressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(923, 576);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calendarButton);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.addressButton);
			this.Controls.Add(this.cityButton);
			this.Controls.Add(this.countryButton);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.phoneLabel);
			this.Controls.Add(this.zipLabel);
			this.Controls.Add(this.address2Label);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.addressView);
			this.Name = "AddressForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Address";
			this.Load += new System.EventHandler(this.Address_Load);
			((System.ComponentModel.ISupportInitialize)(this.addressView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addressView;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button countryButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button exitButton;
    }
}