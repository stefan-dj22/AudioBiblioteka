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
    public partial class GlavniMeni : Form
    {
        public Member user;
        public DialogResult ClosingRes { get;  private set; }
        public ClanoviForm memberForm;

        public void Initialization()
        {
            InitializeComponent();
            if (user == null)
            {
                btnMembers.Enabled = false;
                btnInbox.Enabled = false;
            }
            this.ClosingRes = DialogResult.Abort;
        }
        public GlavniMeni()
        {
            this.Initialization();
            
        }
        public GlavniMeni(Member user)
        {
            this.user = user;
            Initialization();
        }
        private void GlavniMeni_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void GlavniMeni_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ClosingRes=DialogResult.None;
            this.Close();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (memberForm == null)
                memberForm = new ClanoviForm(user);
            memberForm.Show();
        }

        private void btnEnterLib_Click(object sender, EventArgs e)
        {
            BookLibary bl = new BookLibary(user);
            bl.Show();
        }
    }
}
