using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.UserControls
{
    public partial class DatasetSample : UserControl
    {
        private DataSet dsGlobal = null;

        public DatasetSample()
        {
            InitializeComponent();
        }

        private void btnCreateDataSet_Click(object sender, EventArgs e)
        {
            this.dsGlobal = new DataSet();

            #region Data Table 생성 및 컬럼 정의

            DataTable dtTemp = new DataTable();
            DataColumn dColKey = new DataColumn("key", typeof(int));
            DataColumn dColName = new DataColumn("name", typeof(String));

            dtTemp.Columns.Add(dColKey);
            dtTemp.Columns.Add(dColName);

            dtTemp.Columns.Add(new DataColumn("role")); 

            #endregion


            this.dsGlobal.Tables.Add(dtTemp);


            DataRow dRow = dtTemp.NewRow();
            dRow[0] = 1;
            dRow[1] = "jornathan";
            dRow[2] = "Developer";
            dtTemp.Rows.Add(dRow);


            dRow = dtTemp.NewRow();
            dRow["key"] = 1;
            dRow["name"] = "Kris";
            dRow["role"] = "Manager";
            dtTemp.Rows.Add(dRow);
            
        }

        private void btnBindDataSet_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.dsGlobal.Tables[0];
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            int rowIndex = int.Parse(this.tbxRow.Text);
            int colIndex = int.Parse(this.tbxColumn.Text);

            String strValue = this.dsGlobal.Tables[0].Rows[rowIndex][colIndex].ToString();
            this.tbxValue.Text = strValue;
        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            int rowIndex = int.Parse(this.tbxRow.Text);
            int colIndex = int.Parse(this.tbxColumn.Text);

            this.dsGlobal.Tables[0].Rows[rowIndex][colIndex] = this.tbxValue.Text;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataRow dRow = this.dsGlobal.Tables[0].NewRow();
            this.dsGlobal.Tables[0].Rows.Add(dRow);
            dRow[0] = 10;
            dRow[1] = 20;
            dRow[2] = 30;
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            //예외 처리
            this.dsGlobal.Tables[0].Rows.RemoveAt(int.Parse(this.tbxRemoveRow.Text));
        }

        private void btnDataTableSelect_Click(object sender, EventArgs e)
        {
            String strQuery = string.Format("{0} = '{1}' ", this.tbxSelectTargetColumn.Text, this.tbxSelectTargetValue.Text);
            DataRow [] dRowRows = this.dsGlobal.Tables[0].Select(strQuery);

            DataTable dtTemp = new DataTable();
            dtTemp = this.dsGlobal.Tables[0].Clone();

            foreach (DataRow drowTemp in dRowRows) {
                dtTemp.ImportRow(drowTemp);
            }


            this.dataGridView2.DataSource = dtTemp;
        }

        private void btnDataTableFilter_Click(object sender, EventArgs e)
        {
            String strQuery = string.Format("{0} = '{1}' ", this.tbxSelectTargetColumn.Text, this.tbxSelectTargetValue.Text);
            this.dsGlobal.Tables[0].DefaultView.RowFilter = strQuery;

            this.dataGridView2.DataSource = this.dsGlobal.Tables[0].DefaultView.ToTable();
        }
    }
}
;