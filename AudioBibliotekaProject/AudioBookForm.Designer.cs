using System.Drawing;

namespace AudioBibliotekaProject
{
    partial class AudioBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioBookForm));
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNarator = new System.Windows.Forms.Label();
            this.lblPostedBy = new System.Windows.Forms.Label();
            this.lblOdobrio = new System.Windows.Forms.Label();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.lblContetnt = new System.Windows.Forms.Label();
            this.gbReview = new System.Windows.Forms.GroupBox();
            this.gbComments = new System.Windows.Forms.GroupBox();
            this.btnReviewBook = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.llblDownload = new System.Windows.Forms.LinkLabel();
            this.lblLike = new System.Windows.Forms.Label();
            this.lblDislike = new System.Windows.Forms.Label();
            this.btnReveiwNarator = new System.Windows.Forms.Button();
            this.gbNaratorReviews = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(12, 12);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(133, 115);
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(178, 12);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(79, 17);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Ime knjige: ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(178, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Autor: ";
            // 
            // lblNarator
            // 
            this.lblNarator.AutoSize = true;
            this.lblNarator.Location = new System.Drawing.Point(178, 67);
            this.lblNarator.Name = "lblNarator";
            this.lblNarator.Size = new System.Drawing.Size(64, 17);
            this.lblNarator.TabIndex = 3;
            this.lblNarator.Text = "Narator: ";
            // 
            // lblPostedBy
            // 
            this.lblPostedBy.AutoSize = true;
            this.lblPostedBy.Location = new System.Drawing.Point(178, 94);
            this.lblPostedBy.Name = "lblPostedBy";
            this.lblPostedBy.Size = new System.Drawing.Size(70, 17);
            this.lblPostedBy.TabIndex = 4;
            this.lblPostedBy.Text = "Postavio: ";
            // 
            // lblOdobrio
            // 
            this.lblOdobrio.AutoSize = true;
            this.lblOdobrio.Location = new System.Drawing.Point(178, 120);
            this.lblOdobrio.Name = "lblOdobrio";
            this.lblOdobrio.Size = new System.Drawing.Size(144, 17);
            this.lblOdobrio.TabIndex = 5;
            this.lblOdobrio.Text = "Odobreno od strane: ";
            // 
            // gbContent
            // 
            this.gbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContent.Controls.Add(this.lblContetnt);
            this.gbContent.Location = new System.Drawing.Point(12, 158);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(495, 64);
            this.gbContent.TabIndex = 6;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Kratki opis";
            // 
            // lblContetnt
            // 
            this.lblContetnt.AutoSize = true;
            this.lblContetnt.Location = new System.Drawing.Point(6, 18);
            this.lblContetnt.Name = "lblContetnt";
            this.lblContetnt.Size = new System.Drawing.Size(43, 17);
            this.lblContetnt.TabIndex = 0;
            this.lblContetnt.Text = "Tekst";
            // 
            // gbReview
            // 
            this.gbReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReview.Location = new System.Drawing.Point(12, 420);
            this.gbReview.Name = "gbReview";
            this.gbReview.Size = new System.Drawing.Size(495, 100);
            this.gbReview.TabIndex = 0;
            this.gbReview.TabStop = false;
            this.gbReview.Text = "Recenzije knjige";
            // 
            // gbComments
            // 
            this.gbComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbComments.Location = new System.Drawing.Point(5, 636);
            this.gbComments.Name = "gbComments";
            this.gbComments.Size = new System.Drawing.Size(495, 91);
            this.gbComments.TabIndex = 0;
            this.gbComments.TabStop = false;
            this.gbComments.Text = "Komentari";
            // 
            // btnReviewBook
            // 
            this.btnReviewBook.Location = new System.Drawing.Point(12, 247);
            this.btnReviewBook.Name = "btnReviewBook";
            this.btnReviewBook.Size = new System.Drawing.Size(230, 35);
            this.btnReviewBook.TabIndex = 7;
            this.btnReviewBook.Text = "Dodaj recenziju knjige";
            this.btnReviewBook.UseVisualStyleBackColor = true;
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(12, 326);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(230, 33);
            this.btnComment.TabIndex = 8;
            this.btnComment.Text = "Komentarisi";
            this.btnComment.UseVisualStyleBackColor = true;
            // 
            // btnLike
            // 
            this.btnLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLike.BackColor = System.Drawing.SystemColors.Control;
            this.btnLike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLike.BackgroundImage")));
            this.btnLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLike.Location = new System.Drawing.Point(324, 247);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 64);
            this.btnLike.TabIndex = 9;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDislike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDislike.BackgroundImage")));
            this.btnDislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDislike.Location = new System.Drawing.Point(432, 247);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(75, 64);
            this.btnDislike.TabIndex = 10;
            this.btnDislike.UseVisualStyleBackColor = true;
            this.btnDislike.Click += new System.EventHandler(this.btnDislike_Click);
            // 
            // llblDownload
            // 
            this.llblDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblDownload.AutoSize = true;
            this.llblDownload.Location = new System.Drawing.Point(435, 351);
            this.llblDownload.Name = "llblDownload";
            this.llblDownload.Size = new System.Drawing.Size(69, 17);
            this.llblDownload.TabIndex = 11;
            this.llblDownload.TabStop = true;
            this.llblDownload.Text = "PREUZMI";
            this.llblDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDownload_LinkClicked);
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.Location = new System.Drawing.Point(337, 314);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(46, 17);
            this.lblLike.TabIndex = 12;
            this.lblLike.Text = "label1";
            // 
            // lblDislike
            // 
            this.lblDislike.AutoSize = true;
            this.lblDislike.Location = new System.Drawing.Point(448, 314);
            this.lblDislike.Name = "lblDislike";
            this.lblDislike.Size = new System.Drawing.Size(46, 17);
            this.lblDislike.TabIndex = 13;
            this.lblDislike.Text = "label2";
            // 
            // btnReveiwNarator
            // 
            this.btnReveiwNarator.Location = new System.Drawing.Point(12, 288);
            this.btnReveiwNarator.Name = "btnReveiwNarator";
            this.btnReveiwNarator.Size = new System.Drawing.Size(230, 32);
            this.btnReveiwNarator.TabIndex = 14;
            this.btnReveiwNarator.Text = "Dodaj recenziju naratora";
            this.btnReveiwNarator.UseVisualStyleBackColor = true;
            // 
            // gbNaratorReviews
            // 
            this.gbNaratorReviews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNaratorReviews.Location = new System.Drawing.Point(5, 526);
            this.gbNaratorReviews.Name = "gbNaratorReviews";
            this.gbNaratorReviews.Size = new System.Drawing.Size(489, 92);
            this.gbNaratorReviews.TabIndex = 15;
            this.gbNaratorReviews.TabStop = false;
            this.gbNaratorReviews.Text = "Recenzije naratora";
            // 
            // AudioBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 794);
            this.Controls.Add(this.gbNaratorReviews);
            this.Controls.Add(this.btnReveiwNarator);
            this.Controls.Add(this.lblDislike);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.llblDownload);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnReviewBook);
            this.Controls.Add(this.gbReview);
            this.Controls.Add(this.gbComments);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.lblOdobrio);
            this.Controls.Add(this.lblPostedBy);
            this.Controls.Add(this.lblNarator);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pbCover);
            this.Name = "AudioBookForm";
            this.Text = "AudioBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.gbContent.ResumeLayout(false);
            this.gbContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNarator;
        private System.Windows.Forms.Label lblPostedBy;
        private System.Windows.Forms.Label lblOdobrio;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.Label lblContetnt;
        private System.Windows.Forms.GroupBox gbReview;
        private System.Windows.Forms.GroupBox gbComments;
        private System.Windows.Forms.Button btnReviewBook;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.LinkLabel llblDownload;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.Label lblDislike;
        private System.Windows.Forms.Button btnReveiwNarator;
        private System.Windows.Forms.GroupBox gbNaratorReviews;
    }
}