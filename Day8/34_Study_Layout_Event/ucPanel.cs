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
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLabelDoubleClickHandler;

        public ucPanel()
        {
            InitializeComponent();
        }
        private void Panel_SizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0} {1})", lblPanel.Width, lblPanel.Height);
        }

        //private void DoubleClick(object sender, EventArgs e)
        //{
        //    eLabelDoubleClickHandler(sender, e);
        //}

        private void UcPanel_DoubleClick(object sender, EventArgs e)
        {
            eLabelDoubleClickHandler(this, e);
        }

        private void lbl_DoubleClick(object sender, MouseEventArgs e)
        {
            eLabelDoubleClickHandler(this, e);
        }
    }
}
