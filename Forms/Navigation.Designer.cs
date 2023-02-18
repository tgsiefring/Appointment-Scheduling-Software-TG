namespace Appointment
{
    partial class Navigation
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
			this.customerButton = new System.Windows.Forms.Button();
			this.countryButton = new System.Windows.Forms.Button();
			this.cityButton = new System.Windows.Forms.Button();
			this.addressButton = new System.Windows.Forms.Button();
			this.appointmentButton = new System.Windows.Forms.Button();
			this.calendarButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Button();
			this.reportButton = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(378, 12);
			this.customerButton.Name = "customerButton";
			this.customerButton.Size = new System.Drawing.Size(116, 106);
			this.customerButton.TabIndex = 1;
			this.customerButton.Text = "Manage Customers";
			this.customerButton.UseVisualStyleBackColor = true;
			// 
			// countryButton
			// 
			this.countryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countryButton.Location = new System.Drawing.Point(12, 12);
			this.countryButton.Name = "countryButton";
			this.countryButton.Size = new System.Drawing.Size(116, 106);
			this.countryButton.TabIndex = 2;
			this.countryButton.Text = "Manage Countries";
			this.countryButton.UseVisualStyleBackColor = true;
			// 
			// cityButton
			// 
			this.cityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityButton.Location = new System.Drawing.Point(134, 12);
			this.cityButton.Name = "cityButton";
			this.cityButton.Size = new System.Drawing.Size(116, 106);
			this.cityButton.TabIndex = 3;
			this.cityButton.Text = "Manage Cities";
			this.cityButton.UseVisualStyleBackColor = true;
			// 
			// addressButton
			// 
			this.addressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressButton.Location = new System.Drawing.Point(256, 12);
			this.addressButton.Name = "addressButton";
			this.addressButton.Size = new System.Drawing.Size(116, 106);
			this.addressButton.TabIndex = 4;
			this.addressButton.Text = "Manage Addresses";
			this.addressButton.UseVisualStyleBackColor = true;
			// 
			// appointmentButton
			// 
			this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentButton.Location = new System.Drawing.Point(500, 12);
			this.appointmentButton.Name = "appointmentButton";
			this.appointmentButton.Size = new System.Drawing.Size(116, 106);
			this.appointmentButton.TabIndex = 5;
			this.appointmentButton.Text = "Manage Appointments";
			this.appointmentButton.UseVisualStyleBackColor = true;
			// 
			// calendarButton
			// 
			this.calendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarButton.Location = new System.Drawing.Point(12, 124);
			this.calendarButton.Name = "calendarButton";
			this.calendarButton.Size = new System.Drawing.Size(604, 54);
			this.calendarButton.TabIndex = 6;
			this.calendarButton.Text = "View Calendar";
			this.calendarButton.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel2.Controls.Add(this.exitButton);
			this.panel2.Controls.Add(this.reportButton);
			this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Location = new System.Drawing.Point(0, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(619, 300);
			this.panel2.TabIndex = 26;
			// 
			// exitButton
			// 
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.exitButton.Location = new System.Drawing.Point(12, 243);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(604, 54);
			this.exitButton.TabIndex = 27;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
			// Navigation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 302);
			this.Controls.Add(this.calendarButton);
			this.Controls.Add(this.appointmentButton);
			this.Controls.Add(this.addressButton);
			this.Controls.Add(this.cityButton);
			this.Controls.Add(this.countryButton);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.panel2);
			this.Name = "Navigation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Navigation_Load);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button countryButton;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button exitButton;
    }
}

