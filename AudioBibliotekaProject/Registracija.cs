using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioBibliotekaProject.Entieti;

namespace AudioBibliotekaProject
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
            lblPassWarning.Visible = false;
            lblUserNameWarning.Visible = false;
            lblUserNameWarning.ForeColor = Color.Red;
            lblPassWarning.ForeColor = Color.Red;
            txtPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (!this.Validation())
            {
                txtPassword.Clear();
                return;
            }

            this.Close();
        }
        private bool Validation()
        {
            bool errorUN = false;
            bool errorPass = false;

            if (txtUsername.Text.Length < 5)
            {
                lblUserNameWarning.Text = "*Korisnicko ime mora da ima 5 ili vise karaktera!";
                errorUN = true;
            }
            else if (!Char.IsLetter(txtUsername.Text[0]))
            {
                lblUserNameWarning.Text = "*Korisnicko ime mora da pocinje karakterom!";
                errorUN = true;
            }

            
            if (txtPassword.Text.Length < 6)
            {
                lblPassWarning.Text = "*Lozinka mora da sadrzi 6 ili vise karaktera!";
                errorPass = true;
            }
            lblUserNameWarning.Visible = errorUN;
            lblPassWarning.Visible = errorPass;
            if (errorUN || errorPass)
                return false;
            Member nMember = new Member();
            if (!nMember.register(txtUsername.Text, txtPassword.Text)) //cuvanje u bazi u koliko
            {
                lblUserNameWarning.Text = "*Korisnicko ime vec postoji u bazi!";
                lblUserNameWarning.Visible = true;
                errorUN = true;
                return false;
            }
            lblUserNameWarning.Visible = errorUN;
            return true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
