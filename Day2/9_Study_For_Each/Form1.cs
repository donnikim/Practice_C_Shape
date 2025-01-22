using System.Text;

namespace _9_Study_For_Each
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iResult = 0;

            for (int i = 0; i <= 10; i++)
            {
                iResult += i;

                sb.Append(string.Format("1에서 {0}까지 더하면 {1} \r\n", i, iResult));
            }
            tboxResult.Text += sb.ToString();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            tboxResult.Text =string.Empty;

            StringBuilder sb = new StringBuilder();

            string[] strArray = ["a","b","c","d","e","f","g","h"];

            int i = 0;

            foreach(var item in strArray)
            {
                sb.Append(string.Format("{0} 선생님은 {1}반 입니다. \r\n", item,i++));

            }
            tboxResult.Text += sb.ToString();
        }
    }
}
