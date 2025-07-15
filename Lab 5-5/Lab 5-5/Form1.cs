namespace Lab_5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e) //show ascii -> char
        {
            int data = Convert.ToInt16(txtIn.Text);
            char asc = (char)data;
            MessageBox.Show(asc.ToString());
        }

        private void btnRun_Num_Click(object sender, EventArgs e) //show char -> ascii
        {
            char data = Convert.ToChar(txtIn.Text);
            int num = (int)data;
            MessageBox.Show(num.ToString());
        }
    }
}
