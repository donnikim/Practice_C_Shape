

namespace _34_Study_Layout_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucColorMenu1.eColorAction += UcCMenu_eColorAction;
            ucPanelTop.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter1.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter2.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelRight.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
        }

        private void UcPanel_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            string strResult = ucColorMenu1.fButtonColorChange(sender);
        }

        private void UcCMenu_eColorAction(Button arg1, Color arg2)
        {
            
            string strPanelName = string.Empty;

            switch (arg1.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = arg2;
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = arg2;
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = arg2;
                    break;
                case "btn4":
                    ucPanelRight.BackColor = arg2;
                    break;
                default:
                    break;
            }

            string strResult = string.Format("선택 : {0}, {1}의 색상을 {2}로 변경", arg1.Name, strPanelName, arg2.ToString());
            listBox1.Items.Add(strResult);

        }
    }
}
