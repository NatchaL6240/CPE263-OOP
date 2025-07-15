namespace Lab_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double Pi = Math.PI;
            double data1, data2, data3, data4, data5, data6, data7;
            data1 = Math.Sin(Pi / 2.0);
            data2 = Math.Cos(Pi);
            data3 = Math.Sin(3 * Pi / 2); //sin(270)
            data4 = Math.Tan(45);
            data5 = Math.Log10(1000);
            data6 = Math.Pow(2, 10);
            data7 = Math.Sqrt(100);

            MessageBox.Show("sin(Pi/2) = " + data1 + "\n" + "cos(Pi) = " + data2
                + "\n"+ "sin(270) = " + data3 + "\n" + "tan(45) = " + data4
                + "\n" + "log(1000) = " + data5 + "\n" + "2 power by 10 = " + data6
                + "\n"+ "Sqrt (100) = "+ data7);
        }
    }
}
