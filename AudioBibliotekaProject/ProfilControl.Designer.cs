
namespace AudioBibliotekaProject
{
    partial class ProfilControl
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
            this.btnBooksApproved = new System.Windows.Forms.Button();
            this.btnUploadBook = new System.Windows.Forms.Button();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gboxInfo = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.LinkLabel();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.gbActivitiInfo = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDislike = new System.Windows.Forms.Label();
            this.lblLike = new System.Windows.Forms.Label();
            this.picDislike = new System.Windows.Forms.PictureBox();
            this.picLike = new System.Windows.Forms.PictureBox();
            this.gboxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.gbActivitiInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDislike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLike)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBooksApproved
            // 
            this.btnBooksApproved.Location = new System.Drawing.Point(9, 265);
            this.btnBooksApproved.Name = "btnBooksApproved";
            this.btnBooksApproved.Size = new System.Drawing.Size(152, 51);
            this.btnBooksApproved.TabIndex = 22;
            this.btnBooksApproved.Text = "Odobrene knjige";
            this.btnBooksApproved.UseVisualStyleBackColor = true;
            // 
            // btnUploadBook
            // 
            this.btnUploadBook.Location = new System.Drawing.Point(9, 201);
            this.btnUploadBook.Name = "btnUploadBook";
            this.btnUploadBook.Size = new System.Drawing.Size(152, 41);
            this.btnUploadBook.TabIndex = 20;
            this.btnUploadBook.Text = "Dodaj knjigu";
            this.btnUploadBook.UseVisualStyleBackColor = true;
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Location = new System.Drawing.Point(9, 152);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(152, 43);
            this.btnUploadPic.TabIndex = 15;
            this.btnUploadPic.Text = "Dodaj sliku";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click_1);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(189, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 17);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "korisnicko ime";
            // 
            // gboxInfo
            // 
            this.gboxInfo.Controls.Add(this.btnCancle);
            this.gboxInfo.Controls.Add(this.btnSave);
            this.gboxInfo.Controls.Add(this.lblChange);
            this.gboxInfo.Controls.Add(this.txtSurname);
            this.gboxInfo.Controls.Add(this.txtName);
            this.gboxInfo.Controls.Add(this.lblSurname);
            this.gboxInfo.Controls.Add(this.lblName);
            this.gboxInfo.Location = new System.Drawing.Point(192, 75);
            this.gboxInfo.Name = "gboxInfo";
            this.gboxInfo.Size = new System.Drawing.Size(416, 154);
            this.gboxInfo.TabIndex = 13;
            this.gboxInfo.TabStop = false;
            this.gboxInfo.Text = "Osnovne inforacije";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(324, 113);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(86, 23);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "Otkaži";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(362, 18);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(48, 17);
            this.lblChange.TabIndex = 4;
            this.lblChange.TabStop = true;
            this.lblChange.Text = "Izmeni";
            this.lblChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChange_LinkClicked_1);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(122, 74);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(180, 22);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(48, 77);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(63, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prezime:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(9, 9);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(152, 134);
            this.picUser.TabIndex = 12;
            this.picUser.TabStop = false;
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.Location = new System.Drawing.Point(18, 21);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(135, 51);
            this.btnBookInfo.TabIndex = 0;
            this.btnBookInfo.Text = "Postavljene knjige";
            this.btnBookInfo.UseVisualStyleBackColor = true;
            // 
            // gbActivitiInfo
            // 
            this.gbActivitiInfo.Controls.Add(this.button3);
            this.gbActivitiInfo.Controls.Add(this.button2);
            this.gbActivitiInfo.Controls.Add(this.btnBookInfo);
            this.gbActivitiInfo.Location = new System.Drawing.Point(192, 244);
            this.gbActivitiInfo.Name = "gbActivitiInfo";
            this.gbActivitiInfo.Size = new System.Drawing.Size(170, 188);
            this.gbActivitiInfo.TabIndex = 21;
            this.gbActivitiInfo.TabStop = false;
            this.gbActivitiInfo.Text = "Aktivnosti";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Komentarisane knjige";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Recenzovane knjige";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblDislike
            // 
            this.lblDislike.AutoSize = true;
            this.lblDislike.Location = new System.Drawing.Point(537, 338);
            this.lblDislike.Name = "lblDislike";
            this.lblDislike.Size = new System.Drawing.Size(47, 17);
            this.lblDislike.TabIndex = 19;
            this.lblDislike.Text = "dislike";
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Location = new System.Drawing.Point(438, 338);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(29, 17);
            this.lblLike.TabIndex = 18;
            this.lblLike.Text = "like";
            // 
            // picDislike
            // 
            this.picDislike.Location = new System.Drawing.Point(522, 244);
            this.picDislike.Name = "picDislike";
            this.picDislike.Size = new System.Drawing.Size(86, 72);
            this.picDislike.TabIndex = 17;
            this.picDislike.TabStop = false;
            // 
            // picLike
            // 
            this.picLike.Location = new System.Drawing.Point(406, 244);
            this.picLike.Name = "picLike";
            this.picLike.Size = new System.Drawing.Size(88, 72);
            this.picLike.TabIndex = 16;
            this.picLike.TabStop = false;
            // 
            // ProfilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBooksApproved);
            this.Controls.Add(this.btnUploadBook);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.gboxInfo);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.gbActivitiInfo);
            this.Controls.Add(this.lblDislike);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.picDislike);
            this.Controls.Add(this.picLike);
            this.Name = "ProfilControl";
            this.Size = new System.Drawing.Size(644, 472);
            this.gboxInfo.ResumeLayout(false);
            this.gboxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.gbActivitiInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDislike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBooksApproved;
        private System.Windows.Forms.Button btnUploadBook;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gboxInfo;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lblChange;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.GroupBox gbActivitiInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDislike;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.PictureBox picDislike;
        private System.Windows.Forms.PictureBox picLike;
    }
}
