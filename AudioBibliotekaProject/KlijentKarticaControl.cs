using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioBibliotekaProject.Entieti;

namespace AudioBibliotekaProject
{
    public partial class KlijentKarticaControl : UserControl
    {
        public delegate void RemoveUser(Member user);
        public delegate void AccessTo(Member user);
        public bool AdminAcces { get; set; }
        public bool AdminTab { get; set; }
        public event RemoveUser removeUserEvent;
        public event AccessTo AccessToEvent;
        public Member User { get; set; }
        public KlijentKarticaControl()
        {
            InitControl();
        }

        public KlijentKarticaControl(Member mem)
        {
            User = mem;
            InitControl();
        }
        void InitControl()
        {
            InitializeComponent();
            //lblInit
            //btnMsg.ImageList.ImageSize = new Size(btnMsg.Width, btnMsg.Height);
            lblDate.Text = "";
            llblUName.Text = "";
            if (AdminAcces && !AdminTab)
                btnDelete.Visible = true;
            else
                btnDelete.Visible = false;
            



        }

        private void KlijentKarticaControl_Load(object sender, EventArgs e)
        {
            if (User != null)
            {
                llblUName.Text = User.Username;
                lblDate.Text = User.TimeRegistred.Date.ToShortDateString();
                if(User.UserImg!=null)
                {
                    if (User.UserImg != null)
                    {
                        pictureBox1.Image = User.getImg();
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite izbrisati ovog korisnika", "Brisanje korisnika", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                removeUserEvent.Invoke(this.User);
        }

        private void llblUName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccessToEvent.Invoke(this.User);
        }
    }
}
