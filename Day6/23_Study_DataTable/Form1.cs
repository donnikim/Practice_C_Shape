using System.Data;

namespace _23_Study_DataTable
{
    public partial class Form1 : Form
    {

        DataSet ds = new DataSet(); //학급들에 대한 정보를 가지고 있을 DataSet

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

            // 1. Table 껍데기 생성
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

            // 2. Row 자료 등록
            DataRow row = dt.NewRow();
            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            else
            {
                row["SEX"] = "여자";
            }

            row["REF"] = tboxRegRef.Text;



            // 3. 생성된 Row를 Table에 등록
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

            //DataGridView Cell 정렬 및 Number를 적용
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
                    // 이름을 key값으로 내용바꾸기
                    if (oitem["NAME"].Equals(tboxRegName.Text))
                    {

                        if (rdoRegSexMale.Checked)
                        {
                            oitem["SEX"] = "남자";
                        }
                        else
                        {
                            oitem["SEX"] = "여자";
                        }

                        oitem["REF"] = tboxRegRef.Text;

                    }
                    ViewRefresh();
                }
            }
        }
    }
}
