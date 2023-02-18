namespace Appointment
{
    partial class ReportsForm
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
			this.appointmentReport = new System.Windows.Forms.TextBox();
			this.appointmentView = new System.Windows.Forms.DataGridView();
			this.cmbUser = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.appointmentLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.userLabel = new System.Windows.Forms.Label();
			this.customerLabel = new System.Windows.Forms.Label();
			this.addressLabel = new System.Windows.Forms.Label();
			this.countryLabel = new System.Windows.Forms.Label();
			this.cityLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
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
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// appointmentReport
			// 
			this.appointmentReport.Location = new System.Drawing.Point(12, 12);
			this.appointmentReport.Multiline = true;
			this.appointmentReport.Name = "appointmentReport";
			this.appointmentReport.ReadOnly = true;
			this.appointmentReport.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.appointmentReport.Size = new System.Drawing.Size(431, 311);
			this.appointmentReport.TabIndex = 10;
			// 
			// appointmentView
			// 
			this.appointmentView.AllowUserToAddRows = false;
			this.appointmentView.AllowUserToDeleteRows = false;
			this.appointmentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.appointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentView.Location = new System.Drawing.Point(15, 366);
			this.appointmentView.MultiSelect = false;
			this.appointmentView.Name = "appointmentView";
			this.appointmentView.ReadOnly = true;
			this.appointmentView.RowHeadersVisible = false;
			this.appointmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.appointmentView.Size = new System.Drawing.Size(719, 291);
			this.appointmentView.TabIndex = 11;
			// 
			// cmbUser
			// 
			this.cmbUser.FormattingEnabled = true;
			this.cmbUser.Location = new System.Drawing.Point(610, 339);
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.Size = new System.Drawing.Size(121, 21);
			this.cmbUser.TabIndex = 12;
			this.cmbUser.SelectedValueChanged += new System.EventHandler(this.CmbUser_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(551, 347);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "User ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(499, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Number of rows in tables:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(499, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Appointments:";
			// 
			// appointmentLabel
			// 
			this.appointmentLabel.AutoSize = true;
			this.appointmentLabel.Location = new System.Drawing.Point(637, 47);
			this.appointmentLabel.Name = "appointmentLabel";
			this.appointmentLabel.Size = new System.Drawing.Size(28, 13);
			this.appointmentLabel.TabIndex = 16;
			this.appointmentLabel.Text = "appt";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(499, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Addresses:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(499, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Cities:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(499, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Countries:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(499, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Customers:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(499, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Users:";
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point(637, 69);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(21, 13);
			this.userLabel.TabIndex = 22;
			this.userLabel.Text = "usr";
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Location = new System.Drawing.Point(637, 97);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(27, 13);
			this.customerLabel.TabIndex = 23;
			this.customerLabel.Text = "cust";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(637, 127);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(25, 13);
			this.addressLabel.TabIndex = 24;
			this.addressLabel.Text = "add";
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(637, 154);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(30, 13);
			this.countryLabel.TabIndex = 25;
			this.countryLabel.Text = "cntry";
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(637, 181);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(21, 13);
			this.cityLabel.TabIndex = 26;
			this.cityLabel.Text = "cty";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 347);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 13);
			this.label9.TabIndex = 27;
			this.label9.Text = "Appointments by User ID";
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(27, 789);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 33;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(515, 677);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 32;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(271, 677);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 31;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(149, 677);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 30;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(27, 677);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 29;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(393, 677);
			this.customerButton.Name = "customerButton";
			this.customerButton.Size = new System.Drawing.Size(116, 106);
			this.customerButton.TabIndex = 28;
			this.customerButton.Text = "Manage Customers";
			this.customerButton.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel2.Controls.Add(this.reportButton);
			this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Location = new System.Drawing.Point(15, 663);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(631, 252);
			this.panel2.TabIndex = 34;
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
			this.exitButton.Location = new System.Drawing.Point(662, 892);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 35;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(749, 749);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calendarButton);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.addressButton);
			this.Controls.Add(this.cityButton);
			this.Controls.Add(this.countryButton);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.countryLabel);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.appointmentLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbUser);
			this.Controls.Add(this.appointmentView);
			this.Controls.Add(this.appointmentReport);
			this.Name = "ReportsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Reports_Load);
			((System.ComponentModel.ISupportInitialize)(this.appointmentView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox appointmentReport;
        private System.Windows.Forms.DataGridView appointmentView;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label9;
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