using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBibliotekaProject.Entieti;
using MongoDB.Driver;
using System.Windows.Forms;

namespace AudioBibliotekaProject
{
    public partial class ReviewControl : UserControl
    {
        public Member User { get; set; } // kod edita se dobija, kod read kreira
        public AudioBook Book { get; set; }//kod edita se koristi
        public Review _Review { get; set; }//kod read se koristi

        public delegate void UserAccess(Member user);
        public UserAccess userAccessEvent;
        //comm
        public Comment Comm { get; set; }//koristi se kod commRead
        //msg
        public Entieti.Message Msg { get; set; }
        public Member Reciver { get; set; }
        public MongoDBRef File { get; set; }

        public ReviewControl()
        {
            InitializeComponent();
        }
        public ReviewControl(Member user, AudioBook ab,bool review) 
        {
            InitializeComponent();
            User = user;
            Book = ab;
            if (review)
                InitEditMode();
            else
                initCommWriteMode();
            
        }

        public ReviewControl(Review r)
        {
            InitializeComponent();
            _Review = r;
            InitReadMode();
        }
        public ReviewControl(Comment comm)
        {
            InitializeComponent();
            Comm = comm;
            initCommReadMode();
        }
        public ReviewControl(Entieti.Message msg)
        {
            Msg = msg;
            InitializeComponent();
            initMsgReadMode();
            
        }
        public ReviewControl(Member sender, Member reciver,MongoDBRef file=null)
        {
            User = sender;
            Reciver = reciver;
            File = file;
            InitializeComponent();
            initMsgWriteMode();
        }

        void InitReadMode()
        {
            User = mongoDB.GetCollection<Member>().FindOneById(_Review.ReviewedBy.Id);
            if(User==null)
                User = mongoDB.GetCollection<Admin>().FindOneById(_Review.ReviewedBy.Id);
            rtbText.Text = _Review.Explanation;
            rtbText.Enabled = false;
            lblRate.Text += _Review.Rating;
            llblUser.Text = User.Name;
            comboBox1.Visible = false;
        }
        public void InitEditMode()
        {
            for(int i = 1; i < 11; i++)
            {
                comboBox1.Items.Add(i);
            }
            llblUser.Visible = false;

        }
        public void Rate()
        {
            User.reviewBook(Book, rtbText.Text, comboBox1.SelectedIndex + 1);
        }

        public void initCommReadMode()
        {
            User = mongoDB.GetCollection<Member>().FindOneById(Comm.CommentedBy.Id);
            if (User == null)
                User = mongoDB.GetCollection<Admin>().FindOneById(Comm.CommentedBy.Id);
            lblRate.Visible = false;
            comboBox1.Visible = false;
            rtbText.Text = Comm.Text;
            llblUser.Text = User.Name; 
            rtbText.Enabled = false;


        }
        public void initCommWriteMode()
        {
            lblRate.Visible = false;
            comboBox1.Visible = false;
            llblUser.Visible = false;

        }
        public void Comment()
        {
            User.coomentBook(Book, rtbText.Text);
        }

        public void initMsgReadMode()
        {
            User = mongoDB.GetCollection<Member>().FindOneById(Msg.Sender.Id);
            if (User == null)
                User = mongoDB.GetCollection<Admin>().FindOneById(Msg.Sender.Id);
            lblRate.Visible = false;
            comboBox1.Visible = false;
            llblUser.Text = User.Name;
            rtbText.Text = Msg.Content;
            rtbText.Enabled = false;
        }
        public void initMsgWriteMode()
        {
            lblRate.Visible = false;
            comboBox1.Visible = false;
            llblUser.Visible = false;
        }
        public void sendMsg()
        {
            if (Reciver.GetType() == typeof(Member))
                User.SendMsg<Member>(Reciver.Id, rtbText.Text, File);
            else
                User.SendMsg<Admin>(Reciver.Id, rtbText.Text, File);
        }

        private void llblUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userAccessEvent.Invoke(this.User);
        }
    }
}
