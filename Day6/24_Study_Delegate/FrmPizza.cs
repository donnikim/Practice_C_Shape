using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Study_Delegate
{
    public partial class FrmPizza : Form
    {

        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventdelPizzaComplete; //delegate event 선언

        public FrmPizza()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void fPizzaCheck(Dictionary<string, int> dPizzaOrder)
        {
            int iTotalTime =  0;

            foreach (KeyValuePair<string, int> oOrder in dPizzaOrder)
            {
                int iNowTime = 0;
                string strType = string.Empty;
                int iTime = 0;
                int iCount = oOrder.Value;
                switch (oOrder.Key) 
                {
                    // 1. 도우
                    case "오리지널":
                        iNowTime = 3000;
                        strType = "도우";
                        
                        break;

                    case "씬":
                        iNowTime = 3500;
                        strType = "도우";
                        
                        break;

                    // 2. 엣지 
                    case "리치골드":
                        iNowTime =  500;
                        strType = "엣지";
                        
                        break;

                    case "치즈크러스트":
                        iNowTime = 400;
                        strType = "엣지";
                      
                        break;

                    // 3. 토핑
                    case "소세지":
                        iNowTime = 30;
                        strType = "토핑";
                       
                        break;

                    case "감자":
                        iNowTime = 20;
                        strType = "토핑";
                        
                        break;

                    case "치즈":
                        iNowTime = 50;
                        strType = "토핑";
                        
                        break;

                    default:
                        break;

                }
                iTime = iNowTime * iCount;

                iTotalTime += iTime;

                lboxMake.Items.Add(string.Format("{0}) {1} : {2}초 ({3}초 {4}개) ", strType, oOrder.Key, iTime, iNowTime, iCount));
                Refresh();
                Thread.Sleep(1000);
            }
         

            int iResult = eventdelPizzaComplete("Pizza가 완성되었습니다.", iTotalTime);
        
            if(iResult == 0)
            {
                lboxMake.Items.Add("--------------------------------");
                lboxMake.Items.Add("주문 완료 확인!!");
            }
            else
            {
                lboxMake.Items.Add("--------------------------------");
                lboxMake.Items.Add("주문 제작 시간 초과");
            }
        }
    }
}
