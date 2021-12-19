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
            if(this.ID_textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            this.btnSave.Enabled = false;
            this.btnNew.Enabled = true;
            // ----------------------------
            this.Info_group_box.Enabled = false;
            // ---------------------------------
            string path = @"D:\MyProjects\PhoneBook\Path\";
            string fn = path + this.ID_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(fn, this.FirstName_textBox2.Text, Encoding.UTF8);
            string ln = path + this.ID_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(ln, this.LastName_textBox3.Text, Encoding.UTF8);
            string tell = path + this.ID_textBox1.Text + "_tell.txt";
            System.IO.File.WriteAllText(tell, this.Tell_textBox4.Text, Encoding.UTF8);
            string cell = path + this.ID_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(cell, this.Cell_textBox5.Text, Encoding.UTF8);
            string email = path + this.ID_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(email, this.Email_textBox6.Text, Encoding.UTF8);
            string adress = path + this.ID_textBox1.Text + "_adress.txt";
            System.IO.File.WriteAllText(adress, this.Adress_textBox7.Text, Encoding.UTF8);
            string comment = path + this.ID_textBox1.Text + "_comment.txt";
            System.IO.File.WriteAllText(comment, this.Comment_textBox8.Text, Encoding.UTF8);

            MessageBox.Show("Saved!");
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            this.Info_group_box.Enabled = false;
        }


    }
}
