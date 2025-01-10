namespace Study_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tboxResult.Text);
            int iTemp2 = int.Parse(tboxResultAfter.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            bool bResult = (iTemp1 > iNumber || iTemp2 > iNumber);

            tboxAndOr.Text = bResult.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);


            iResult = iTemp << iNumber; 
            tboxNumber.Text = iResult.ToString();
        }
         
        private void tboxResult_TextChanged(object sender, EventArgs e)
        {
            tboxResultBit.Text = Convert.ToString(int.Parse(tboxResult.Text), 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);


            iResult = iTemp >> iNumber;
            tboxNumber.Text = iResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int itemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);
            itemp += iNumber;

            tboxResult.Text = itemp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int itemp = int.Parse(tboxResult.Text);
            int iNumber = int.Parse(tboxNumber.Text);
            itemp -= iNumber;

            tboxResult.Text = itemp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tboxResult.Text);

            tboxResult.Text = (iTemp++).ToString();
            tboxResultAfter.Text = iTemp.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tboxResult.Text);

            tboxResult.Text = (++iTemp).ToString();
            tboxResultAfter.Text = iTemp.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tboxResult.Text);
            int iTemp2 = int.Parse(tboxResultAfter.Text);
            int iNumber = int.Parse(tboxNumber.Text);

            bool bResult =(iTemp1 > iNumber && iTemp2 > iNumber);

            tboxAndOr.Text = bResult.ToString();
        }
    }
}
