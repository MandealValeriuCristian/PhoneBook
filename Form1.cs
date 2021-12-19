using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register_form rg = new Register_form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_form rg = new Search_form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            About_me_form rg = new About_me_form();
            rg.MdiParent = this;
            rg.Show();
        }
    }
}
