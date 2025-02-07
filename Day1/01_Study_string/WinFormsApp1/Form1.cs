namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strText = lblText.Text;
            
            lblContain.Text = strText.Contains("Text").ToString();

            lblEquals.Text = strText.Equals("Test").ToString();

            lblLength.Text = strText.Length.ToString();


            lblReplace.Text = strText.Replace("Test","I Can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            // 3번째부터 5개의 글자 출력
            lblSubstring.Text = strText.Substring(3, 5);

            lblToLower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper().ToString();

            lblTrim.Text = strText.Trim();

        }
    }
}
