using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using AudioBibliotekaProject.Entieti;

namespace AudioBibliotekaProject
{
    public partial class ProfilControl : UserControl
    {
        public Member Host { get; set; }
        public Member Visitor { get; set; }
        string defName;
        string defSurname;
        public ProfilControl()
        {
            InitializeComponent();
        }
        public ProfilControl(Member host, Member visitor = null)
        {
            Host = host;
            Visitor = visitor;
            this.formInit();
        }
        void formInit()
        {
            InitializeComponent();

            //varInit

            defName = Host.Name;
            defSurname = Host.Surname;



            //imgInit
            if (Host.UserImg != null)
            {
                picUser.Image = Host.getImg();
                picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            picLike.ImageLocation = @"../../Resources/like.jpg";
            picDislike.Load(@"../../Resources/dislike.png");
            picLike.SizeMode = PictureBoxSizeMode.StretchImage;
            picDislike.SizeMode = PictureBoxSizeMode.StretchImage;
            //btnInit
            if (Host.GetType() == typeof(Member))
                btnBooksApproved.Visible = false;

            //labeleInit
            lblUserName.Text = Host.Username;
            lblLike.Text = Host.Rating.Likes.ToString();
            lblDislike.Text = Host.Rating.Dislikes.ToString();


            //txtInit
            txtName.Text = defName;
            txtSurname.Text = defSurname;


            //Kontejner
            InfoDisable();

            //mode
            if (Visitor != null)
                visitorMode();

        }
        void visitorMode()
        {
            btnUploadPic.Visible = false;
            btnUploadBook.Visible = false;
            btnSave.Visible = false;
            btnCancle.Visible = false;
            lblChange.Visible = false;
            bool find = false;
            foreach (MongoDBRef DBref in Visitor.RatedUsers)
                if (DBref.Id == Host.Id)
                {
                    find = true;
                    break;
                }
            if (!find)
            {
                enableVoting();
            }
        }
        void enableVoting()
        {
            this.picDislike.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDislike_MouseDown);
            this.picDislike.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDislike_MouseUp);
            this.picLike.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLike_MouseDown);
            this.picLike.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picLike_MouseUp);
        }
        void disableVoting()
        {
            this.picDislike.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.picDislike_MouseDown);
            this.picDislike.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.picDislike_MouseUp);
            this.picLike.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.picLike_MouseDown);
            this.picLike.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.picLike_MouseUp);
        }
        void InfoEnable()
        {
            btnSave.Visible = true;
            btnCancle.Visible = true;
            txtName.Enabled = true;
            txtSurname.Enabled = true;
        }
        void InfoDisable()
        {
            btnSave.Visible = false;
            btnSave.Enabled = false;
            btnCancle.Visible = false;
            txtName.Enabled = false;
            txtSurname.Enabled = false;
        }

        private void btnUploadPic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofdForm = new OpenFileDialog();
            if (ofdForm.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo finfo = new System.IO.FileInfo(ofdForm.FileName);
                Host.updateImg(finfo.FullName);
                picUser.Load(finfo.FullName);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Host.updateInfo(txtName.Text, txtSurname.Text);
            defName = txtName.Text;
            defSurname = txtSurname.Text;
            InfoDisable();
        }

        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            txtName.Text = defName;
            txtSurname.Text = defSurname;
            InfoDisable();
        }

        private void lblChange_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoEnable();
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtSurname_TextChanged_1(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void picLike_MouseDown(object sender, MouseEventArgs e)
        {
            picLike.ImageLocation = @"../../Resources/Like shadow.png";
        }

        private void picLike_MouseUp(object sender, MouseEventArgs e)
        {
            picLike.ImageLocation = @"../../Resources/like.jpg";
            Visitor.rateUser(Host, true);
            int likes = Int32.Parse(lblLike.Text) + 1;
            lblLike.Text = likes.ToString();
            this.disableVoting();
        }

        private void picDislike_MouseDown(object sender, MouseEventArgs e)
        {
            picDislike.ImageLocation = @"../../Resources/UNLIKE shadow.png";
        }

        private void picDislike_MouseUp(object sender, MouseEventArgs e)
        {
            picDislike.Load(@"../../Resources/dislike.png");
            Visitor.rateUser(Host, false);
            int dislikes = Int32.Parse(lblDislike.Text) + 1;
            lblLike.Text = dislikes.ToString();
            this.disableVoting();
        }
    }
}
