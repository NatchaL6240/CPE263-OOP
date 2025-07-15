namespace Lab_3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Int16 n1 = Convert.ToInt16(txt1.Text);
            Int16 n2 = Convert.ToInt16(txt2.Text);
            Int16 n3 = Convert.ToInt16(txt3.Text);

            Int16 max_num = 0, min_num = 0, mid_num = 0;

            max_num = n1;

            if(n2 > max_num)
            {
                max_num = n2;
            }
            if(n3 > max_num)
            {
                max_num = n3;
            }

            min_num = n1;

            if (n2 < min_num)
            {
                min_num = n2;
            }
            if (n3 < min_num)
            {
                min_num = n3;
            }

            if ((n1 != max_num) && (n1 != min_num))
            {
                mid_num = n1;
            }
            if ((n2 != max_num)&& (n2 != min_num))
            {
                mid_num = n2;
            }
            if ((n3 != max_num)&&(n3 != min_num))
            {
                mid_num = n3;
            }

            lblAns.Text = "ค่ามากสุด: " + max_num.ToString() + "\n" + "ค่าต่ำสุด: " + min_num.ToString() + "\n"+ "ค่ากลาง: " + mid_num.ToString();
        }
    }
}
