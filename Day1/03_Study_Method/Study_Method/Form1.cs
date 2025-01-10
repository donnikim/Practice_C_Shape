namespace Study_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text); 
            int iNumB = int.Parse(tboxNumber2.Text);

            int inResultNum = calcProc(iNumA, iNumB, 0);

            tboxResult.Text = inResultNum.ToString();
            tboxNumber1.Text = "0";
            tboxNumber2.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            int inResultNum = calcProc(iNumA, iNumB, 1);

            tboxResult.Text = inResultNum.ToString();
            tboxNumber1.Text = "0";
            tboxNumber2.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            int inResultNum = calcProc(iNumA, iNumB, 2);
            tboxResult.Text = inResultNum.ToString();
            tboxNumber1.Text = "0";
            tboxNumber2.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            int inResultNum = calcProc(iNumA, iNumB, 3);

            tboxResult.Text = inResultNum.ToString();
            tboxNumber1.Text = "0";
            tboxNumber2.Text = "0";
        }

        private int calcProc(int iNumA, int iNumB, int inFg)
        {
            switch (inFg)
            {
                case 0:
                    return iNumA + iNumB;
                case 1:
                    return iNumA - iNumB;
                case 2:
                    return iNumA * iNumB;
                case 3:
                    return iNumA / iNumB;
                default:
                    return 0;
            }
               
        }
    }
}
