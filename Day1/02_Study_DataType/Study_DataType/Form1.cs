namespace Study_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {


            try
            {
                short sNumber = short.Parse(tboxNumber.Text);
                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
                lblInt.Text = "0";
                lblDouble.Text = "0";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
                lblShort.Text = "0";
                lblInt.Text = "0";
                lblDouble.Text = "0";
            }

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tboxNumber.Text);
                lblInt.Text = sNumber.ToString();
                lblException.Text = "-";
                lblShort.Text = "0";
                lblDouble.Text = "0";

            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
                lblShort.Text = "0";
                lblInt.Text = "0";
                lblDouble.Text = "0";

            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNumber = double.Parse(tboxNumber.Text);
                lblDouble.Text = sNumber.ToString();
                lblException.Text = "-";
                lblInt.Text = "0";
                lblShort.Text = "0";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
                lblShort.Text = "0";
                lblInt.Text = "0";
                lblDouble.Text = "0";

            }
        }

        private void btnExe_Click_1(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            if (short.TryParse(tboxNumber.Text, out sNumber))
            {
                lblShort.Text = sNumber.ToString();
                lblInt.Text = "0";
                lblDouble.Text = "0";
                lblException.Text = "-";
            }
            else if (int.TryParse(tboxNumber.Text, out iNumber))
            {
                lblInt.Text = iNumber.ToString();
                lblShort.Text = "0";
                lblDouble.Text = "0";
                lblException.Text = "-";
            }
            else if (double.TryParse(tboxNumber.Text, out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
                lblShort.Text = "0";
                lblInt.Text = "0";
                lblException.Text = "-";
            }
            else
            {
                lblShort.Text = "0";
                lblInt.Text = "0";
                lblDouble.Text= "0";
                lblException.Text =  "변환 할수 없음";
            }
        }
    }
}
