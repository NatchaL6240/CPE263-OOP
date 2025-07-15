namespace Lab_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double Pi = Math.PI;
        private void btnCir1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double ans = 2 * Pi * radius;

            txtAns.Text = ans.ToString();
        }

        private void btnCir2_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double ans = Pi * (radius * radius);

            txtAns.Text = ans.ToString();
        }

        private void btnCir3_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double ans = 4 * Pi * (radius * radius);

            txtAns.Text = ans.ToString();
        }

        private void btnCir4_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double ans = (4.0 / 3.0) * Pi * (radius * radius);

            txtAns.Text = ans.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
