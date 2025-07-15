using System.Diagnostics.Eventing.Reader;

namespace Lab_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ทดสอบ Message Box", "ทดสอบ Message Box"
                , MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ทดสอบการใช้งาน MessageBox", "ทดสอบ MessageBox2"
                , MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3);
        }

        int count = 0; //global variable

        private void button3_Click(object sender, EventArgs e)
        {
            int data = 0; //local varaible
            count++;
            data++;
            MessageBox.Show("ตัวแปร Global, count = " + count
                + "\n" + "ตัวแปร Local, data = " + data);
        }

        int count2 = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            count2++;
            if (count2 == 1)
                button4.BackColor = Color.Red;
            else if (count2 == 2)
                button4.BackColor = Color.Green;
            else if (count2 == 3)
            {
                button4.BackColor = Color.Blue;
                count2 = 0;
            }
        }
    }
}
