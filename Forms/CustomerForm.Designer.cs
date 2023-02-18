namespace Appointment
{
    partial class CustomerForm
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
			this.customerView = new System.Windows.Forms.DataGridView();
			this.nameLabel = new System.Windows.Forms.Label();
			this.addressLabel = new System.Windows.Forms.Label();
			this.address2Label = new System.Windows.Forms.Label();
			this.cityLabel = new System.Windows.Forms.Label();
			this.zipLabel = new System.Windows.Forms.Label();
			this.countryLabel = new System.Windows.Forms.Label();
			this.phoneLabel = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.address2Box = new System.Windows.Forms.TextBox();
			this.cityBox = new System.Windows.Forms.TextBox();
			this.zipBox = new System.Windows.Forms.TextBox();
			this.countryBox = new System.Windows.Forms.TextBox();
			this.phoneBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.addressBox = new System.Windows.Forms.TextBox();
			this.addressView = new System.Windows.Forms.DataGridView();
			this.saLabel = new System.Windows.Forms.Label();
			this.addressidLabel = new System.Windows.Forms.Label();
			this.addressidBox = new System.Windows.Forms.TextBox();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.selectLabel = new System.Windows.Forms.Label();
			this.calendarButton = new System.Windows.Forms.Button();
			this.appointmentButton = new System.Windows.Forms.Button();
			this.addressButton = new System.Windows.Forms.Button();
			this.cityButton = new System.Windows.Forms.Button();
			this.countryButton = new System.Windows.Forms.Button();
			this.customerButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.reportButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressView)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerView
			// 
			this.customerView.AllowUserToAddRows = false;
			this.customerView.AllowUserToDeleteRows = false;
			this.customerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerView.Location = new System.Drawing.Point(37, 26);
			this.customerView.MultiSelect = false;
			this.customerView.Name = "customerView";
			this.customerView.ReadOnly = true;
			this.customerView.RowHeadersVisible = false;
			this.customerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.customerView.Size = new System.Drawing.Size(698, 271);
			this.customerView.TabIndex = 0;
			this.customerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerView_CellClick);
			this.customerView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CustomerView_DataBindingComplete);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(34, 325);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Name";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(34, 427);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(45, 13);
			this.addressLabel.TabIndex = 2;
			this.addressLabel.Text = "Address";
			// 
			// address2Label
			// 
			this.address2Label.AutoSize = true;
			this.address2Label.Location = new System.Drawing.Point(34, 480);
			this.address2Label.Name = "address2Label";
			this.address2Label.Size = new System.Drawing.Size(54, 13);
			this.address2Label.TabIndex = 3;
			this.address2Label.Text = "Address 2";
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(34, 530);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(24, 13);
			this.cityLabel.TabIndex = 4;
			this.cityLabel.Text = "City";
			// 
			// zipLabel
			// 
			this.zipLabel.AutoSize = true;
			this.zipLabel.Location = new System.Drawing.Point(34, 577);
			this.zipLabel.Name = "zipLabel";
			this.zipLabel.Size = new System.Drawing.Size(50, 13);
			this.zipLabel.TabIndex = 5;
			this.zipLabel.Text = "Zip Code";
			// 
			// countryLabel
			// 
			this.countryLabel.AutoSize = true;
			this.countryLabel.Location = new System.Drawing.Point(34, 623);
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Size = new System.Drawing.Size(43, 13);
			this.countryLabel.TabIndex = 6;
			this.countryLabel.Text = "Country";
			// 
			// phoneLabel
			// 
			this.phoneLabel.AutoSize = true;
			this.phoneLabel.Location = new System.Drawing.Point(34, 666);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(48, 13);
			this.phoneLabel.TabIndex = 7;
			this.phoneLabel.Text = "Phone #";
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(134, 318);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(170, 20);
			this.nameBox.TabIndex = 8;
			this.nameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
			this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
			// 
			// address2Box
			// 
			this.address2Box.Location = new System.Drawing.Point(134, 473);
			this.address2Box.Name = "address2Box";
			this.address2Box.ReadOnly = true;
			this.address2Box.Size = new System.Drawing.Size(170, 20);
			this.address2Box.TabIndex = 10;
			// 
			// cityBox
			// 
			this.cityBox.Location = new System.Drawing.Point(134, 523);
			this.cityBox.Name = "cityBox";
			this.cityBox.ReadOnly = true;
			this.cityBox.Size = new System.Drawing.Size(170, 20);
			this.cityBox.TabIndex = 11;
			// 
			// zipBox
			// 
			this.zipBox.Location = new System.Drawing.Point(134, 570);
			this.zipBox.Name = "zipBox";
			this.zipBox.ReadOnly = true;
			this.zipBox.Size = new System.Drawing.Size(170, 20);
			this.zipBox.TabIndex = 12;
			// 
			// countryBox
			// 
			this.countryBox.Location = new System.Drawing.Point(134, 616);
			this.countryBox.Name = "countryBox";
			this.countryBox.ReadOnly = true;
			this.countryBox.Size = new System.Drawing.Size(170, 20);
			this.countryBox.TabIndex = 13;
			// 
			// phoneBox
			// 
			this.phoneBox.Location = new System.Drawing.Point(134, 659);
			this.phoneBox.Name = "phoneBox";
			this.phoneBox.ReadOnly = true;
			this.phoneBox.Size = new System.Drawing.Size(170, 20);
			this.phoneBox.TabIndex = 14;
			// 
			// addButton
			// 
			this.addButton.Enabled = false;
			this.addButton.Location = new System.Drawing.Point(120, 701);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 15;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// addressBox
			// 
			this.addressBox.Location = new System.Drawing.Point(134, 420);
			this.addressBox.Name = "addressBox";
			this.addressBox.ReadOnly = true;
			this.addressBox.Size = new System.Drawing.Size(170, 20);
			this.addressBox.TabIndex = 17;
			// 
			// addressView
			// 
			this.addressView.AllowUserToAddRows = false;
			this.addressView.AllowUserToDeleteRows = false;
			this.addressView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.addressView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.addressView.Location = new System.Drawing.Point(470, 362);
			this.addressView.MultiSelect = false;
			this.addressView.Name = "addressView";
			this.addressView.ReadOnly = true;
			this.addressView.RowHeadersVisible = false;
			this.addressView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.addressView.Size = new System.Drawing.Size(525, 307);
			this.addressView.TabIndex = 18;
			this.addressView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressView_CellClick);
			this.addressView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AddressView_DataBindingComplete);
			// 
			// saLabel
			// 
			this.saLabel.AutoSize = true;
			this.saLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saLabel.Location = new System.Drawing.Point(466, 325);
			this.saLabel.Name = "saLabel";
			this.saLabel.Size = new System.Drawing.Size(137, 24);
			this.saLabel.TabIndex = 19;
			this.saLabel.Text = "Select Address";
			// 
			// addressidLabel
			// 
			this.addressidLabel.AutoSize = true;
			this.addressidLabel.Location = new System.Drawing.Point(34, 374);
			this.addressidLabel.Name = "addressidLabel";
			this.addressidLabel.Size = new System.Drawing.Size(59, 13);
			this.addressidLabel.TabIndex = 20;
			this.addressidLabel.Text = "Address ID";
			// 
			// addressidBox
			// 
			this.addressidBox.Location = new System.Drawing.Point(134, 367);
			this.addressidBox.Name = "addressidBox";
			this.addressidBox.ReadOnly = true;
			this.addressidBox.Size = new System.Drawing.Size(170, 20);
			this.addressidBox.TabIndex = 21;
			this.addressidBox.TextChanged += new System.EventHandler(this.AddressidBox_TextChanged);
			// 
			// updateButton
			// 
			this.updateButton.Enabled = false;
			this.updateButton.Location = new System.Drawing.Point(245, 701);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 22;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(660, 303);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 23;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(245, 730);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 24;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.selectLabel);
			this.panel1.Location = new System.Drawing.Point(120, 303);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 392);
			this.panel1.TabIndex = 25;
			// 
			// selectLabel
			// 
			this.selectLabel.AutoSize = true;
			this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectLabel.ForeColor = System.Drawing.Color.Red;
			this.selectLabel.Location = new System.Drawing.Point(11, 87);
			this.selectLabel.Name = "selectLabel";
			this.selectLabel.Size = new System.Drawing.Size(179, 16);
			this.selectLabel.TabIndex = 33;
			this.selectLabel.Text = "Please select an address -->";
			this.selectLabel.Visible = false;
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(376, 801);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 32;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(864, 689);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 31;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(620, 689);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 30;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(498, 689);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 29;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(376, 689);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 28;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(742, 689);
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
			this.panel2.Location = new System.Drawing.Point(364, 675);
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
			this.exitButton.Location = new System.Drawing.Point(245, 904);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 34;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1021, 749);
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
			this.Controls.Add(this.addressidBox);
			this.Controls.Add(this.addressidLabel);
			this.Controls.Add(this.saLabel);
			this.Controls.Add(this.addressView);
			this.Controls.Add(this.addressBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.phoneBox);
			this.Controls.Add(this.countryBox);
			this.Controls.Add(this.zipBox);
			this.Controls.Add(this.cityBox);
			this.Controls.Add(this.address2Box);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.phoneLabel);
			this.Controls.Add(this.countryLabel);
			this.Controls.Add(this.zipLabel);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.address2Label);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.customerView);
			this.Controls.Add(this.panel1);
			this.Name = "CustomerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Customer_Load);
			((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.DataGridView addressView;
        private System.Windows.Forms.Label saLabel;
        private System.Windows.Forms.Label addressidLabel;
        private System.Windows.Forms.TextBox addressidBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectLabel;
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