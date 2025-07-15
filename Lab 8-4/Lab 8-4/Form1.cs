namespace Lab_8_4
{
    public partial class Form1 : Form
    {

        private int currentIndex = 0;
        private string message = "AKIYAMA MIZUKI";
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndex < message.Length)
            {
                lblText.Text += message[currentIndex];
                currentIndex++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblText.Text = "";
            currentIndex = 0;
            timer1.Interval = 500;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblText.Text = "";
        }
    }
}
