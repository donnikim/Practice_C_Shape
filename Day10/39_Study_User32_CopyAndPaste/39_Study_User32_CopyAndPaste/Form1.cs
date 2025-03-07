using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _39_Study_User32_CopyAndPaste
{  
    public partial class Form1 : Form
    {

        CGlobalKeyboardHook _kbHook = new CGlobalKeyboardHook();
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = string.Format("{0} Ver.{1}.{2} / Build Time ({3})", "Copy&Paste", oVersion.Major, oVersion.Minor, GetBuildDataTime(oVersion));
     
            _kbHook.hook();
            _kbHook.KeyDown += _kbHook_KeyDown;   
        }

        // Build Time을 변환        
        public DateTime GetBuildDataTime(Version oVersion)
        {
            string strVerstion = oVersion.ToString();             // 날짜 등록            
            int iDays = Convert.ToInt32(strVerstion.Split('.')[2]);
            DateTime refData = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refData.AddDays(iDays);             // 초 등록            
            int iSeconds = Convert.ToInt32(strVerstion.Split('.')[3]);
            iSeconds = iSeconds * 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);             // 시차 조정            
            DaylightTime daylighttime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);
            if (TimeZone.IsDaylightSavingTime(dtBuildDate, daylighttime))
            {
                dtBuildDate = dtBuildDate.Add(daylighttime.Delta);
            }
            return dtBuildDate;
        }
     

        private void _kbHook_KeyDown(Object sender,KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C && cboxactivation.Checked)
            {
                string strText = Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString();
                if (lboxTestSave.Items.Contains(strText))
                {
                    return;
                }

                Thread.Sleep(400);
                lboxTestSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }
        }


        private void LboxTestSave_SelectIndexChanged(object sender, EventArgs e)
        {
            if(lboxTestSave.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTestSave.SelectedItem.ToString());
            }
        }

        private void tbox_scroll(object sender, EventArgs e)
        {
            this.Opacity = Tbar.Value / 10.0;
        }

        private void btnlbtextadd_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        private void tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataSave();
            }
        }

        private void DataSave()
        {

            string strText = txtlbtextadd.Text;
            
            if (!String.IsNullOrEmpty(strText) && !lboxTestSave.Items.Contains(strText))
            {
                lboxTestSave.Items.Add(strText);
                txtlbtextadd.Text = "";
            }
        }

        private void cbox_Change(object sender, EventArgs e)
        {
            if(cboxactivation.Checked)
            {
                lblactivation.Text = "활성화 상태 (Ctrl+ C 가능)";
                lblactivation.Enabled = true;
                txtlbtextadd.Enabled = true;
                btnlbtextadd.Enabled = true;

            }
            else
            {
                lblactivation.Text = "비활성화 상태 (붙여넣기만 가능)";
                lblactivation.Enabled = false;
                txtlbtextadd.Enabled = false;
                btnlbtextadd.Enabled = false;
            }
        }

        private void lbox_keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                lboxTestSave.Items.RemoveAt(lboxTestSave.SelectedIndex);
            }
        }
    }
}
