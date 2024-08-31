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
    public partial class Allprices : Form
    {
        DataSet ds;
        public Allprices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cusreg cux=new cusreg();
            cux.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Allprices_Load(object sender, EventArgs e)
        {
            try
            {
                string css = "Data Source=MSI;Initial Catalog=Sport;Integrated Security=True";
                SqlConnection comm = new SqlConnection(css);

                string sq = "SELECT * From alldetail";
                SqlCommand coe = new SqlCommand(sq, comm);

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
    }
}
