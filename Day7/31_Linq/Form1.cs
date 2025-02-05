using System.Data;

namespace _31_Linq
{
    public partial class Form1 : Form
    {
        const string sLEVEL = "LEVEL";
        const string sNAME = "NAME";
        const string sATTRIBUTE = "ATTRIBUTE";
        DataTable dt;
        enum EnumName
        {
            ������,
            ������,
            ��,
            �ں�Ʈ,
            ���,
            ��Ʈ,
            �𵥵�,
            ���,
            �巡��,
            ��,
            ��ť����,
            ����,
            ��Ƽ�ھ�,
            �ٽǸ���Ʈ,
        }

        enum EnumAttribute
        {
            ��,
            ��,
            �ٶ�,
            ����,
            ���,
            ��,
            ��,
            ����,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTableCreate(); //Data Table ����
            EnemyCreate(); // ���� ����
            ComboBoxCreate(); // �޺��ڽ� ����
        }



        private void DataTableCreate()
        {
            dt = new DataTable("Enemy");

            // DataColumn ����
            DataColumn colLevel = new DataColumn(sLEVEL, typeof(int));
            DataColumn colName = new DataColumn(sNAME, typeof(string));
            DataColumn colAttribute = new DataColumn(sATTRIBUTE, typeof(string));

            dt.Columns.Add(colLevel);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAttribute);
        }

        private void EnemyCreate()
        {
            Random rd = new Random();

            foreach (Enum oName in Enum.GetValues(typeof(EnumName)))
            {
                DataRow dr = dt.NewRow();
                dr[sLEVEL] = rd.Next(1, 11);//1~10�߿��� Random
                dr[sNAME] = oName.ToString();

                int iEnumLength = Enum.GetValues(typeof(EnumAttribute)).Length; //Enum�� ������ ������
                int iAttribute = rd.Next(iEnumLength);
                dr[sATTRIBUTE] = ((EnumAttribute)iAttribute).ToString();

                dt.Rows.Add(dr);
            }

            dgEnemyTable.DataSource = dt;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;
            IEnumerable<DataRow> vSortTable = null;
            switch (obtn.Name)
            {
                case "btnLevel":

                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<int>(sLEVEL)//���ı���
                                 select oRow;
                    break;
                case "btnName":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sNAME)//���ı���
                                 select oRow;
                    break;
                case "btnAttribute":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sATTRIBUTE)//���ı���
                                 select oRow;
                    break;
            }

            dtCopy = vSortTable.CopyToDataTable();
            dgEnemyTable.DataSource = dtCopy;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;

            IEnumerable<DataRow> vSortTable = from oRow in dtCopy.AsEnumerable()
                                              where oRow.Field<string>(sATTRIBUTE) == cboxAttribute.Text &&
                                              (oRow.Field<int>(sLEVEL) >= nLevelMin.Value && oRow.Field<int>(sLEVEL) <= nLevelMax.Value)
                                              select oRow;

            if (vSortTable.Count() > 0)
            {
                dtCopy = vSortTable.CopyToDataTable();
                dgEnemyTable.DataSource = dtCopy;
            }
            else
            {
                MessageBox.Show("�˻����ǿ� �´� �����Ͱ� �����ϴ�.");
            }


        }
        private void ComboBoxCreate()
        {
            foreach (EnumAttribute pAttribute in Enum.GetValues(typeof(EnumAttribute)))
            {
                cboxAttribute.Items.Add(pAttribute);
            }
            cboxAttribute.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgEnemyTable.DataSource = dt;
        }
    }
}
