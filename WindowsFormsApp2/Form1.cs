using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.NewFolder1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataExtract c = new DataExtract();

        private void dtv_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            c.nume = txt_nume.Text;
            c.nume2 = txt_nume2.Text;
            c.nrtel = txt_nrtel.Text;
            c.gen = cmb_gen.Text;
            bool ok = c.Insert(c);

            if (ok == true)
            {
                MessageBox.Show("Contact adaugat cu succes");
                Clear();
            }
            else
            {
                MessageBox.Show("Adaugare esuata, incercati din nou");
            }
            DataTable dt = c.Select();
            dtv_grid.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dtv_grid.DataSource = dt;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txt_nume.Text = "";
            txt_nume2.Text = "";
            txt_numar.Text = "";
            txt_nrtel.Text = "";
            cmb_gen.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.numar = txt_numar.Text;
            c.nume = txt_nume.Text;
            c.nume2 = txt_nume2.Text;
            c.nrtel = txt_nrtel.Text;
            c.gen = cmb_gen.Text;

            bool succes = c.Update(c);
            if (succes == true)
            {
                MessageBox.Show("contact actualizat cu succes");
                DataTable dt = c.Select();
                dtv_grid.DataSource = dt;
            }
            else
                MessageBox.Show("actualizarea a esuat, incercati din nou");
            Clear();
        }

        private void dtv_grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rand = e.RowIndex;
            txt_numar.Text = dtv_grid.Rows[rand].Cells[0].Value.ToString();
            txt_nume.Text = dtv_grid.Rows[rand].Cells[1].Value.ToString();
            txt_nume2.Text = dtv_grid.Rows[rand].Cells[2].Value.ToString();
            txt_nrtel.Text = dtv_grid.Rows[rand].Cells[3].Value.ToString();
            cmb_gen.Text = dtv_grid.Rows[rand].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.numar = txt_numar.Text;
            bool succes = c.Delete(c);
            if (succes == true)
            {
                MessageBox.Show("contact sters cu succes");
                DataTable dt = c.Select();
                dtv_grid.DataSource = dt;
            }
            else
                MessageBox.Show("stergerea a esuat, incercati din nou");
            Clear();

        }

        static string myconnstrg = ConfigurationManager.ConnectionStrings["connstrg"].ConnectionString;
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            SqlConnection conn = new SqlConnection(myconnstrg);
            SqlDataAdapter sr = new SqlDataAdapter("SELECT * FROM Table_11 WHERE nume LIKE '%" + keyword + "%' OR nume2 LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sr.Fill(dt);
            dtv_grid.DataSource = dt;
        }

        private void txt_numar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var res = dialog.ShowDialog();
            txt_nume.BackColor = dialog.Color;
            txt_numar.BackColor = dialog.Color;
            txt_nume2.BackColor = dialog.Color;
            txt_nrtel.BackColor = dialog.Color;
            cmb_gen.BackColor = dialog.Color;
            dtv_grid.BackgroundColor = dialog.Color;
            txt_search.BackColor = dialog.Color;
        }
    }
}
