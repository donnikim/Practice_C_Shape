﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTest
{
    public partial class Form1 : Form
    {
        enum enBossName
        {
            보검,
            신혜,
            해인,
            보영,
        }

        enum enClassName
        {
            진,
            정국,
            RM,
            지민,
            제이홉,
            뷔,
            슈가,
            은비,
            사쿠라,
            혜원,
            예나,
            채연,
            채원,
            민주,
            히토미,
            유리,
            유진,
            원영,
            나코,
        }

        int iPlayerCount = 0;

        Hashtable _ht = new Hashtable();
        Dictionary<string, string> _dic = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }        

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = enBossName.보검.ToString();
                    break;
                case "pbox2":
                    strSelectText = enBossName.신혜.ToString();
                    break;
                case "pbox3":
                    strSelectText = enBossName.해인.ToString();
                    break;
                case "pbox4":
                    strSelectText = enBossName.보영.ToString();
                    break;
            }

            int iTotalCount = Enum.GetValues(typeof(enClassName)).Length; 

            if(iTotalCount > iPlayerCount)
            {
                enClassName enName = (enClassName)iPlayerCount;

                _dic.Add(enName.ToString(), strSelectText);
                fUIDisplay(iTotalCount, enName.ToString());
                fDataGridViewDisplay();
                iPlayerCount++;
            }
            else
            {
                lblPlayerName.Text = "투표를 완료 하였습니다.";
            }

        }

        private void fUIDisplay(int iTotalCount, string strPlayerName)
        {
            int i보검 = 0;
            int i신혜 = 0;
            int i해인 = 0;
            int i보영 = 0;

            foreach (string oitem in _dic.Values)
            {
                switch (oitem)
                {
                    case "보검":
                        i보검++;
                        break;
                    case "신혜":
                        i신혜++;
                        break;
                    case "해인":
                        i해인++;
                        break;
                    case "보영":
                        i보영++;
                        break;
                }
            }

            lblPick1.Text = i보검.ToString();
            lblPick2.Text = i신혜.ToString();
            lblPick3.Text = i해인.ToString();
            lblPick4.Text = i보영.ToString();

            //lblTotalCount.Text = _strList.Count.ToString();

            lblTotalCount.Text = String.Format("{0} / {1}", iPlayerCount + 1, iTotalCount);  //Playercount는 배열 번호로 0번부터 시작하기 때문에 화면에 보여주기 전에 + 1
            lblPlayerName.Text = strPlayerName;

            fDataGridViewDisplay();
        }



        private void fDataGridViewDisplay()
        {
            dgviewList.DataSource = _dic.ToArray();

            // DataGridView의 Row Header에 값을 적어줌
            foreach (DataGridViewRow oRow in dgviewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgviewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
