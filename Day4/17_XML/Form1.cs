using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _16_StreamReader_StreamWriter
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();

        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;


            StringBuilder sb = new StringBuilder();
            sb.Append(strText + "\r\n");
            sb.Append(bChecked.ToString() + "\r\n");
            sb.Append(iNumber.ToString() + "\r\n");

            tboxConfigData.Text = sb.ToString();

            _dData.Clear();
            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            //SFDialog.FileName = "*.txt";

            //// "표시 이름|파일 확장자|표시 이름|파일 확장자..."
            //SFDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //if (SFDialog.ShowDialog() == DialogResult.OK)
            //{
            //    strFilePath = SFDialog.FileName;
            //    StreamWriter swSFDialog = new StreamWriter(strFilePath);

            //    swSFDialog.WriteLine(tboxConfigData.Text);
            //    swSFDialog.Close();
            //    //
            //}

            SFDialog.FileName = "*.xml";

            // "표시 이름|파일 확장자|표시 이름|파일 확장자..."
            SFDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
                
                _XML.fXML_Writer(strFilePath,_dData);
            }



        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath; //프로그램 실행 파일 위치
            OFDialog.FileName = ".xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();


            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                // 방법 1.
                //StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);
                //while (srOFDialog.EndOfStream == false)
                //{
                //    sb.Append(srOFDialog.ReadLine());
                //    sb.Append("\r\n");
                //}

                //방법 2.
                sb.Append(File.ReadAllText(strFilePath));

                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }


        private void btnConfigRead_Click_1(object sender, EventArgs e)
        {
            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked =bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);

        }
    }
}
