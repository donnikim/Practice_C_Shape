
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
            ucColorMenu1.eColorSender += UcCMenu_eColorSender;
        }

        private void UcCMenu_eColorSender(object oSender, Color oColor)
        {

        }
    }
}
