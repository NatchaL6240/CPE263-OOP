namespace Lab_6_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setDate()
        {
            string day = updDate.Value.ToString();
            string month = updMonth.Value.ToString();
            string year = updYear.Value.ToString();

            string dateStr = month + " / " + day + " / " + year;
            DateTime dt;

            if (DateTime.TryParse(dateStr, out dt))
            {
                monthCalendar1.SetDate(dt);
            }
            else
                MessageBox.Show("รูปแบบวันเดือนปีไม่ถูกต้อง");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Today.Year;
            updYear.Value = currentYear;
            //updYear.Value = DateTime.Today.Year;

            updDate.Value = DateTime.Today.Day;
            updMonth.Value = DateTime.Today.Month;
        }

        private void updDate_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void updMonth_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void updYear_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "จันทร์")
            {
                monthCalendar1.FirstDayOfWeek = Day.Monday;
            }
            else
            {
                monthCalendar1.FirstDayOfWeek = Day.Sunday;
            }
        }
    }
}
