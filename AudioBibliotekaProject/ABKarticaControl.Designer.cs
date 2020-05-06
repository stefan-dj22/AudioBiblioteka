namespace AudioBibliotekaProject
{
    partial class ABKarticaControl
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
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.llblName = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(12, 13);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(121, 122);
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // llblName
            // 
            this.llblName.AutoSize = true;
            this.llblName.Location = new System.Drawing.Point(139, 19);
            this.llblName.Name = "llblName";
            this.llblName.Size = new System.Drawing.Size(72, 17);
            this.llblName.TabIndex = 1;
            this.llblName.TabStop = true;
            this.llblName.Text = "linkLabel1";
            this.llblName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblName_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(139, 49);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(402, 118);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(46, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ABKarticaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.llblName);
            this.Controls.Add(this.pbCover);
            this.Name = "ABKarticaControl";
            this.Size = new System.Drawing.Size(619, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.LinkLabel llblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDelete;
    }
}
