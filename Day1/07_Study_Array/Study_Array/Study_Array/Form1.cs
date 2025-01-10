namespace Study_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dgDay.Rows.Clear();

            int[] iTest = { 10, 5, 30, 4, 16, 22, 18 };

            lblArray.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

            dgDay["colDay1", 0].Value = iTest[0];
            dgDay["colDay2", 0].Value = iTest[1];
            dgDay["colDay3", 0].Value = iTest[2];
            dgDay["colDay4", 0].Value = iTest[3];
            dgDay["colDay5", 0].Value = iTest[4];
            dgDay["colDay6", 0].Value = iTest[5];
            dgDay["colDay7", 0].Value = iTest[6];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 25, 14, 7, 5, 25 } };

            lblArray.Text = String.Format("전체 자료 수 : {0}", iTest.Length.ToString());

           dgDay.Rows.Add();

            dgDay["colDay1", 0].Value = iTest[0,0];
            dgDay["colDay2", 0].Value = iTest[0,1];
            dgDay["colDay3", 0].Value = iTest[0,2];
            dgDay["colDay4", 0].Value = iTest[0,3];
            dgDay["colDay5", 0].Value = iTest[0,4];
            dgDay["colDay6", 0].Value = iTest[0,5];
            dgDay["colDay7", 0].Value = iTest[0,6];

            dgDay["colDay1", 1].Value = iTest[1,0];
            dgDay["colDay2", 1].Value = iTest[1,1];
            dgDay["colDay3", 1].Value = iTest[1,2];
            dgDay["colDay4", 1].Value = iTest[1,3];
            dgDay["colDay5", 1].Value = iTest[1,4];
            dgDay["colDay6", 1].Value = iTest[1,5];
            dgDay["colDay7", 1].Value = iTest[1,6];


        }
    }
}
