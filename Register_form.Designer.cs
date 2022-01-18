
namespace PhoneBook
{
    partial class Register_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Info_group_box = new System.Windows.Forms.GroupBox();
            this.Comment_textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Adress_textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email_textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cell_textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tell_textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Info_group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnNew,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 51);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 48);
            this.btnNew.Text = "New Data";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 48);
            this.btnSave.Text = "Save Changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 51);
            // 
            // Info_group_box
            // 
            this.Info_group_box.Controls.Add(this.Comment_textBox8);
            this.Info_group_box.Controls.Add(this.label8);
            this.Info_group_box.Controls.Add(this.Adress_textBox7);
            this.Info_group_box.Controls.Add(this.label7);
            this.Info_group_box.Controls.Add(this.Email_textBox6);
            this.Info_group_box.Controls.Add(this.label6);
            this.Info_group_box.Controls.Add(this.Cell_textBox5);
            this.Info_group_box.Controls.Add(this.label5);
            this.Info_group_box.Controls.Add(this.Tell_textBox4);
            this.Info_group_box.Controls.Add(this.label4);
            this.Info_group_box.Controls.Add(this.LastName_textBox3);
            this.Info_group_box.Controls.Add(this.label3);
            this.Info_group_box.Controls.Add(this.FirstName_textBox2);
            this.Info_group_box.Controls.Add(this.label2);
            this.Info_group_box.Controls.Add(this.ID_textBox1);
            this.Info_group_box.Controls.Add(this.label1);
            this.Info_group_box.Enabled = false;
            this.Info_group_box.Location = new System.Drawing.Point(19, 51);
            this.Info_group_box.Name = "Info_group_box";
            this.Info_group_box.Size = new System.Drawing.Size(591, 406);
            this.Info_group_box.TabIndex = 1;
            this.Info_group_box.TabStop = false;
            this.Info_group_box.Text = "Information";
            // 
            // Comment_textBox8
            // 
            this.Comment_textBox8.Location = new System.Drawing.Point(107, 353);
            this.Comment_textBox8.Name = "Comment_textBox8";
            this.Comment_textBox8.Size = new System.Drawing.Size(478, 22);
            this.Comment_textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment:";
            // 
            // Adress_textBox7
            // 
            this.Adress_textBox7.Location = new System.Drawing.Point(107, 309);
            this.Adress_textBox7.Name = "Adress_textBox7";
            this.Adress_textBox7.Size = new System.Drawing.Size(478, 22);
            this.Adress_textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address:";
            // 
            // Email_textBox6
            // 
            this.Email_textBox6.Location = new System.Drawing.Point(107, 263);
            this.Email_textBox6.Name = "Email_textBox6";
            this.Email_textBox6.Size = new System.Drawing.Size(478, 22);
            this.Email_textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // Cell_textBox5
            // 
            this.Cell_textBox5.Location = new System.Drawing.Point(107, 219);
            this.Cell_textBox5.Name = "Cell_textBox5";
            this.Cell_textBox5.Size = new System.Drawing.Size(478, 22);
            this.Cell_textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cell:";
            // 
            // Tell_textBox4
            // 
            this.Tell_textBox4.Location = new System.Drawing.Point(107, 179);
            this.Tell_textBox4.Name = "Tell_textBox4";
            this.Tell_textBox4.Size = new System.Drawing.Size(478, 22);
            this.Tell_textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tell:";
            // 
            // LastName_textBox3
            // 
            this.LastName_textBox3.Location = new System.Drawing.Point(107, 141);
            this.LastName_textBox3.Name = "LastName_textBox3";
            this.LastName_textBox3.Size = new System.Drawing.Size(478, 22);
            this.LastName_textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // FirstName_textBox2
            // 
            this.FirstName_textBox2.Location = new System.Drawing.Point(107, 101);
            this.FirstName_textBox2.Name = "FirstName_textBox2";
            this.FirstName_textBox2.Size = new System.Drawing.Size(478, 22);
            this.FirstName_textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // ID_textBox1
            // 
            this.ID_textBox1.Location = new System.Drawing.Point(107, 64);
            this.ID_textBox1.Name = "ID_textBox1";
            this.ID_textBox1.Size = new System.Drawing.Size(478, 22);
            this.ID_textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(622, 478);
            this.Controls.Add(this.Info_group_box);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Register_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Info_group_box.ResumeLayout(false);
            this.Info_group_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox Info_group_box;
        private System.Windows.Forms.TextBox ID_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Comment_textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Adress_textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email_textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cell_textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tell_textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName_textBox2;
        private System.Windows.Forms.Label label2;
    }
}