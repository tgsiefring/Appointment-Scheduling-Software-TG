namespace Appointment
{
    partial class CalendarForm
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
			this.miniCalendar = new System.Windows.Forms.MonthCalendar();
			this.weekRadio = new System.Windows.Forms.RadioButton();
			this.monthRadio = new System.Windows.Forms.RadioButton();
			this.appointmentView = new System.Windows.Forms.DataGridView();
			this.allRadio = new System.Windows.Forms.RadioButton();
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
			// miniCalendar
			// 
			this.miniCalendar.Location = new System.Drawing.Point(32, 162);
			this.miniCalendar.Name = "miniCalendar";
			this.miniCalendar.TabIndex = 0;
			this.miniCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MiniCalendar_DateSelected);
			// 
			// weekRadio
			// 
			this.weekRadio.AutoSize = true;
			this.weekRadio.Location = new System.Drawing.Point(135, 55);
			this.weekRadio.Name = "weekRadio";
			this.weekRadio.Size = new System.Drawing.Size(54, 17);
			this.weekRadio.TabIndex = 1;
			this.weekRadio.Text = "Week";
			this.weekRadio.UseVisualStyleBackColor = true;
			this.weekRadio.CheckedChanged += new System.EventHandler(this.WeekRadio_CheckedChanged);
			// 
			// monthRadio
			// 
			this.monthRadio.AutoSize = true;
			this.monthRadio.Location = new System.Drawing.Point(74, 55);
			this.monthRadio.Name = "monthRadio";
			this.monthRadio.Size = new System.Drawing.Size(55, 17);
			this.monthRadio.TabIndex = 2;
			this.monthRadio.Text = "Month";
			this.monthRadio.UseVisualStyleBackColor = true;
			this.monthRadio.CheckedChanged += new System.EventHandler(this.MonthRadio_CheckedChanged);
			// 
			// appointmentView
			// 
			this.appointmentView.AllowUserToAddRows = false;
			this.appointmentView.AllowUserToDeleteRows = false;
			this.appointmentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.appointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentView.Location = new System.Drawing.Point(282, 33);
			this.appointmentView.MultiSelect = false;
			this.appointmentView.Name = "appointmentView";
			this.appointmentView.ReadOnly = true;
			this.appointmentView.RowHeadersVisible = false;
			this.appointmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.appointmentView.Size = new System.Drawing.Size(821, 383);
			this.appointmentView.TabIndex = 3;
			this.appointmentView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AppointmentView_CellFormatting);
			this.appointmentView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AppointmentView_DataBindingComplete);
			// 
			// allRadio
			// 
			this.allRadio.AutoSize = true;
			this.allRadio.Checked = true;
			this.allRadio.Location = new System.Drawing.Point(32, 55);
			this.allRadio.Name = "allRadio";
			this.allRadio.Size = new System.Drawing.Size(36, 17);
			this.allRadio.TabIndex = 4;
			this.allRadio.TabStop = true;
			this.allRadio.Text = "All";
			this.allRadio.UseVisualStyleBackColor = true;
			this.allRadio.CheckedChanged += new System.EventHandler(this.AllRadio_CheckedChanged);
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(294, 548);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 32;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(782, 436);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 31;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(538, 436);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 30;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(416, 436);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 29;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(294, 436);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 28;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(660, 436);
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
			this.panel2.Location = new System.Drawing.Point(282, 422);
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
			this.exitButton.Location = new System.Drawing.Point(1028, 639);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 34;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// CalendarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1028, 667);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calendarButton);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.addressButton);
			this.Controls.Add(this.cityButton);
			this.Controls.Add(this.countryButton);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.allRadio);
			this.Controls.Add(this.appointmentView);
			this.Controls.Add(this.monthRadio);
			this.Controls.Add(this.weekRadio);
			this.Controls.Add(this.miniCalendar);
			this.Name = "CalendarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calendar";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Calendar_Load);
			((System.ComponentModel.ISupportInitialize)(this.appointmentView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar miniCalendar;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.DataGridView appointmentView;
        private System.Windows.Forms.RadioButton allRadio;
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