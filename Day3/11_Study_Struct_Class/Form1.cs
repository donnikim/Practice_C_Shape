namespace _11_Study_Struct_Class
{
    public partial class Form1 : Form
    {
        CPlayer cPlayer = new CPlayer();

        struct structPlayer
        {

            public int iCount; // player�� ��ȸ ���� ������

            public int iSun;  // �ؿ� ���� ��
            public int iMoon; // �޿� ���� ��
            public int iStar; // ���� ���� ��

            public int iCardSum; // ��, ��, ���� ���� ��

            
        }

        structPlayer _structPlayer1; // 1�� �÷��̾�
        structPlayer _structPlayer2; // 2�� �÷��̾�
        
     
        
        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            if(_structPlayer1.iCount>5 || _structPlayer2.iCount>5)
            {
                return;
            }

            int iNumber = _rd.Next(1,21);

            if (rdoPlayer1.Checked) 
            {
                _structPlayer1.iSun += iNumber;
            }
            else
            {
                _structPlayer2.iSun += iNumber;
            }
            Result();

        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _structPlayer1.iMoon += iNumber;
            }
            else
            {
                _structPlayer2.iMoon += iNumber;
            }
            Result();

        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _structPlayer1.iStar += iNumber;
            }
            else
            {
                _structPlayer2.iStar += iNumber;
            }
            Result();

        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            // ������ �ѱ��.
            iCheckedChange();
        }
        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                 rdoPlayer2.Checked = true;
            }
            else 
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            int iCardSum = 0;

            if (rdoPlayer1.Checked)
            {
                _structPlayer1.iCount++;
                iCardSum = cPlayer.CardSun(_structPlayer1.iSun, _structPlayer1.iMoon, _structPlayer1.iStar);

                _structPlayer1.iCardSum = iCardSum;

                strResult = cPlayer.ResultText(_structPlayer1.iCount, _structPlayer1.iSun, _structPlayer1.iMoon, _structPlayer1.iStar, _structPlayer1.iCardSum);

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _structPlayer2.iCount++;
                _structPlayer2.iCardSum = cPlayer.CardSun(_structPlayer2.iSun, _structPlayer2.iMoon, _structPlayer2.iStar);

                strResult = cPlayer.ResultText(_structPlayer2.iCount, _structPlayer2.iSun, _structPlayer2.iMoon, _structPlayer2.iStar, _structPlayer2.iCardSum);
                
                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            if(_structPlayer1.iCount == _structPlayer2.iCount)
            {
                lboxNow.Items.Add(cPlayer.playerPair(_structPlayer2.iCount, _structPlayer1.iCardSum, _structPlayer2.iCardSum));

                if (_structPlayer2.iCount >= 5)
                {
                    lboxNow.Items.Add(cPlayer.PlayerResult(_structPlayer1.iCardSum, _structPlayer2.iCardSum));
                }
            }
        }
    }
}
