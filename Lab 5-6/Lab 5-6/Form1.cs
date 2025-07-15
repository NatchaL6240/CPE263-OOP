namespace Lab_5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // ตัวแปร
            string strIn = txtIn.Text;
            int count = 0;
            int[] positions = new int[strIn.Length]; // ***.Length = ความยาวของสตริง

            // หา I
            for (int i = 0; i < strIn.Length; i++)
            {
                if (strIn[i] == 'I')
                {
                    positions[count] = i; // จำตำแหน่งตัว I
                    count++; // เลื่อนตำแหน่ง
                }
            }

            // แสดงผลลัพธ์
            string output = "มีอักษร I จำนวน: " + count + " ตัว\r\n"; // แสดงส่วนจำนวนตัวอักษร

            if (count > 0) // แสดงส่วนตำแหน่งตัวอักษร
            {
                output += "ตำแหน่ง: ";

                for (int i = 0; i < count; i++)
                {
                    positions[i]++; // ให้แสดงค่าออกมาตามตำแหน่งจริง ไม่ใช่ตาม array
                    output += positions[i].ToString() + " ";
                }
            }
            else
            {
                output += "ไม่พบอักษร I ในข้อความ";
            }
            txtOut.Text = output;
        }

    }
}
