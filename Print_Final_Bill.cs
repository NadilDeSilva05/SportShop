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
    public partial class Print_Final_Bill : Form
    {
        DataSet ds;
        int xx;
        public Print_Final_Bill()
        {
            InitializeComponent();
        }

        private void main_Click(object sender, EventArgs e)
        {
            cusreg cx = new cusreg();
            cx.Show();
            this.Hide();
        }

        private void Print_Final_Bill_Load(object sender, EventArgs e)
        {
            try
            {
                //Create a connection with MS SQL Server
                string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection conn = new SqlConnection(css);
                conn.Open();

                //Create a Command
                string sqll = "SELECT max(cid) From cids ";
                SqlCommand comm = new SqlCommand(sqll, conn);
                comm.Parameters.AddWithValue("", xx);

                SqlDataReader drr = comm.ExecuteReader();
                drr.Read();

                this.cid.Text = drr.GetValue(0).ToString();
                xx = Convert.ToInt32(this.cid.Text);
                cid.Text = xx.ToString("000");
                conn.Close();

                string csse = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection comme = new SqlConnection(csse);

                comme.Open();

                string sq = "SELECT * From FBill WHERE Customer_ID=@cid";
                SqlCommand coe = new SqlCommand(sq, comme);
                coe.Parameters.AddWithValue("@cid", this.cid.Text);

                //Acccess data
                SqlDataAdapter dap = new SqlDataAdapter(coe);
                ds = new DataSet();
                dap.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];

                comme.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
