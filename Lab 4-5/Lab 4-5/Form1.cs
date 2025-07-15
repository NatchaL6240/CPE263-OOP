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
                txtAns.Text = "ถูกต้อง";
            }
            else if (guess <= num) 
            {
                txtAns.Text = "น้อยไป";
            }
            else if (guess >= num) 
            {
                txtAns.Text = "มากไป";
            }

        }
    }
}
