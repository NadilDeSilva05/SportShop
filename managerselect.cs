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
    public partial class managerselect : Form
    {
        public managerselect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cashierreg rex = new cashierreg();
            rex.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            managerview mvx = new managerview();
            mvx.Show();
            this.Hide();
        }

        private void backf_Click(object sender, EventArgs e)
        {
            Form1 fx= new Form1();
            fx.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Supplier_Registration sr=new Supplier_Registration();
            sr.Show();
            this.Hide();
        }
    }
}
