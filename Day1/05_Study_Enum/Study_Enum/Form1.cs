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

        // Form 더블 클릭 시 로드할 데이터 넣는 이벤트 발생
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //일일이 대입
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
            // 준호와 Monday(요일) Afternoon에 보기로 했습니다.

            string strResult = tboxName.Text + " 와 " + lboxDay.SelectedItem.ToString() + "(요일)" + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";

            tboxResult.Text = strResult;
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            string strResult = String.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            tboxResult.Text = strResult;
        }
    }
}
