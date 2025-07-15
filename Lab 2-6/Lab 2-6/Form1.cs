namespace Lab_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCel_Click(object sender, EventArgs e)
        {
            double far = Convert.ToDouble(txtTemp.Text);

            double cel_temp = 5 * (far - 32) / 9;
            MessageBox.Show("Celcius = " + cel_temp);
        }

        private void btnFar_Click(object sender, EventArgs e)
        {
            double cel = Convert.ToDouble(txtTemp.Text);

            double far_temp = (9.0 / 5.0) * cel + 32;
            MessageBox.Show("Farhenheit = " +  far_temp);
        }
    }
}
