namespace Lab_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double parallel1 = Convert.ToDouble(txtParallel1.Text);
            double parallel2 = Convert.ToDouble(txtParallel2.Text);
            double high = Convert.ToDouble(txtHigh.Text);

            double ans = (1 / 2.0) * (parallel1 + parallel2) * high;
            lblAns.Text = ans.ToString();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
