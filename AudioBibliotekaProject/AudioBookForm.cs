using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBibliotekaProject.Entieti;
using System.Windows.Forms;

namespace AudioBibliotekaProject
{
    public partial class AudioBookForm : Form
    {
        public Member Visitor { get; set; }
        public AudioBook Book { get; set; }
        public Member postedBy { get; set; }
        public Admin approvedBy { get; set; }
        public AudioBookForm()
        {
            InitializeComponent();
        }

        public AudioBookForm(AudioBook book, Member visitor)
        {
            InitializeComponent();
            Book = book;
            Visitor = visitor;
            postedBy = mongoDB.GetCollection<Member>().FindOneById(Book.UpdatedBy.Id);
            if(postedBy==null)
                mongoDB.GetCollection<Admin>().FindOneById(Book.UpdatedBy.Id);
            approvedBy= mongoDB.GetCollection<Admin>().FindOneById(Book.ApprovedBy.Id);
            InitBookFields();
            InitUserControls();
        }
        void InitBookFields()
        {
            if (Book.Cover != null)
                pbCover.Image = Book.getImg();
            lblBookName.Text += Book.Name;
            lblAuthor.Text += Book.Author;
            lblNarator.Text += Book.Naraor;
            lblPostedBy.Text += postedBy.Name;
            lblOdobrio.Text= approvedBy.Name;
            lblLike.Text = Book.Rating.Likes.ToString();
            lblDislike.Text = Book.Rating.Dislikes.ToString();
            lblContetnt.Text = Book.Descripiton;
            initGbComment();
            initGBReviews();
        }
        void initGbComment()
        {

        }
        void initGBReviews()
        {

        }
        void InitUserControls()
        {
            if (Visitor.isBanned())
            {
                btnComment.Enabled = false;
                disableVoting();
                btnReviewBook.Enabled = false;
            }
            else
            {
                if (Visitor.isReviewBook(Book))
                    btnReviewBook.Enabled = false;
                if (Visitor.isReviewNarator(Book))
                    btnReveiwNarator.Enabled = false;
                    
                if(Visitor.isRatedBook(Book))
                {
                    disableVoting();
                }
            }
        }
        void disableVoting()
        {
            btnLike.Enabled = false;
            btnDislike.Enabled = false;
        }

        private void llblDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo finfo = new System.IO.FileInfo(sfd.FileName);
                Book.Download(finfo.FullName);
            }
            
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            Visitor.rateAB(Book, true);
            int likes = Int32.Parse(lblLike.Text) + 1;
            lblLike.Text = likes.ToString();
            disableVoting();
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            Visitor.rateAB(Book, true);
            int dislike = Int32.Parse(lblDislike.Text) + 1;
            lblLike.Text = dislike.ToString();
            disableVoting();
        }
    }
}
