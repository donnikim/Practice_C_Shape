using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Study_Thread
{
    public partial class Play : Form
    {
        public delegate int delMesssage(Object sender, string strResult); //delegate 선언
        public event delMesssage eventdelMessage;

        string _strPlayerName = string.Empty;
        public string StrPlayerName { get => _strPlayerName; set => _strPlayerName = value; }
        Thread _thread = null;

        bool _blThreadStop = false; // Thread Stop을 위한 Flag 생성


        public Play()
        {
            InitializeComponent();
        }

        public Play(string strPlayerName)
        {
            InitializeComponent();
            lblPlayerName.Text = StrPlayerName = strPlayerName;
        }

        public void fThreadStart()
        {
            // _thread = new Thread(new ThreadStart(Run)); => ThreadStart 델리게이트 타입 객체를 생성 후 함수를 넘김
            // _thread = new Thread(delegate () {Run();}) => 익명메소드를 사용하여 생성 후 함수를 넘김
            _thread = new Thread(Run);
            _thread.Start();
        }


        public void Run()
        {
            // UI Control이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 Coress Thread가 발생
            //CheckForIllegalCrossThreadCalls = false; //Thread 충돌에 대한 예외 처리를 무시 (CrossThread 무시)
            try
            {
                int ivar = 0;
                Random rd = new Random();

                while (pBarPlayer.Value < 100 && !_blThreadStop)
                {

                    if (this.InvokeRequired) // 요청 한 Thread가 현재 Main Thread 있는 Control을 엑셀스 할 수 있는지 확인
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            ivar = rd.Next(1, 11);
                            if (pBarPlayer.Value + ivar > 100)
                            {
                                pBarPlayer.Value = 100;
                            }
                            else
                            {
                                pBarPlayer.Value += ivar;
                            }

                            lblProcess.Text = string.Format("진행 상황 표시 : {0}%", pBarPlayer.Value);

                            this.Refresh();
                        }));
                        Thread.Sleep(300);
                    }
                }

                if (_blThreadStop)
                {
                    eventdelMessage(this, "중도 포기.... (Thread Stop)");
                }
                else
                {
                    eventdelMessage(this, "완주!! (Thread Complete)");
                }
                
            }
            catch (ThreadInterruptedException exInterrupt) 
            {
                exInterrupt.ToString();
            }
            catch (Exception ex) 
            {
                ex.ToString();
            }
         }
        private void btnStop_Click(object sender, EventArgs e)
        {
            //ThreadAbort();
            //ThreadInterrupt();
            _blThreadStop = true;
        }

        public void ThreadAbort()
        {
            if (_thread.IsAlive) //Thread가 동작 중 일 경우
            {
//               _thread.Abort(); //Thread를 강제 종료 하는데, 현재 .net에서 지원하지 않음
            }
        }

        public void ThreadJoin()
        {
            if (_thread.IsAlive)
            {
                bool blThreadEnd = _thread.Join(3000);
            }
        }

        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }
    }
}
