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
    public partial class ClanoviForm : Form
    {
        private Size defSize;
        public Member user;
        public List<Member> members;
        public List<Admin> admins;
        public Panel tmpPanel;

        public ClanoviForm()
        {
            formInit();
        }

        public ClanoviForm(Member usr)
        {
            this.user = usr;
            formInit();
        }
        void formInit()
        {
            InitializeComponent();
            ProfilControl pc = new ProfilControl(user);

            defSize = this.Size;
            tabProfil.Controls.Add(pc);
            pc.Location = new Point(0, 0);
            pc.Size = tabProfil.Size;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximumSize = defSize;
            tabControl.Size = this.Size;
        }

        private void ClanoviForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

        }

        private void ClanoviForm_Resize(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                this.Size = defSize;
                this.MaximumSize = defSize;

                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximumSize = new Size(0, 0);
            }

            if (tabControl.SelectedIndex == 1)
            {
                tmpPanel = panelUsers;
                initPanel<Member>(mongoDB.GetEntityList<Member>());//potrebna je promena


            }
            if (tabControl.SelectedIndex == 2)
            {
                tmpPanel = panelAdmin;
                initPanel<Admin>(mongoDB.GetEntityList<Admin>());


            }
        }
        void initPanel<T>(List<T> tmp) where T : Member
        {

            if (tmp == null)
                return;

            bool adminTab = false;
            bool adminAcess = false;
            if (typeof(T) == typeof(Admin))
            {
                adminTab = true;
            }
            if (this.user.GetType() == typeof(Admin))
            {
                adminAcess = true;
            }

            if (tmpPanel.Controls.Count > 0)
                tmpPanel.Controls.Clear();
            addControls<T>(adminTab, adminAcess, tmpPanel, tmp);
        }


        void addControls<T>(bool adminTab, bool adminAccess, Panel panel, List<T> tmp) where T : Member
        {

            int space = 5;
            KlijentKarticaControl content;
            KlijentKarticaControl prev;
            foreach (Member m in tmp)
            {
                if (m.Id == user.Id)
                    continue;

                content = new KlijentKarticaControl(m);
                content.AdminTab = adminTab;
                content.AdminAcces = adminAccess;
                content.removeUserEvent += this.removeUser;
                //!!!!!!!!!!content.AccessToEvent += this.accesTo; 
                this.tmpPanel.Controls.Add(content);
                if (tmpPanel.Controls.Count == 1)
                {
                    content.Location = new Point(0, 0);
                }
                else
                {
                    prev = (KlijentKarticaControl)this.tmpPanel.Controls[tmpPanel.Controls.Count - 2];
                    content.Location = new Point(0, prev.Location.Y + prev.Height + space);
                }
                content.Width = panel.Width;
                content.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));

            }
        }
        
        public void removeUser(Member user)//pomocna fja za addContorls
        {
            (this.user as Admin).removeUser(user);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPage_Click(object sender, EventArgs e)
        {

        }

    }
}
