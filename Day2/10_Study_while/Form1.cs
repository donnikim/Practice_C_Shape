using System.Text;

namespace _10_Study_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwhileResult_Click(object sender, EventArgs e)
        {
            // 1-45 6���� ��ȣ

            //List<int> iList = new List<int>();
            int[] iArr = new int[6];
            int iCount = 0;



            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while (Array.IndexOf(iArr, 0) != -1)
            {
                //1<= i <46
                int iNumber = rd.Next(1, 46);

                if (Array.IndexOf(iArr, iNumber) == -1)
                {
                    iArr[iCount] = iNumber;
                    iCount++;
                }
            }

            // �迭 sort
            Array.Sort(iArr);

            foreach (int iNumber in iArr) 
            {
                sb.Append(string.Format("{0}. ", iNumber));
            }

            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }

        private void btndowhileResult_Click(object sender, EventArgs e)
        {
            //1~100
            

            Random rd = new Random();

            int iNumber = int.Parse(tboxNumber.Text);

            if(iNumber >=101)
            {
                MessageBox.Show("100������ ���ڸ� ��� ��...");
                return;
            }
            int iCheckNumber = 0;
            int iCount = 0;

            do
            {
                iCheckNumber = rd.Next(1, 101);
                iCount++;
            } while (iNumber != iCheckNumber);

            lbldowhileResult.Text = string.Format("- ���� ���� {0}�� {1}ȸ ���� ã�ҽ��ϴ�.", iNumber, iCount);

        }
    }
}
