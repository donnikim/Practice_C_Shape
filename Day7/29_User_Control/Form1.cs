
namespace _29_User_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var oControl in pMain.Controls) 
            {
                if (oControl is UCInfo) 
                {
                    UCInfo oInfo = oControl as UCInfo;
                    oInfo.eventdelSender += OInfo_eventdelSender;

                }
            }
        }

        private int OInfo_eventdelSender(object sender, string strText)
        {
            UCInfo oInfo = sender as UCInfo;

            lboxList.Items.Add(string.Format("{0} {1}", oInfo.UserNo, strText));
            return 0;
        }
    }
}
