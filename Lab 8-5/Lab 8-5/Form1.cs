using System.Diagnostics;

namespace Lab_8_5
{
    public partial class Form1 : Form
    {

        private int countdownValue; //receive value from countdown numbers

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCount_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtNum.Text, out countdownValue) && countdownValue>=1 && countdownValue <= 10)
            {
                lblCount.Text = countdownValue.ToString(); //shows the starting number in Label
                timer1.Interval = 1000; //set timer to count every 1 sec
                timer1.Start();
            }
            else
            {
                MessageBox.Show("กรอกเลขระหว่าง 1-10");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownValue--;
            lblCount.Text = countdownValue.ToString(); //update label

            if(countdownValue <= 0)
            {
                timer1.Stop();
            }
        }
    }
}
