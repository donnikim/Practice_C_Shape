using System;
using System.Collections.Generic;
using System.Linq;
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
            _kbHook.hook();
            _kbHook.KeyDown += _kbHook_KeyDown;   
        }

        private void _kbHook_KeyDown(Object sender,KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C)
            {
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


    }
}
