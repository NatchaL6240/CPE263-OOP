namespace Lab_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string str = "";
            if (chk1.Checked == true)
            {
                str += chk1.Text+"\r\n";
            }
            if (chk2.Checked == true)
            {
                str += chk2.Text+"\r\n";
            }
            if (chk3.Checked == true)
            {
                str += chk3.Text+"\r\n";
            }
            txtAns.Text = str;
        }
    }
}
