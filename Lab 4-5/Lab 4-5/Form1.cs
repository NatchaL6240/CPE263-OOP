namespace Lab_4_5
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
            Random rdmObj = new Random();
            num = rdmObj.Next(0,11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt16(txtGuess.Text);

            if (guess == num)
            {
                txtAns.Text = "�١��ͧ";
            }
            else if (guess <= num) 
            {
                txtAns.Text = "�����";
            }
            else if (guess >= num) 
            {
                txtAns.Text = "�ҡ�";
            }

        }
    }
}
