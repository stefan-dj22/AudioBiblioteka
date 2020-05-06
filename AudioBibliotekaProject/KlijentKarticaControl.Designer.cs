using System.Drawing;

namespace AudioBibliotekaProject
    
{
    partial class KlijentKarticaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlijentKarticaControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llblUName = new System.Windows.Forms.LinkLabel();
            this.btnMsg = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // llblUName
            // 
            this.llblUName.AutoSize = true;
            this.llblUName.Location = new System.Drawing.Point(132, 12);
            this.llblUName.Name = "llblUName";
            this.llblUName.Size = new System.Drawing.Size(73, 17);
            this.llblUName.TabIndex = 1;
            this.llblUName.TabStop = true;
            this.llblUName.Text = "userName";
            this.llblUName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUName_LinkClicked);
            // 
            // btnMsg
            // 
            this.btnMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMsg.BackgroundImage")));
            this.btnMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMsg.Location = new System.Drawing.Point(463, 12);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(64, 49);
            this.btnMsg.TabIndex = 2;
            this.btnMsg.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(481, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(570, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // KlijentKarticaControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnMsg);
            this.Controls.Add(this.llblUName);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(0, 117);
            this.MinimumSize = new System.Drawing.Size(283, 117);
            this.Name = "KlijentKarticaControl";
            this.Size = new System.Drawing.Size(608, 117);
            this.Load += new System.EventHandler(this.KlijentKarticaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblUName;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDelete;
    }
}
