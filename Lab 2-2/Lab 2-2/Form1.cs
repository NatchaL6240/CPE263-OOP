namespace Lab_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(txtBase.Text);
            double High = Convert.ToDouble(txtHigh.Text);
            double ans = (1/2.0)*Base*High;
            lblAns.Text = ans.ToString();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
