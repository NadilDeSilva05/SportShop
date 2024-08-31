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
    public partial class cashier : Form
    {
        public cashier()
        {
            InitializeComponent();
        }

        private void Cbutton1_Click(object sender, EventArgs e)
        {
            cricketform cx = new cricketform();
            cx.Show();
            this.Hide();
        }

        private void Bbutton1_Click(object sender, EventArgs e)
        {
            netballform nx = new netballform();
            nx.Show();
            this.Hide();
        }

        private void BTbutton2_Click(object sender, EventArgs e)
        {
            badmintionform bx = new badmintionform();
            bx.Show();
            this.Hide();
        }

        private void Fbutton3_Click(object sender, EventArgs e)
        {
            footballform fx = new footballform();
            fx.Show();
            this.Hide();
        }

        private void Sbutton4_Click(object sender, EventArgs e)
        {
            swimmingform sx = new swimmingform();
            sx.Show();
            this.Hide();
        }

        private void Abutton5_Click(object sender, EventArgs e)
        {
            athleticform ax = new athleticform();
            ax.Show();
            this.Hide();
        }

        private void back2_Click(object sender, EventArgs e)
        {
            cusreg cust = new cusreg();
            cust.Show();
            this.Hide();
        }
    }
}
