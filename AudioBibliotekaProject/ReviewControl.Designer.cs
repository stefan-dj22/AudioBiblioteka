namespace AudioBibliotekaProject
{
    partial class ReviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.llblUser = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Location = new System.Drawing.Point(0, 0);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(596, 62);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // lblRate
            // 
            this.lblRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(15, 69);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(58, 17);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Ocena: ";
            // 
            // llblUser
            // 
            this.llblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llblUser.AutoSize = true;
            this.llblUser.Location = new System.Drawing.Point(504, 69);
            this.llblUser.Name = "llblUser";
            this.llblUser.Size = new System.Drawing.Size(58, 17);
            this.llblUser.TabIndex = 2;
            this.llblUser.TabStop = true;
            this.llblUser.Text = "Korisnik";
            this.llblUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUser_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // ReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.llblUser);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.rtbText);
            this.MinimumSize = new System.Drawing.Size(227, 99);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(596, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.LinkLabel llblUser;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
