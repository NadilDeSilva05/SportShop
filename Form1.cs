namespace CW_oder_process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FMC_Click(object sender, EventArgs e)
        {
            clogin x1 = new clogin();
            x1.Show();
            this.Hide();
        }

        private void FMM_Click(object sender, EventArgs e)
        {
            mlogin x1 = new mlogin();
            x1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suplier_Click(object sender, EventArgs e)
        {
            Suplier_Login sp = new Suplier_Login();
            sp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
