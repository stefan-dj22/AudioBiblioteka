namespace AudioBibliotekaProject
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
            this.btnLoggIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.LinkLabel();
            this.btnGuest = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblWarnning = new System.Windows.Forms.Label();
            this.btnInitDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoggIn
            // 
            this.btnLoggIn.Location = new System.Drawing.Point(253, 226);
            this.btnLoggIn.Name = "btnLoggIn";
            this.btnLoggIn.Size = new System.Drawing.Size(180, 54);
            this.btnLoggIn.TabIndex = 0;
            this.btnLoggIn.Text = "Uloguj se";
            this.btnLoggIn.UseVisualStyleBackColor = true;
            this.btnLoggIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Location = new System.Drawing.Point(250, 293);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(83, 17);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.TabStop = true;
            this.btnRegister.Text = "Registruj se";
            this.btnRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRegister_LinkClicked);
            // 
            // btnGuest
            // 
            this.btnGuest.AutoSize = true;
            this.btnGuest.Location = new System.Drawing.Point(542, 445);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(113, 17);
            this.btnGuest.TabIndex = 4;
            this.btnGuest.TabStop = true;
            this.btnGuest.Text = "Pristupi kao gost";
            this.btnGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGuest_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lozinka:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(253, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(253, 167);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 22);
            this.txtPass.TabIndex = 8;
            // 
            // lblWarnning
            // 
            this.lblWarnning.AutoSize = true;
            this.lblWarnning.Location = new System.Drawing.Point(231, 192);
            this.lblWarnning.Name = "lblWarnning";
            this.lblWarnning.Size = new System.Drawing.Size(81, 17);
            this.lblWarnning.TabIndex = 9;
            this.lblWarnning.Text = "Upozorenje";
            // 
            // btnInitDB
            // 
            this.btnInitDB.Location = new System.Drawing.Point(32, 373);
            this.btnInitDB.Name = "btnInitDB";
            this.btnInitDB.Size = new System.Drawing.Size(213, 38);
            this.btnInitDB.TabIndex = 10;
            this.btnInitDB.Text = "Inizijalizacija baze";
            this.btnInitDB.UseVisualStyleBackColor = true;
            this.btnInitDB.Click += new System.EventHandler(this.btnInitDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 471);
            this.Controls.Add(this.btnInitDB);
            this.Controls.Add(this.lblWarnning);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLoggIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoggIn;
        private System.Windows.Forms.LinkLabel btnRegister;
        private System.Windows.Forms.LinkLabel btnGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblWarnning;
        private System.Windows.Forms.Button btnInitDB;
    }
}

