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

        // 2) 


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
            eColorSender(sender, pcolor.BackColor);
        }
    }
}
