namespace AudioBibliotekaProject
{
    partial class GlavniMeni
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
            this.btnEnterLib = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterLib
            // 
            this.btnEnterLib.Location = new System.Drawing.Point(159, 56);
            this.btnEnterLib.Name = "btnEnterLib";
            this.btnEnterLib.Size = new System.Drawing.Size(277, 89);
            this.btnEnterLib.TabIndex = 0;
            this.btnEnterLib.Text = "Pristupi biblioteci";
            this.btnEnterLib.UseVisualStyleBackColor = true;
            this.btnEnterLib.Click += new System.EventHandler(this.btnEnterLib_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(509, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Izalaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(159, 165);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(277, 89);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "Clanovi";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(159, 279);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(277, 85);
            this.btnInbox.TabIndex = 3;
            this.btnInbox.Text = "Sanduče";
            this.btnInbox.UseVisualStyleBackColor = true;
            // 
            // GlavniMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 447);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnterLib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GlavniMeni";
            this.Text = "GlavniMeni";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavniMeni_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterLib;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnInbox;
    }
}