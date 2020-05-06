namespace AudioBibliotekaProject
{
    partial class Registracija
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserNameWarning = new System.Windows.Forms.Label();
            this.lblPassWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(252, 188);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 42);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registruj se";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(41, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(41, 105);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 17);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Lozinka:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(159, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // lblUserNameWarning
            // 
            this.lblUserNameWarning.AutoSize = true;
            this.lblUserNameWarning.Location = new System.Drawing.Point(130, 71);
            this.lblUserNameWarning.Name = "lblUserNameWarning";
            this.lblUserNameWarning.Size = new System.Drawing.Size(64, 17);
            this.lblUserNameWarning.TabIndex = 5;
            this.lblUserNameWarning.Text = "Warning!";
            this.lblUserNameWarning.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassWarning
            // 
            this.lblPassWarning.AutoSize = true;
            this.lblPassWarning.Location = new System.Drawing.Point(130, 125);
            this.lblPassWarning.Name = "lblPassWarning";
            this.lblPassWarning.Size = new System.Drawing.Size(64, 17);
            this.lblPassWarning.TabIndex = 6;
            this.lblPassWarning.Text = "Warning!";
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 295);
            this.Controls.Add(this.lblPassWarning);
            this.Controls.Add(this.lblUserNameWarning);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegister);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserNameWarning;
        private System.Windows.Forms.Label lblPassWarning;
    }
}