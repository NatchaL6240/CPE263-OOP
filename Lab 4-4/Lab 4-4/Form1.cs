namespace Lab_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txtNumber.Text);
            for (int i = 1; i <= 12; i++)
            {
                int res = i * num;
                txtAns.Text += num + " x " + i + "= " + res + "\r\n";
            }
        }
    }
}
