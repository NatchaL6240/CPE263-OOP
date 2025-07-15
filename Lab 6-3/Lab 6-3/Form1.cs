using System.Numerics;

namespace Lab_6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double vat7(double price)
        {
            double total_vat = price * 0.07;
            return total_vat;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtInput.Text);
            double sum = price + vat7(price);
            MessageBox.Show("ราคาสินค้า = " + sum + "\r\n" + "Vat 7% = " + vat7(price).ToString("#.##"));
        }
    }
}
