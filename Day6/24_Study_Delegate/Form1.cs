using System.ComponentModel;

namespace _24_Study_Delegate
{
    public partial class Form1 : Form
    {
        int _iTotalPrice = 0;

        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);

        // delegate �Լ��� �Ϲ�ȭ
        // public delegate int delFunc<T>(T i); 
        // public delegate object delFunc0(object i); // var, object
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            Dictionary<String, int> dPizzaOrder = new Dictionary<String, int>(); //Pizza �ֹ��� ���� �׸�

            if (_iTotalPrice > 0)_iTotalPrice = 0;
            
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFuncTopping delTopping = null;
            
            int iDowOrder = 0;
            int iEdgeOrder = 0;

            // 1. ���� ����
            if (rdoDow1.Checked)
            { 
                iDowOrder = 1;
                dPizzaOrder.Add("��������", 1);
            }
            else if (rdoDow2.Checked)
            {
                iDowOrder = 2;
                dPizzaOrder.Add("��", 1);
            }


            // 2. ���� ����
            if (rdoEdge1.Checked) 
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("��ġ���", 1);
            }
            else if(rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("ġ��ũ����Ʈ", 1);
            }

            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);

            if (cboxTopping1.Checked)
            {
                delTopping += fToopping1;
                dPizzaOrder.Add("�Ҽ���", (int)numEA.Value);
            }
            if (cboxTopping2.Checked) 
            {
                delTopping += fToopping2;
                dPizzaOrder.Add("����", (int)numEA.Value);
            }
            if (cboxTopping3.Checked) 
            {
                delTopping += fToopping3;
                dPizzaOrder.Add("ġ��", (int)numEA.Value);
            }

            delTopping("����", (int)numEA.Value);

            flboxOrderRed("--------------------------------------------------------------------");
            flboxOrderRed(string.Format("��ü �ֹ� ������ {0}�� �Դϴ�.", _iTotalPrice));
            frmLoading(dPizzaOrder);
            
        }


        #region Function
        /// <summary>
        /// 0 : ���� ����, 1: ��������, 2:��
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("����� ���������� �����ϼ̽��ϴ�. {0}��", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("����� ���� �����ϼ̽��ϴ�. {0}��", iPrice.ToString());

            }
            else 
            {
                strOrder = "���츦 �������� �ʾҽ��ϴ�.";
            }


            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }
        /// <summary>
        /// 0 : ���� ����, 1: ��ġ���, 2: ġ�� ũ����Ʈ
        /// </summary>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("������ ��ġ��带 �����ϼ̽��ϴ�. {0}��", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("������ ġ�� ũ����Ʈ�� �����ϼ̽��ϴ�. {0}��", iPrice.ToString());

            }
            else
            {
                strOrder = "������ �������� �ʾҽ��ϴ�.";
            }

            flboxOrderRed(strOrder);
            return _iTotalPrice += iPrice;
        }
        
        public int fCallBackDelegate(int i, delFuncDow_Edge dFunction)
        {
            return dFunction(i);
        }
        
        private int fToopping1(string Order, int iEa )
        {
            string strOrder = string.Empty;
            int iPrice = iEa*500;

            strOrder = string.Format("�Ҽ��� {0} {1}���� ���� �Ͽ����ϴ�. : {2}�� ( 1ea 500�� )",Order, iEa, iPrice);
            
            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fToopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("���� {0} {1}���� ���� �Ͽ����ϴ�. : {2}�� ( 1ea 200�� )", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fToopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("ġ�� {0} {1}���� ���� �Ͽ����ϴ�. : {2}�� ( 1ea 300�� )", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }
        private void flboxOrderRed(string strOrder)
        {
            lboxOrder.Items.Add(strOrder);
        }

        #endregion


        // ���â ���� ����
        FrmPizza fPizza;

        #region event ����
        private void frmLoading (Dictionary<string, int> dPizzaOrder)
        {
            if (fPizza != null)
            {
                fPizza.Dispose();
                fPizza = null;
            }

            fPizza = new FrmPizza();
            fPizza.StartPosition = FormStartPosition.CenterScreen;
            fPizza.eventdelPizzaComplete += FPizza_eventdelPizzaComplete;
            fPizza.Show();
            fPizza.fPizzaCheck(dPizzaOrder);


        }


        private int FPizza_eventdelPizzaComplete(string strResult, int iTime)
        {
            flboxOrderRed("--------------------------------------------------------------------");
            flboxOrderRed(string.Format("{0} /�ɸ��ð� : {1}" , strResult , iTime));
            return 0;
        }

        #endregion

    }
}
