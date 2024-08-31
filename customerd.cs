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
    public partial class customerd : Form
    {
        int x,y;
        public customerd()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            cusreg cusx3 = new cusreg();
            cusx3.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ctel.TextLength == 10)
                {
                    if (this.cname.Text != String.Empty && this.ctel.Text != String.Empty && this.cem.Text != String.Empty)
                    {
                        string G = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                        SqlConnection c = new SqlConnection(G);
                        c.Open();
                        string sqll = "Insert INTO customer(cuid,cuname,cutel,cuem) VALUES(@cui,@cun,@cut,@cue)";
                        SqlCommand com = new SqlCommand(sqll, c);

                        com.Parameters.AddWithValue("@cui", this.cid.Text);
                        com.Parameters.AddWithValue("@cun", this.cname.Text);
                        com.Parameters.AddWithValue("@cut", this.ctel.Text);
                        com.Parameters.AddWithValue("@cue", this.cem.Text);

                        int ret = com.ExecuteNonQuery();
                        c.Close();

                        string GG = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                        SqlConnection cc = new SqlConnection(GG);
                        cc.Open();
                        string sql = "Insert INTO cids(cid) VALUES(@c)";
                        SqlCommand co = new SqlCommand(sql, cc);

                        co.Parameters.AddWithValue("@c", this.cid.Text);


                        int rett = co.ExecuteNonQuery();
                        MessageBox.Show("Registration Succesfull..!" + ret, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        cc.Close();

                        cashier x3 = new cashier();
                        x3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Required");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Phone Number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ctel_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void cem_TextChanged(object sender, EventArgs e)
        {   
        }

        private void cname_Validating(object sender, CancelEventArgs e)
        {
            if (cname.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider2.SetError(cname, "Please enter your name");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(cname, "");
            }
        }

        private void cem_Validated(object sender, EventArgs e)
        {
           

        }

        private void cem_Validating(object sender, CancelEventArgs e)
        {
            if (cname.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider3.SetError(cname, "Please enter your Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(cname, "");
            }
        }

        private void customerd_Load(object sender, EventArgs e)
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
                comm.Parameters.AddWithValue("", x);

                SqlDataReader drr = comm.ExecuteReader();
                drr.Read();

                this.cid.Text = drr.GetValue(0).ToString();
                x = Convert.ToInt32(this.cid.Text);
                x++;
                cid.Text = x.ToString("000");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
