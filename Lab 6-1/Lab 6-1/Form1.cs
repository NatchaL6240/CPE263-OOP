using System.Security.Cryptography;

namespace Lab_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void sayHello() // เปลี่ยนข้อความไม่ได้
        {
            MessageBox.Show("Hello World");
        }
        void ShowMessage(string message) // เปลี่ยนข้อความได้
        {

            MessageBox.Show(message);

        }

        double CalculateTotal(int quantity, double price)  // คำนวณราคาต่อจำนวนชิ้น (มีแค่พาร์ทคำนวณ)
        {

            double total = quantity * price;
            return total;

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //sayHello(); 
            ShowMessage("โรคไตวายกำลังจะระบาดจากเกมกาชา");
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double ans = CalculateTotal(3, 20); //ต้องตั้งตัวแปรใรการเก็บค่า
            MessageBox.Show(ans.ToString());
        }
        string OddEven(int num) // มีค่าส่งกลับชนิดข้อความ
        {

            if (num % 2 == 0)
                return "Even";

            else

                return "Odd";

        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            string ans = OddEven(15);
            MessageBox.Show(ans);
        }
        int Max(int num1, int num2) // ส่งค่ากลับเป็นเลขจำนวนเต็ม (Integer)
        {

            if (num1 > num2)
                return num1;
            else
                return num2;

        }

        private void btnGreater_Click(object sender, EventArgs e)
        {
            int ans = Max(20, 10);
            MessageBox.Show(ans.ToString());
        }
    }
}
