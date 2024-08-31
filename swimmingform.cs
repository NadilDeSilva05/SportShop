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
    public partial class swimmingform : Form
    {
        DataSet ds;
        int xx;
        public swimmingform()
        {
            InitializeComponent();
        }

        private void swmain_Click(object sender, EventArgs e)
        {
            cashier x = new cashier();
            x.Show();
            this.Hide();
        }

        private void swimmingform_Load(object sender, EventArgs e)
        {
            try
            {
                quantity.Visible = false;
                fquantity.Visible = false;
                //Create a connection with MS SQL Server
                string cs = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //Create a Command
                string sql = "SELECT Equipment_name From swimming ";
                SqlCommand com = new SqlCommand(sql, con);


                //Acccess data
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    this.swcat.Items.Add(dr.GetValue(0));
                }

                //Disconnect server
                con.Close();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void swcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Create a connection with MS SQL Server
                string cs = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //Create a Command
                string sql = "SELECT Price From swimming WHERE Equipment_name=@iname";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@iname", this.swcat.Text);

                //Acccess data
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                this.swprice.Text = dr.GetValue(0).ToString();


                //Disconnect server
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void swadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(this.quantity.Text) >= Convert.ToDouble(this.swq.Text))
                {
                    Double pr, qt, tot;
                    pr = Convert.ToDouble(this.swprice.Text);
                    qt = Convert.ToDouble(this.swq.Text);
                    tot = pr * qt;
                    this.swtot.Text = tot.ToString();

                    string G = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                    SqlConnection c = new SqlConnection(G);
                    c.Open();
                    string sql = "INSERT INTO Bill1(Customerid,Catergory,Price,Quantity,Total) VALUES(@ci,@cat,@pr,@qu,@to)";
                    SqlCommand com = new SqlCommand(sql, c);

                    com.Parameters.AddWithValue("@ci", this.cid.Text);
                    com.Parameters.AddWithValue("@cat", this.swcat.Text);
                    com.Parameters.AddWithValue("@pr", this.swprice.Text);
                    com.Parameters.AddWithValue("@qu", this.swq.Text);
                    com.Parameters.AddWithValue("@to", this.swtot.Text);


                    int ret = com.ExecuteNonQuery();
                    c.Close();

                    string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                    SqlConnection comm = new SqlConnection(css);

                    comm.Open();

                    string sq = "SELECT * From Bill1 WHERE Customerid=@cid";
                    SqlCommand coe = new SqlCommand(sq, comm);
                    coe.Parameters.AddWithValue("@cid", this.cid.Text);

                    //Acccess data
                    SqlDataAdapter dap = new SqlDataAdapter(coe);
                    ds = new DataSet();
                    dap.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0];

                    comm.Close();

                    Double fqun;
                    fqun = Convert.ToDouble(this.quantity.Text) - Convert.ToDouble(this.swq.Text);
                    this.fquantity.Text = fqun.ToString();
                    //Create a connection with MS SQL Server
                    string cc = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                    SqlConnection ccc = new SqlConnection(cc);
                    ccc.Open();

                    //Create a Command
                    string s = "UPDATE swimming SET Quantity=@qun WHERE Equipment_name=@iname ";
                    SqlCommand co = new SqlCommand(s, ccc);
                    co.Parameters.AddWithValue("@iname", this.swcat.Text);
                    co.Parameters.AddWithValue("@qun", this.fquantity.Text);
                    int rett = co.ExecuteNonQuery();

                    string ss = "UPDATE alldetail SET Quantity=@qun WHERE Name=@iname ";
                    SqlCommand coo = new SqlCommand(ss, ccc);
                    coo.Parameters.AddWithValue("@iname", this.swcat.Text);
                    coo.Parameters.AddWithValue("@qun", this.fquantity.Text);
                    int rettt = coo.ExecuteNonQuery();
                    //Disconnect server
                    ccc.Close();
                }
                else
                {
                    MessageBox.Show("Out Of Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void swby_Click(object sender, EventArgs e)
        {
            Finall_Bill fx = new Finall_Bill();
            fx.Show();
            this.Hide();
        }

        private void swprice_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //Create a connection with MS SQL Server
                string cc = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection c = new SqlConnection(cc);
                c.Open();

                //Create a Command
                string sq = "SELECT Quantity From swimming WHERE Equipment_name=@iname";
                SqlCommand co = new SqlCommand(sq, c);
                co.Parameters.AddWithValue("@iname", this.swcat.Text);

                //Acccess data
                SqlDataReader drrr = co.ExecuteReader();
                drrr.Read();

                this.quantity.Text = drrr.GetValue(0).ToString();


                //Disconnect server
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
