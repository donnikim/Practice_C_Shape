using System.ComponentModel;

namespace _24_Study_Delegate
{
    public partial class Form1 : Form
    {
        int _iTotalPrice = 0;

        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);

        // delegate 함수의 일반화
        // public delegate int delFunc<T>(T i); 
        // public delegate object delFunc0(object i); // var, object
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            Dictionary<String, int> dPizzaOrder = new Dictionary<String, int>(); //Pizza 주문을 담을 그릇

            if (_iTotalPrice > 0)_iTotalPrice = 0;
            
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFuncTopping delTopping = null;
            
            int iDowOrder = 0;
            int iEdgeOrder = 0;

            // 1. 도우 선택
            if (rdoDow1.Checked)
            { 
                iDowOrder = 1;
                dPizzaOrder.Add("오리지널", 1);
            }
            else if (rdoDow2.Checked)
            {
                iDowOrder = 2;
                dPizzaOrder.Add("씬", 1);
            }


            // 2. 엣지 선택
            if (rdoEdge1.Checked) 
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("리치골드", 1);
            }
            else if(rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("치즈크러스트", 1);
            }

            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);

            if (cboxTopping1.Checked)
            {
                delTopping += fToopping1;
                dPizzaOrder.Add("소세지", (int)numEA.Value);
            }
            if (cboxTopping2.Checked) 
            {
                delTopping += fToopping2;
                dPizzaOrder.Add("감자", (int)numEA.Value);
            }
            if (cboxTopping3.Checked) 
            {
                delTopping += fToopping3;
                dPizzaOrder.Add("치즈", (int)numEA.Value);
            }

            delTopping("토핑", (int)numEA.Value);

            flboxOrderRed("--------------------------------------------------------------------");
            flboxOrderRed(string.Format("전체 주문 가격은 {0}원 입니다.", _iTotalPrice));
            frmLoading(dPizzaOrder);
            
        }


        #region Function
        /// <summary>
        /// 0 : 선택 안함, 1: 오리지널, 2:씬
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
                strOrder = string.Format("도우는 오리지널을 선택하셨습니다. {0}원", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택하셨습니다. {0}원", iPrice.ToString());

            }
            else 
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }


            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }
        /// <summary>
        /// 0 : 선택 안함, 1: 리치골드, 2: 치즈 크러스트
        /// </summary>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드를 선택하셨습니다. {0}원", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치즈 크러스트를 선택하셨습니다. {0}원", iPrice.ToString());

            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
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

            strOrder = string.Format("소세지 {0} {1}개를 선택 하였습니다. : {2}원 ( 1ea 500원 )",Order, iEa, iPrice);
            
            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fToopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1}개를 선택 하였습니다. : {2}원 ( 1ea 200원 )", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private int fToopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1}개를 선택 하였습니다. : {2}원 ( 1ea 300원 )", Order, iEa, iPrice);

            flboxOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }
        private void flboxOrderRed(string strOrder)
        {
            lboxOrder.Items.Add(strOrder);
        }

        #endregion


        // 모달창 전역 변수
        FrmPizza fPizza;

        #region event 예제
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
            flboxOrderRed(string.Format("{0} /걸린시간 : {1}" , strResult , iTime));
            return 0;
        }

        #endregion

    }
}
