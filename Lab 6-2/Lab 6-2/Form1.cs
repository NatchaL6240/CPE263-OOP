namespace Lab_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Number (double num)
        {
            if (num > 0)
            {
                return "Positive";
            }
            else if (num == 0)
            {
                return "Zero";
            }
            else 
            {
                return "Negative";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNum.Text);
            string ans = Number(num);
            MessageBox.Show(num + " = " + ans);
        }
    }
}
