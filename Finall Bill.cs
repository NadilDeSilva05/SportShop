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
    public partial class Finall_Bill : Form
    {
        int xx,x;
        public Finall_Bill()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a connection with MS SQL Server
                string cs = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string sql = "Insert INTO FBill(Customer_ID,Customer_Name,Date,Total_Bill) VALUES(@ci,@cn,@date,@to)";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@ci", this.cid.Text);
                com.Parameters.AddWithValue("@cn", this.cname.Text);
                com.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dateTimePicker1.Text));
                com.Parameters.AddWithValue("@to", this.tot.Text);


                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Payment Succesfull..!" + ret, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                con.Close();


                Print_Final_Bill pfx = new Print_Final_Bill();
                pfx.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Finall_Bill_Load(object sender, EventArgs e)
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

                string cs = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection com = new SqlConnection(cs);

                com.Open();

                string sq = "SELECT cuname From customer WHERE cuid=@cid";
                SqlCommand coe = new SqlCommand(sq, com);
                coe.Parameters.AddWithValue("@cid", this.cid.Text);
                SqlDataReader dr = coe.ExecuteReader();
                dr.Read();

                this.cname.Text = dr.GetValue(0).ToString();

                com.Close();



                string c = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection come = new SqlConnection(c);

                come.Open();

                string s = "SELECT sum(Total) From Bill1 WHERE CustomerId=@cid";
                SqlCommand co = new SqlCommand(s, come);
                co.Parameters.AddWithValue("@cid", this.cid.Text);
                SqlDataReader d = co.ExecuteReader();
                d.Read();

                this.tot.Text = d.GetValue(0).ToString();

                come.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
