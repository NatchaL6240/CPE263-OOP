namespace Lab_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int cnt = 14;

            int num = Convert.ToInt16(txtNumber.Text);
            string strOut = "วงรอบทั้งหมด" + cnt.ToString() + "\r\n";

            if (radUp.Checked == true)
            {
                for (int i = 0; i <= cnt; i += num)
                    strOut += "วนรอบที่" + i.ToString() + "\r\n";
                txtOut.Text = strOut;
            }
            else if (radDown.Checked == true) 
            {  
                for (int i = cnt; i >= 0; i -= num)
                    strOut += "วนรอบที่" + i.ToString() + "\r\n";
                txtOut.Text = strOut;
            }
        }
    }
}
