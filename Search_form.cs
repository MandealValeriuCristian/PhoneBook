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
    public partial class Search_form : Form
    {
        public Search_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
         
            validation("fn", FirstName_textBox2);
            validation("ln", LastName_textBox3);
            validation("tell",Tell_textBox4);
            validation("cell", Cell_textBox5);
            validation("email", Email_textBox6);
            validation("adress", Adress_textBox7);
            validation("comment", Comment_textBox8);

            this.ID_textBox1.Text = this.textBox1.Text;
        }
        private void validation(string name, TextBox type)
        {
            string path = @"D:\MyProjects\PhoneBook\Path\";
            string result = path + this.textBox1.Text + "_" + name + ".txt";
            string resultRead;
            if (System.IO.File.Exists(result) == true)
            {
                resultRead = System.IO.File.ReadAllText(result, Encoding.UTF8);
                type.Text = resultRead;
            }
            else
                MessageBox.Show("Not found!");
        }
    }
}
