namespace Appointment
{
    partial class Login
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
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(189, 85);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(189, 125);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(69, 92);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(60, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User Name";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(69, 132);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(72, 205);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(214, 205);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(87, 54);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(202, 20);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Error: Incorrect login details";
            this.errorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserID";
            this.label1.Visible = false;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(189, 158);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 11;
            this.idBox.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(67, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(223, 29);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Siefring Scheduling";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(391, 264);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
		private System.Windows.Forms.Label titleLabel;
	}
}