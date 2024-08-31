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
    public partial class clogin : Form
    {
        public clogin()
        {
            InitializeComponent();
        }

        private void cpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void cl_Click(object sender, EventArgs e)
        {
            string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
            SqlConnection comm = new SqlConnection(css);
            comm.Open();

            string sq = "SELECT * From cashier WHERE cun=@un AND cpw=@pw";
            SqlCommand com = new SqlCommand(sq, comm);
            com.Parameters.AddWithValue("un", this.cun.Text);
            com.Parameters.AddWithValue("pw", this.cpw.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                cusreg cux = new cusreg();
                cux.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            comm.Close();

            
        }

        private void cb_Click(object sender, EventArgs e)
        {

            Form1 cx = new Form1();
            cx.Show();
            this.Hide();
        }
    }
}
