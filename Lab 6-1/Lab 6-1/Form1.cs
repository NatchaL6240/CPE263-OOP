using System.Security.Cryptography;

namespace Lab_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void sayHello() // ����¹��ͤ��������
        {
            MessageBox.Show("Hello World");
        }
        void ShowMessage(string message) // ����¹��ͤ�����
        {

            MessageBox.Show(message);

        }

        double CalculateTotal(int quantity, double price)  // �ӹǳ�Ҥҵ�ͨӹǹ��� (������췤ӹǳ)
        {

            double total = quantity * price;
            return total;

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //sayHello(); 
            ShowMessage("�ä���¡��ѧ���кҴ�ҡ���Ҫ�");
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double ans = CalculateTotal(3, 20); //��ͧ��駵�����á���纤��
            MessageBox.Show(ans.ToString());
        }
        string OddEven(int num) // �դ���觡�Ѻ��Դ��ͤ���
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
        int Max(int num1, int num2) // �觤�ҡ�Ѻ���Ţ�ӹǹ��� (Integer)
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
