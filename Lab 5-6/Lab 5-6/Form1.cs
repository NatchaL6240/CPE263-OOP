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
            // �����
            string strIn = txtIn.Text;
            int count = 0;
            int[] positions = new int[strIn.Length]; // ***.Length = ������Ǣͧʵ�ԧ

            // �� I
            for (int i = 0; i < strIn.Length; i++)
            {
                if (strIn[i] == 'I')
                {
                    positions[count] = i; // �ӵ��˹觵�� I
                    count++; // ����͹���˹�
                }
            }

            // �ʴ����Ѿ��
            string output = "���ѡ�� I �ӹǹ: " + count + " ���\r\n"; // �ʴ���ǹ�ӹǹ����ѡ��

            if (count > 0) // �ʴ���ǹ���˹觵���ѡ��
            {
                output += "���˹�: ";

                for (int i = 0; i < count; i++)
                {
                    positions[i]++; // ����ʴ�����͡�ҵ�����˹觨�ԧ ������� array
                    output += positions[i].ToString() + " ";
                }
            }
            else
            {
                output += "��辺�ѡ�� I 㹢�ͤ���";
            }
            txtOut.Text = output;
        }

    }
}
