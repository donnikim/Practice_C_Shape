namespace _15_Study_Partial
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach (var item in ei)
            {
                cboxItem.Items.Add(item.ToString());
            }

            foreach (var item in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(item.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _Data.fDataResult();

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);
            _Data.ICount = (int)numcout.Value;

            if(!String.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxErrMsg.Text = _Data.StrErrorName;
                return;
            }

            double dPrice = _Data.fItemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tboxResult.Text = _Data.DTotalPrice.ToString() + "¿ø";

        }
    }
}
