using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBibliotekaProject.Entieti;
using System.Windows.Forms;

namespace AudioBibliotekaProject
{
    public partial class ABKarticaControl : UserControl
    {
        public AudioBook Book { get; set; }
        public int index;
        public delegate void deleteBook(AudioBook book, int ind);
        public event deleteBook deleteBookEvent;
        public delegate void openBook(AudioBook book);
        public event openBook openBookEvent;
        bool adminAccess;

        public ABKarticaControl()
        {
            InitializeComponent();
        }
        public ABKarticaControl(AudioBook ab, bool aa,int i)
        {
            index = i;
            adminAccess = aa;
            Book = ab;
            Member user=mongoDB.GetCollection<Member>().FindOneById(Book.UpdatedBy.Id);
            if(user==null)
                user= mongoDB.GetCollection<Admin>().FindOneById(Book.UpdatedBy.Id);

            InitializeComponent();

            if (!adminAccess)
                btnDelete.Visible = false;
            llblName.Text = Book.Name;
            lblAuthor.Text = Book.Author;
            lblInfo.Text = "Posted: "+Book.DateUpdated.Date.ToString() + " by " + user.Name;
            if(Book.Cover!=null)
                {
                    pbCover.Image = Book.getImg();
                    pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
                }

        }

        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

                openBookEvent.Invoke(this.Book);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite izbrisati ovu knjigu", "Brisanje knjige", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                deleteBookEvent.Invoke(this.Book,index);
        }
    }
}
