namespace Appointment
{
    partial class AppointmentForm
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
			this.appointmentView = new System.Windows.Forms.DataGridView();
			this.cmbUser = new System.Windows.Forms.ComboBox();
			this.customerLabel = new System.Windows.Forms.Label();
			this.userLabel = new System.Windows.Forms.Label();
			this.customerBox = new System.Windows.Forms.TextBox();
			this.customerView = new System.Windows.Forms.DataGridView();
			this.selectLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.typeBox = new System.Windows.Forms.TextBox();
			this.startPicker = new System.Windows.Forms.DateTimePicker();
			this.endPicker = new System.Windows.Forms.DateTimePicker();
			this.startLabel = new System.Windows.Forms.Label();
			this.endLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.select2Label = new System.Windows.Forms.Label();
			this.calendarButton = new System.Windows.Forms.Button();
			this.appointmentButton = new System.Windows.Forms.Button();
			this.addressButton = new System.Windows.Forms.Button();
			this.cityButton = new System.Windows.Forms.Button();
			this.countryButton = new System.Windows.Forms.Button();
			this.customerButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.reportButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.appointmentView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// appointmentView
			// 
			this.appointmentView.AllowUserToAddRows = false;
			this.appointmentView.AllowUserToDeleteRows = false;
			this.appointmentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.appointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentView.Location = new System.Drawing.Point(12, 12);
			this.appointmentView.MultiSelect = false;
			this.appointmentView.Name = "appointmentView";
			this.appointmentView.ReadOnly = true;
			this.appointmentView.RowHeadersVisible = false;
			this.appointmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.appointmentView.Size = new System.Drawing.Size(715, 277);
			this.appointmentView.TabIndex = 0;
			this.appointmentView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentView_CellClick);
			this.appointmentView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AppointmentView_CellFormatting);
			this.appointmentView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AppointmentView_DataBindingComplete);
			// 
			// cmbUser
			// 
			this.cmbUser.FormattingEnabled = true;
			this.cmbUser.Location = new System.Drawing.Point(864, 430);
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.Size = new System.Drawing.Size(121, 21);
			this.cmbUser.TabIndex = 2;
			this.cmbUser.SelectedValueChanged += new System.EventHandler(this.CmbUser_SelectedValueChanged);
			this.cmbUser.TextChanged += new System.EventHandler(this.CmbUser_TextChanged);
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Location = new System.Drawing.Point(767, 396);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(65, 13);
			this.customerLabel.TabIndex = 3;
			this.customerLabel.Text = "Customer ID";
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point(767, 438);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(43, 13);
			this.userLabel.TabIndex = 4;
			this.userLabel.Text = "User ID";
			// 
			// customerBox
			// 
			this.customerBox.Location = new System.Drawing.Point(864, 389);
			this.customerBox.Name = "customerBox";
			this.customerBox.ReadOnly = true;
			this.customerBox.Size = new System.Drawing.Size(121, 20);
			this.customerBox.TabIndex = 5;
			this.customerBox.TextChanged += new System.EventHandler(this.CustomerBox_TextChanged);
			// 
			// customerView
			// 
			this.customerView.AllowUserToAddRows = false;
			this.customerView.AllowUserToDeleteRows = false;
			this.customerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerView.Location = new System.Drawing.Point(12, 372);
			this.customerView.MultiSelect = false;
			this.customerView.Name = "customerView";
			this.customerView.ReadOnly = true;
			this.customerView.RowHeadersVisible = false;
			this.customerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.customerView.Size = new System.Drawing.Size(715, 275);
			this.customerView.TabIndex = 6;
			this.customerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerView_CellClick);
			this.customerView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CustomerView_DataBindingComplete);
			// 
			// selectLabel
			// 
			this.selectLabel.AutoSize = true;
			this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectLabel.Location = new System.Drawing.Point(284, 341);
			this.selectLabel.Name = "selectLabel";
			this.selectLabel.Size = new System.Drawing.Size(148, 24);
			this.selectLabel.TabIndex = 7;
			this.selectLabel.Text = "Select Customer";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(767, 479);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(31, 13);
			this.typeLabel.TabIndex = 8;
			this.typeLabel.Text = "Type";
			// 
			// typeBox
			// 
			this.typeBox.Location = new System.Drawing.Point(864, 472);
			this.typeBox.Name = "typeBox";
			this.typeBox.Size = new System.Drawing.Size(121, 20);
			this.typeBox.TabIndex = 9;
			this.typeBox.TextChanged += new System.EventHandler(this.TypeBox_TextChanged);
			this.typeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeBox_KeyPress);
			// 
			// startPicker
			// 
			this.startPicker.Checked = false;
			this.startPicker.CustomFormat = "";
			this.startPicker.Location = new System.Drawing.Point(26, 214);
			this.startPicker.Name = "startPicker";
			this.startPicker.Size = new System.Drawing.Size(200, 20);
			this.startPicker.TabIndex = 10;
			// 
			// endPicker
			// 
			this.endPicker.Location = new System.Drawing.Point(864, 581);
			this.endPicker.Name = "endPicker";
			this.endPicker.Size = new System.Drawing.Size(200, 20);
			this.endPicker.TabIndex = 11;
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(764, 562);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(29, 13);
			this.startLabel.TabIndex = 12;
			this.startLabel.Text = "Start";
			// 
			// endLabel
			// 
			this.endLabel.AutoSize = true;
			this.endLabel.Location = new System.Drawing.Point(767, 588);
			this.endLabel.Name = "endLabel";
			this.endLabel.Size = new System.Drawing.Size(26, 13);
			this.endLabel.TabIndex = 13;
			this.endLabel.Text = "End";
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(838, 624);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 14;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(919, 624);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 15;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(652, 295);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 16;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(1000, 624);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 17;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.select2Label);
			this.panel1.Controls.Add(this.startPicker);
			this.panel1.Location = new System.Drawing.Point(838, 341);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(281, 277);
			this.panel1.TabIndex = 18;
			// 
			// select2Label
			// 
			this.select2Label.AutoSize = true;
			this.select2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.select2Label.ForeColor = System.Drawing.Color.Red;
			this.select2Label.Location = new System.Drawing.Point(3, 29);
			this.select2Label.Name = "select2Label";
			this.select2Label.Size = new System.Drawing.Size(269, 16);
			this.select2Label.TabIndex = 26;
			this.select2Label.Text = "<-- Please select a customer or appointment";
			this.select2Label.Visible = false;
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(760, 138);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 32;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(1248, 26);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 31;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(1004, 26);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 30;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(882, 26);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 29;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(760, 26);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 28;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(1126, 26);
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
			this.panel2.Location = new System.Drawing.Point(748, 12);
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
			this.exitButton.Location = new System.Drawing.Point(1289, 624);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 34;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AppointmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1028, 659);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calendarButton);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.addressButton);
			this.Controls.Add(this.cityButton);
			this.Controls.Add(this.countryButton);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.endLabel);
			this.Controls.Add(this.startLabel);
			this.Controls.Add(this.endPicker);
			this.Controls.Add(this.typeBox);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.selectLabel);
			this.Controls.Add(this.customerView);
			this.Controls.Add(this.customerBox);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.cmbUser);
			this.Controls.Add(this.appointmentView);
			this.Controls.Add(this.panel1);
			this.Name = "AppointmentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Appointment";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Appointment_Load);
			((System.ComponentModel.ISupportInitialize)(this.appointmentView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentView;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label select2Label;
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