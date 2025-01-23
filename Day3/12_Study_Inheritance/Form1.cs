namespace _12_Study_Inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;
        CCycle _cC;
        CCar _cCar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("�ܹ� ������");
            _cC = new CCycle("������");
            _cCar = new CCar("�ڵ���");
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            ClearPanel();
            OneCycleDraw();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CycleDraw();
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CarDraw();
        }
        // OneCycle ���� ��ġ �׸��� �׷� �ش�.
        private void OneCycleDraw()
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPenInfo();
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }
        private void CycleDraw()
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.fPenInfo();
            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        private void ClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }
        private void CarDraw()
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cCar.fPenInfo();

            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }
      ///
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ClearPanel();
            _cOC.fMove(-5);
            OneCycleDraw();

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ClearPanel();
            _cOC.fMove(5);
            OneCycleDraw(); 
        }
    }
}
