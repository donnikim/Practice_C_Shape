namespace Study_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIfResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblIfResult.Text = string.Format("- Number1�� Number2���� {0} �� Ů�ϴ�", iNumber1 - iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblIfResult.Text = string.Format("- Number2�� Number1���� {0} �� Ů�ϴ�", iNumber2 - iNumber1);
            }
            else
            {
                lblIfResult.Text = string.Format("- �� ���ڴ� �����ϴ�. ���� : {0}", iNumber2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "��":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� ������ �Դϴ�.";
                    break;
                case "ȭ":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� ȭ���� �Դϴ�.";
                    break;
                case "��":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� ������ �Դϴ�.";
                    break;
                case "��":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� ����� �Դϴ�.";
                    break;
                case "��":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� �ݿ��� �Դϴ�.";
                    break;
                case "��":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� ����� �Դϴ�.";
                    break;
                case "��":
                    lblswitchResult.Text = "- �����Ͻ� ��¥�� �Ͽ��� �Դϴ�.";
                    break;

            }
        }
    }
}
