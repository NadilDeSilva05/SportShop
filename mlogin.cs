using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_oder_process
{
    public partial class mlogin : Form
    {
        public mlogin()
        {
            InitializeComponent();
        }

        private void mbck_Click(object sender, EventArgs e)
        {

            Form1 cx = new Form1();
            cx.Show();
            this.Hide();
        }

        private void mlo_Click(object sender, EventArgs e)
        {
            string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
            SqlConnection comm = new SqlConnection(css);
            comm.Open();

            string sq = "SELECT * From manager WHERE username=@un AND password=@pw";
            SqlCommand com = new SqlCommand(sq, comm);
            com.Parameters.AddWithValue("un", this.mun.Text);
            com.Parameters.AddWithValue("pw", this.mpw.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                managerselect mx = new managerselect();
                mx.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            comm.Close();
            
        }
    }
}
