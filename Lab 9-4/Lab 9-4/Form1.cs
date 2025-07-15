namespace Lab_9_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try  // the start of exception handling
            {
                double num = Convert.ToDouble(txtInt.Text);
                double power2 = num * num;
                MessageBox.Show(power2.ToString());
            }

            catch(Exception ex)  // type of exception to catch
            {
                MessageBox.Show(ex.Message);
            }
            finally  // must end no matter if exception occured or not
            {
                MessageBox.Show("จบการทำงาน");
            }
        }
    }
}
