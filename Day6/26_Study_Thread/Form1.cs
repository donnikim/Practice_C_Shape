using System.Windows.Forms;

namespace _26_Study_Thread
{
    public partial class Form1 : Form
    {

        int _locationX = 0;
        int _locationY = 0;

        public Form1()
        {
            InitializeComponent();
            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;
           
           
            for (int i = 0; i < numPlayerCount.Value; i++) 
            {
                Play pl = new Play();
                pl.Location = new Point(_locationX, _locationY);


                pl.Show();
            }
            
        }
    }
}
