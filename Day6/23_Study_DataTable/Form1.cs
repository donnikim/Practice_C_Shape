using System.Data;

namespace _23_Study_DataTable
{
    public partial class Form1 : Form
    {

        DataSet ds = new DataSet(); //�б޵鿡 ���� ������ ������ ���� DataSet

        public Form1()
        {
            InitializeComponent();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckisTable = false;

            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckisTable = true;
            }

            // 1. Table ������ ����
            DataTable dt = null;

            if (!bCheckisTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }

            // 2. Row �ڷ� ���
            DataRow row = dt.NewRow();
            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "����";
            }
            else
            {
                row["SEX"] = "����";
            }

            row["REF"] = tboxRegRef.Text;



            // 3. ������ Row�� Table�� ���
            // dt.Rows.Add(row);

            if (bCheckisTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }

            ViewRefresh();

        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);
            ViewRefresh();
        }

        private void ViewRefresh()
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            //DataGridView Cell ���� �� Number�� ����
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach(DataRow oitem in ds.Tables[cboxRegClass.Text].Rows)
                {
                    // �̸��� key������ ����ٲٱ�
                    if (oitem["NAME"].Equals(tboxRegName.Text))
                    {

                        if (rdoRegSexMale.Checked)
                        {
                            oitem["SEX"] = "����";
                        }
                        else
                        {
                            oitem["SEX"] = "����";
                        }

                        oitem["REF"] = tboxRegRef.Text;

                    }
                    ViewRefresh();
                }
            }
        }
    }
}
