using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.Builders;
using AudioBibliotekaProject.Entieti;

namespace AudioBibliotekaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblWarnning.Text = "*Uneli ste pogresno korisničko ime ili lozinku";
            lblWarnning.ForeColor = Color.Red;
            lblWarnning.Visible = false;
            txtPass.PasswordChar = '*';

        }

        void logIn(Member user)
        { 
            GlavniMeni mainMenuForm = new GlavniMeni(user);
            this.Hide();

            mainMenuForm.ShowDialog();

            //kraj programa ili povrtak u zavisnosti od akcije korisnika
            DialogResult res = mainMenuForm.ClosingRes;
            if (res == DialogResult.Abort)
            {
                this.Close();
                return;
            }
            lblWarnning.Visible = false;
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Member user = Member.LogIn(txtUsername.Text, txtPass.Text);
            if (user == null)
            {
                lblWarnning.Visible = true;
                return;
            }


            logIn(user);
                      
            
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerForm = new Registracija();
            registerForm.Show();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn(null);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var query = Query.EQ("Name", "test2");
            mongoDB.GetCollection<Member>().Remove(query);


        }
        private void btnInitDB_Click(object sender, EventArgs e)
        {
            Admin admin= new Admin();
            Member mem= new Member();
            AudioBook ab = new AudioBook();

            admin.register("admin123", "admin123");
            System.IO.FileInfo imgpath = new System.IO.FileInfo(@"../../Resources/like.jpg");
            System.IO.FileInfo path = new System.IO.FileInfo(@"../../Resources/sample.mp3");
            admin.updateImg(imgpath.FullName);
            mem.register("test123", "test123");
            admin.updateBook("neki tekst", path.FullName,imgpath.FullName,  "test", "test", "test");
            mongoDB.GetCollection<Member>().EnsureIndex(new IndexKeysBuilder().Ascending("Username"));
            mongoDB.GetCollection<AudioBook>().EnsureIndex(new IndexKeysBuilder().Ascending("Name"));
            mongoDB.GetCollection<AudioBook>().EnsureIndex(new IndexKeysBuilder().Ascending("Author"));

        }
    }
}
