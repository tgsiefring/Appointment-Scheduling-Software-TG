namespace Appointment
{
    partial class CityForm
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
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.cityView = new System.Windows.Forms.DataGridView();
			this.countryLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.cityLabel = new System.Windows.Forms.Label();
			this.cityBox = new System.Windows.Forms.TextBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.resetButton = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.cityView)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbCountry
			// 
			this.cmbCountry.FormattingEnabled = true;
			this.cmbCountry.Location = new System.Drawing.Point(37, 58);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(121, 21);
			this.cmbCountry.TabIndex = 0;
			this.cmbCountry.TextChanged += new System.EventHandler(this.CmbCountry_TextChanged);
			// 
			// cityView
			// 
			this.cityView.AllowUserToAddRows = false;
			this.cityView.AllowUserToDeleteRows = false;
			this.cityView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.cityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cityView.Location = new System.Drawing.Point(119, 12);
			this.cityView.MultiSelect = false;
			this.cityView.Name = "cityView";
			this.cityView.ReadOnly = true;
			this.cityView.RowHeadersVisible = false;
			this.cityView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.cityView.Size = new System.Drawing.Size(482, 230);
			this.cityView.TabIndex = 1;
			this.cityView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CityView_CellClick);
			this.cityView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CityView_DataBindingComplete);
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(116, 320);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(43, 13);
			this.countryLabel.TabIndex = 2;
			this.countryLabel.Text = "Country";
			// 
			// addButton
			// 
			this.addButton.Enabled = false;
			this.addButton.Location = new System.Drawing.Point(215, 360);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(116, 274);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(24, 13);
			this.cityLabel.TabIndex = 4;
			this.cityLabel.Text = "City";
			// 
			// cityBox
			// 
			this.cityBox.Location = new System.Drawing.Point(37, 20);
			this.cityBox.Name = "cityBox";
			this.cityBox.Size = new System.Drawing.Size(121, 20);
			this.cityBox.TabIndex = 5;
			this.cityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
			this.cityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(526, 254);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 6;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmbCountry);
			this.panel1.Controls.Add(this.cityBox);
			this.panel1.Location = new System.Drawing.Point(178, 254);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 7;
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(300, 389);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 8;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Enabled = false;
			this.updateButton.Location = new System.Drawing.Point(300, 360);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(14, 544);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 32;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(502, 432);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 31;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(258, 432);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 30;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(136, 432);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 29;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(14, 432);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 28;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(380, 432);
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
			this.panel2.Location = new System.Drawing.Point(2, 418);
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
			this.exitButton.Location = new System.Drawing.Point(526, 389);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 34;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// CityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(636, 672);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calendarButton);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.addressButton);
			this.Controls.Add(this.cityButton);
			this.Controls.Add(this.countryButton);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.countryLabel);
			this.Controls.Add(this.cityView);
			this.Name = "CityForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "City";
			this.Load += new System.EventHandler(this.City_Load);
			((System.ComponentModel.ISupportInitialize)(this.cityView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DataGridView cityView;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetButton;
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