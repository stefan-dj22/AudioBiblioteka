using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBibliotekaProject.Entieti;
using MongoDB.Driver.Builders;
using MongoDB.Driver;
using System.Windows.Forms;

namespace AudioBibliotekaProject
{
    public partial class BookListControl : UserControl
    {
        public Member User { get; set; }
        public List<AudioBook> books { get; set; }
        public List<AudioBook> findedBooks { get; set; }
        string criteria;
        int space = 5;
        int showNum = 20;
        long pageNum;
        public BookListControl()
        {
            InitializeComponent();
        }

        public BookListControl(Member user)
        {
            this.InitializeComponent();
            User = user;
            initDefault();
        }
        void initPanel()
        {

            if (books == null)
                return;

            bool adminAcess = false;

            if (this.User.GetType() == typeof(Admin))
            {
                adminAcess = true;
            }

            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            addControls(adminAcess);
        }


        void addControls(bool adminAccess)
        {

            
            ABKarticaControl content;
            ABKarticaControl prev;
            foreach (AudioBook ab in books)
            {

                content = new ABKarticaControl (ab,adminAccess,panel1.Controls.Count);
                content.deleteBookEvent +=this.deleteBook;
                content.openBookEvent += this.openBook; 
                this.panel1.Controls.Add(content);
                if (panel1.Controls.Count == 1)
                {
                    content.Location = new Point(0, 0);
                }
                else
                {
                    prev = (ABKarticaControl)this.panel1.Controls[panel1.Controls.Count - 2];
                    content.Location = new Point(0, prev.Location.Y + prev.Height + space);
                }
                content.Width = panel1.Width;
                content.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));

            }
        }
        void deleteBook(AudioBook book,int index)
        {
            book.Delete();
            ABKarticaControl tmp;
            panel1.Controls.RemoveAt(index);
            for(int i=index+1; i<panel1.Controls.Count; i++)
            {
                tmp = (ABKarticaControl)panel1.Controls[i];
                tmp.Location = new Point(0, tmp.Location.Y - tmp.Height - space);
                tmp.index = i - 1;
            }
            

        }
        void openBook(AudioBook book)
        {

        }
        void RefreshPanel()
        {
            if (findedBooks == null)
            {
                books = mongoDB.GetCollection<AudioBook>().FindAll().SetSkip(cbxPage.SelectedIndex * showNum).SetLimit(showNum).ToList<AudioBook>();
            }
            else
            {
                books = findedBooks.GetRange(cbxPage.SelectedIndex * showNum, showNum);
            }
            initPanel();
        }
        private void cbxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPanel();
        }

        private void cbxCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCriteria.SelectedIndex)
            {
                case 1:
                    criteria = "Name";
                    break;
                case 2:
                    criteria = "Author";
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
        void initCbxPage()
        {
            for (int i = 1; i <= pageNum; i++)
                cbxPage.Items.Add(i);
            if (cbxPage.SelectedIndex != -1)
                cbxPage.SelectedIndex =0;
  
        }
        void initDefault()
        {
            findedBooks = null;
            pageNum = mongoDB.GetCollection<AudioBook>().Count() / showNum;
            initCbxPage();
            books = mongoDB.GetCollection<AudioBook>().FindAll().SetLimit(showNum).ToList<AudioBook>();
            initPanel();
        }
        void initNameCriteria()
        {
            var query = Query.Matches(criteria, txtSearch.Text);
            findedBooks = mongoDB.GetCollection<AudioBook>().Find(query).ToList<AudioBook>();
            if (findedBooks != null)
                pageNum = findedBooks.Count + 1;
            else pageNum = 0;
            initCbxPage();
            books = findedBooks.GetRange(0, showNum);
            initPanel();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxCriteria.SelectedIndex)
            {
                case 0: initDefault();
                    break;
                default: initNameCriteria();
                    break;
            }
        }
    }
}
