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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CW_oder_process
{
    public partial class supply : Form
    {
        DataSet ds,dss;
        public supply()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Create a connection with MS SQL Server
                string cs = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //Create a Command
                string tname = this.catergory.Text;
                string sql = "SELECT Equipment_name FROM " + tname;
                SqlCommand com = new SqlCommand(sql, con);



                //Acccess data
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    this.item.Items.Add(dr.GetValue(0));
                }

                //Disconnect server
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void item_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection comm = new SqlConnection(css);
                comm.Open();

                string tname = this.catergory.Text;
                string sq = "SELECT * FROM " + tname + " WHERE Equipment_name=@name";
                SqlCommand coe = new SqlCommand(sq, comm);
                coe.Parameters.AddWithValue("@name", this.item.Text);

                //Acccess data
                SqlDataAdapter dap = new SqlDataAdapter(coe);
                ds = new DataSet();
                dap.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];

                comm.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supply_Load(object sender, EventArgs e)
        {
            Cqun.Visible = false;
            fqun.Visible = false;
            //catergory.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cqun_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Create a connection with MS SQL Server
                string cs = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //Create a Command
                string tname = this.catergory.Text;
                string sq = "SELECT Quantity FROM " + tname + " WHERE Equipment_name=@name";
                SqlCommand com = new SqlCommand(sq, con);
                com.Parameters.AddWithValue("@name", this.item.Text);

                //Acccess data
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                this.Cqun.Text = dr.GetValue(0).ToString();


                //Disconnect server
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                Double fqun;
                fqun = Convert.ToDouble(this.Cqun.Text) + Convert.ToDouble(this.quntity.Text);
                this.fqun.Text = fqun.ToString();

                //Create a connection with MS SQL Server
                string cc = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection ccc = new SqlConnection(cc);
                ccc.Open();

                string tname = this.catergory.Text;
                //Create a Command
                string s = "UPDATE " + tname + " SET Quantity=@qun WHERE Equipment_name=@iname ";
                SqlCommand co = new SqlCommand(s, ccc);
                co.Parameters.AddWithValue("@cat", this.catergory.Text);
                co.Parameters.AddWithValue("@iname", this.item.Text);
                co.Parameters.AddWithValue("@qun", this.fqun.Text);
                int rett = co.ExecuteNonQuery();

                string ss = "UPDATE alldetail SET Quantity=@qun WHERE Name=@iname ";
                SqlCommand coo = new SqlCommand(ss, ccc);
                coo.Parameters.AddWithValue("@iname", this.item.Text);
                coo.Parameters.AddWithValue("@qun", this.fqun.Text);
                int rettt = coo.ExecuteNonQuery();

                MessageBox.Show("Item Add" + rettt, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //Disconnect server
                ccc.Close();

                string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection comm = new SqlConnection(css);
                comm.Open();

                string name = this.catergory.Text;
                string sq = "SELECT * FROM " + name + " WHERE Equipment_name=@name";
                SqlCommand coe = new SqlCommand(sq, comm);
                coe.Parameters.AddWithValue("@name", this.item.Text);

                //Acccess data
                SqlDataAdapter dap = new SqlDataAdapter(coe);
                dss = new DataSet();
                dap.Fill(dss);
                this.dataGridView1.DataSource = dss.Tables[0];

                comm.Close();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
