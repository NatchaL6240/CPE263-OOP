namespace Lab_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int cnt = 14;
            string strOut = "ǹ�ͺ������" + cnt.ToString() + "�ͺ" + "\r\n";
            for (int i = 1; i <= cnt; i++)
                strOut += "ǹ�ͺ��� " + i.ToString() + "\r\n";
            txtOut.Text = strOut;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int cnt = 14;
            string strOut = "ǹ�ͺ������" + cnt.ToString() + "�ͺ" + "\r\n";
            for (int i = cnt; i >= 1; i--)
                strOut += "ǹ�ͺ��� " + i.ToString() + "\r\n";
            txtOut.Text = strOut;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            int cnt = 27;
            string strOut = "ǹ�ͺ������" + cnt.ToString() + "�ͺ" + "\r\n";
            for (int i = 0; i <= cnt; i += 3)
                strOut += "ǹ�ͺ��� " + i.ToString() + "\r\n";
            txtOut.Text = strOut;
        }
    }
}
