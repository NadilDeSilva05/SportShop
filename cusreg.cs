using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_oder_process
{
    public partial class cusreg : Form
    {
        public cusreg()
        {
            InitializeComponent();
        }

        private void order_Click(object sender, EventArgs e)
        {
            customerd rex = new customerd();
            rex.Show();
            this.Hide();
        }

        private void view_Click(object sender, EventArgs e)
        {
            Allprices x3 = new Allprices();
            x3.Show();
            this.Hide();
        }

        private void back1_Click(object sender, EventArgs e)
        {
            Form1 clx = new Form1();
            clx.Show();
            this.Hide();
        }
    }
}
