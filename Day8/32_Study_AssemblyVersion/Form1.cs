using System.Globalization;
using System.Reflection;
using System.Xml.Serialization;

namespace _32_Study_AssemblyVersion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3})", "프로그램 상태", oVersion.Major, oVersion.Minor, GetBuildDate(oVersion));
        }

        public DateTime GetBuildDate(Version oVersion)
        {
            string strVersion = oVersion.ToString();

            // 날짜 등록
            int iDays = Convert.ToInt32(strVersion.Split('.')[2]);
            DateTime refDate = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refDate.AddDays(iDays);

            // 초 등록
            int iSeconds = Convert.ToInt32(strVersion.Split(".")[3]);
            iSeconds *= 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);


            return dtBuildDate;
        }
        
        
        //Dictionary 확인

        Dictionary<string, Stack<CSize>> oDic = new Dictionary<string, Stack<CSize>>();

        private void btnControl_Click(object sender, EventArgs e)
        {
            fControlSizeRead();
            fControlSizeWrite();

        }

        private void fControlSizeWrite()
        {
            Stack<CSize> sButton = oDic["BUTTON"];

            foreach (CSize item in sButton)
            {

                string strResult = string.Format("Control : Button, Name : {0}, Size( {1} {2})", item.Name, item.Width, item.Height);
            
                listBox1.Items.Add(strResult);
            }

        }





        /*
           딕셔너리 안에 
            {Button : CSize(클래스), Label : CSize(클래스)
         
         
         
         
         
         */
        private void fControlSizeRead()
        {
            oDic.Clear();

            // Button 등록
            Stack<CSize> sButton = new Stack<CSize>();

            foreach (var item in gbox.Controls)
            {
                if (item is Button)
                {
                    Button obtn = (Button)item;
                    CSize oSize = new CSize();

                    oSize.Name = obtn.Name;
                    oSize.Width = obtn.Width;
                    oSize.Height = obtn.Height;

                    sButton.Push(oSize);
                }
            }
            oDic.Add("BUTTON",sButton);

            Stack<CSize> sLabel = new Stack<CSize>();

            foreach (var item in gbox.Controls)
            {
                if (item is Label)
                {
                    Label obtn = (Label)item;
                    CSize oSize = new CSize();

                    oSize.Name = obtn.Name;
                    oSize.Width = obtn.Width;
                    oSize.Height = obtn.Height;

                    sButton.Push(oSize);
                }
            }
            oDic.Add("LABEL", sLabel);

        }

       

    }


}
