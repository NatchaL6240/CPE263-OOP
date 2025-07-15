using System;

namespace Lab_4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            int i, sum = 0, num = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + num;
                num = num + 3;
            }
            MessageBox.Show(sum.ToString());
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            int i, sum = 0, num = 2;
            for (i = 1; i <= 8; i++)
            {
                sum = sum + num;
                num = num * 3;
            }
            MessageBox.Show(sum.ToString());
        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            int i, sum = 0, num = 0;
            for (i = 0; i <= 10; i++)
            {
                sum = sum + num;
                num = i * (i + 1);
            }
            MessageBox.Show(sum.ToString());
        }

        private void btnAns4_Click(object sender, EventArgs e)
        {
            int i, j, sum1 = 0, sum2 = 0, sum = 0;
            for (i = -1; i >= -9; i -= 2)
            {
                sum1 = sum1 + i;
            }
            for (j = 2; j <= 10; j += 2)
            {
                sum2 = sum2 + j;
            }

            sum = sum1 + sum2;
            MessageBox.Show(sum.ToString());
        }
    }
}
