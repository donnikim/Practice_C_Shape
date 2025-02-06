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
            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3})", "���α׷� ����", oVersion.Major, oVersion.Minor, GetBuildDate(oVersion));
        }

        public DateTime GetBuildDate(Version oVersion)
        {
            string strVersion = oVersion.ToString();

            // ��¥ ���
            int iDays = Convert.ToInt32(strVersion.Split('.')[2]);
            DateTime refDate = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refDate.AddDays(iDays);

            // �� ���
            int iSeconds = Convert.ToInt32(strVersion.Split(".")[3]);
            iSeconds *= 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);


            return dtBuildDate;
        }
        
        
        //Dictionary Ȯ��

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
           ��ųʸ� �ȿ� 
            {Button : CSize(Ŭ����), Label : CSize(Ŭ����)
         
         
         
         
         
         */
        private void fControlSizeRead()
        {
            oDic.Clear();

            // Button ���
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
