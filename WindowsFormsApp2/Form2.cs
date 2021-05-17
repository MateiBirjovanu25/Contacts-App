using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Compare(txt_user.Text, "Matei") == 0 && string.Compare(txt_pass.Text, "123") == 0)
            {
                Form1 f2 = new Form1();
                this.Hide();
                f2.FormClosed += (s, args) => this.Close();
                f2.Show();
                f2.Focus();
            }
            else
                MessageBox.Show("Nume sau parola incorecta");
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
