namespace Study_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strName = "D";

        enum enumDay
        {
            Monday, // 0
            Tuesday,// 1
            Wednesday,// 2
            Thursday,// 3
            Friday,// 4
            Saturday,// 5
            Sunday,// 6
        }

        enum enumTime
        {
            Morning,
            AfterNoon,
            Evening,
        }
        private void btnResult1_Click(object sender, EventArgs e)
        {

        }

        // Form ���� Ŭ�� �� �ε��� ������ �ִ� �̺�Ʈ �߻�
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //������ ����
            // lboxDay.Items.Add(enumDay.Monday)

            foreach (var day in Enum.GetValues(typeof(enumDay)))
            {
                lboxDay.Items.Add(day);
            }

            foreach (var time in Enum.GetValues(typeof(enumTime)))
            {
                lboxTime.Items.Add(time);
            }

        }

        private void btnResult1_Click_1(object sender, EventArgs e)
        {
            // ��ȣ�� Monday(����) Afternoon�� ����� �߽��ϴ�.

            string strResult = tboxName.Text + " �� " + lboxDay.SelectedItem.ToString() + "(����)" + lboxTime.SelectedItem.ToString() + "�� ����� �߽��ϴ�.";

            tboxResult.Text = strResult;
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            string strResult = String.Format("{0}�� {1}(����) {2}�� ����� �߽��ϴ�.", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            tboxResult.Text = strResult;
        }
    }
}
