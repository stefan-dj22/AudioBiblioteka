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
    public partial class BookLibary : Form
    {
        public BookLibary()
        {
            InitializeComponent();
        }
        public BookLibary(Member m)
        {
            InitializeComponent();
            BookListControl bc = new BookListControl(m);
            this.Controls.Add(bc);
            bc.Location = new Point(0, 0);
            bc.Size = this.Size;
            bc.Anchor= ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        }
    }
}
