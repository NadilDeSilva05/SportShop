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
    public partial class cashierreg : Form
    {
        public cashierreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerselect mx = new managerselect();
            mx.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(ct.TextLength == 10)
                {
                    if (this.cusername.Text != String.Empty && this.cpassword.Text != String.Empty)
                    {
                        string G = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                        SqlConnection c = new SqlConnection(G);
                        c.Open();
                        string sqll = "Insert INTO cashier(cname,caddress,ctel,cemail,cun,cpw) VALUES(@cn,@ca,@ct,@ce,@cu,@cp)";
                        SqlCommand com = new SqlCommand(sqll, c);

                        com.Parameters.AddWithValue("@cn", this.cn.Text);
                        com.Parameters.AddWithValue("@ca", this.ca.Text);
                        com.Parameters.AddWithValue("@ct", this.ct.Text);
                        com.Parameters.AddWithValue("@ce", this.ce.Text);
                        com.Parameters.AddWithValue("@cu", this.cusername.Text);
                        com.Parameters.AddWithValue("@cp", this.cpassword.Text);

                        int ret = com.ExecuteNonQuery();
                        MessageBox.Show("Registration Sucess." + ret, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        c.Close();
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

        private void cashierreg_Load(object sender, EventArgs e)
        {

        }

        private void ce_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
