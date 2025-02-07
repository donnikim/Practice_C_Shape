using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_Study_Layout_Event
{
    public partial class ucColorMenu : UserControl
    {

        // 1) Delegate Event 선언
        public delegate void delColorSender(object oSender, Color oColor);
        public event delColorSender eColorSender;

        // 2) 기본 EventHandler
        public EventHandler oColorEventHandler;

        // 3) 제네릭 형태의 delegate 사용
        public event Action<Button, Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void PColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog(); // ColorDialog를 불러서 선택한 뒤 결과 값까지 받아옴

            if (dRet == DialogResult.OK)
            {
                pcolor.BackColor = cDialogColor.Color;
            }
        }

        public string fButtonColorChange(object sender)
        {
            string strResult = string.Empty;
            string strbtnName = string.Empty;

            ucPanel oPanel = (ucPanel)sender;


            switch(oPanel.Name)
            {
                case "ucPanelTop":
                    strbtnName = "btn1";
                    break;
                case "ucPanelCenter1":
                    strbtnName = "btn2";
                    break;
                case "ucPanelCenter2":
                    strbtnName = "btn3";
                    break;
                case "ucPanelRight":
                    strbtnName = "btn4";
                    break;
                default:
                    break;
            }
            strResult = fBtnSearch(strbtnName, oPanel.BackColor, oPanel.Name);
            return strResult;
        }

        private string fBtnSearch(string strButtonName, Color oColor, string strPanelName)
        {
            string strResult = string.Empty;

            foreach (var oItem in flpMenu.Controls)
            {
                if (oItem is Button) 
                {
                    Button obtn = oItem as Button;

                    if (obtn.Name.Equals(strButtonName))
                    {
                        obtn.BackColor = oColor;
                        strResult = string.Format("{0} Panel DubleClick, {1}의 색상을 {2}로 변경", strPanelName, strButtonName, oColor.ToString());
                        return strResult;
                    }
                }
                
            }
            return null;
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                Button obtn = new Button();
                obtn.Name = string.Format("btn{0}", i);
                obtn.Text = string.Format("P{0} 색상 변경",i);
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 20, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;
                flpMenu.Controls.Add(obtn);

            }

        }

        private void Obtn_Click(object? sender, EventArgs e)
        {
            // 1) Delegate Event 선언
            // eColorSender(sender, pcolor.BackColor);

            // 2) 기본 EventHandler
            // oColorEventHandler(sender, e);

            // 3) 제네릭 형태의 delegate 사용
            eColorAction((Button)sender,pcolor.BackColor);
        }


    }
}
