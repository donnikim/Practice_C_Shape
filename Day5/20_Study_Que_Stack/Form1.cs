using System.Drawing.Text;
using Timer = System.Windows.Forms.Timer;

namespace _20_Study_Que_Stack
{
    public partial class Form1 : Form
    {
        Queue<int> _Queue = new Queue<int>();
        Stack<int> _Stack = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101);

            // Queue에 데이터 입력
            if (_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);
                fQueueDataDisplay();
            }

            if (_Stack.Count < 6)
            {
                _Stack.Push(iData);
                fStackDataDisplay();
            }
        }

        private void fQueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();
            Array.Resize(ref iArray, 6);
            lblQueue1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblQueue2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblQueue3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblQueue4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblQueue5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblQueue6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();
            Array.Resize(ref iArray, 6);
            lblStack1.Text = (iArray[0] == 0) ? "" : iArray[0].ToString();
            lblStack2.Text = (iArray[1] == 0) ? "" : iArray[1].ToString();
            lblStack3.Text = (iArray[2] == 0) ? "" : iArray[2].ToString();
            lblStack4.Text = (iArray[3] == 0) ? "" : iArray[3].ToString();
            lblStack5.Text = (iArray[4] == 0) ? "" : iArray[4].ToString();
            lblStack6.Text = (iArray[5] == 0) ? "" : iArray[5].ToString();
        }

        private void btnDataOut_Click(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void fDataOut()
        {
            // Queue에 데이터 입력
            if (_Queue.Count > 0)
            {
                _Queue.Dequeue();
                fQueueDataDisplay();
            }

            if (_Stack.Count > 0)
            {
                _Stack.Pop();
                fStackDataDisplay();
            }
        }

        Timer _oTimer =new Timer();
        bool _bTimer = false;

        private void BtnDataAutoOut_Click(object sender, EventArgs e)
        {
            if(_bTimer)
            {
                _oTimer.Stop();
                _bTimer = false;
            }
            else
            {
                _oTimer.Interval = 2000;
                _oTimer.Tick += _oTimer_Tick;
                _oTimer.Start();

                _bTimer=true;
            }
        }

        private void _oTimer_Tick(object? sender, EventArgs e)
        {
            fDataOut();
        }
    }
}
