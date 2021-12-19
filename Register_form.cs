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
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            this.btnNew.Enabled = false;
            this.btnSave.Enabled = true;
            // ----------------------------
            this.Info_group_box.Enabled = true;
            // ----------Clear TextBoxes------------------
            this.ID_textBox1.ResetText();
            this.FirstName_textBox2.ResetText();
            this.LastName_textBox3.ResetText();
            this.Tell_textBox4.ResetText();
            this.Cell_textBox5.ResetText();
            this.Email_textBox6.ResetText();
            this.Adress_textBox7.ResetText();
            this.Comment_textBox8.ResetText();
            // -------------------------------------------
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = false;
            this.btnNew.Enabled = true;
            // ----------------------------
            this.Info_group_box.Enabled = false;
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            this.Info_group_box.Enabled = false;
        }


    }
}
