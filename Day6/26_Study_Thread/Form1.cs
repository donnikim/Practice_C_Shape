using System.Windows.Forms;
using Microsoft.Win32;

namespace _26_Study_Thread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }

        int _locationX = 0;
        int _locationY = 0;

        List<Play> lPlay = new List<Play>();

        public Form1()
        {
            InitializeComponent();
            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;
           
           
            for (int i = 0; i < numPlayerCount.Value; i++) 
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY+pl.Height*i);
                pl.eventdelMessage += PI_eventdelMessage;      

                pl.Show();
                pl.fThreadStart();

                lPlay.Add(pl);
            }
            
        }
        private int PI_eventdelMessage(object sender, string strResult)
        {
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    Play oPlayerForm = sender as Play;

                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", oPlayerForm.StrPlayerName, strResult));

                }));
             }
            return 0;
        }

        private void Form1_FormCloing(object sender, FormClosingEventArgs e)
        {
            foreach (Play oPlayFrom in lPlay) 
            {
                oPlayFrom.ThreadAbort();// 프로그램 종료시점이라서 강제로 Thread 해제
            }
        }
    }
}
