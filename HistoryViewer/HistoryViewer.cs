using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryViewer
{
    public partial class HistoryViewer : Form
    {
        public volatile String CONSTVALUE = "";
        public int CUTOM_START_HOUR = 6;

        DataSet dsGlobal;

        public HistoryViewer()
        {
            InitializeComponent();

            //전역으로 사용할 특정 문자열이나 값의 할당
            CONSTVALUE = "TESTSET";
        }

        public void GetData()
        {
            this.dsGlobal = new DataSet();

            #region Data Table 생성 및 컬럼 정의

            DataTable dtTemp = new DataTable();
            DataColumn dColKey = new DataColumn("key", typeof(int));
            DataColumn dColName = new DataColumn("name", typeof(String));

            dtTemp.Columns.Add(dColKey);
            dtTemp.Columns.Add(dColName);

            dtTemp.Columns.Add(new DataColumn("role"));
            dtTemp.Columns.Add(new DataColumn("timeText", typeof(String)));
            dtTemp.Columns.Add(new DataColumn("timeValue", typeof(DateTime)));

            #endregion


            this.dsGlobal.Tables.Add(dtTemp);

            DataRow dRow = dtTemp.NewRow();
            dRow[0] = 1;
            dRow[1] = "jornathan";
            dRow[2] = "Developer";
            dRow[3] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dRow[4] = DateTime.Now;
            dtTemp.Rows.Add(dRow);

            dRow = dtTemp.NewRow();
            dRow["key"] = 1;
            dRow["name"] = "Kris";
            dRow["role"] = "Manager";
            dRow[3] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dRow[4] = DateTime.Now;
            dtTemp.Rows.Add(dRow);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //최초 로드 시에 현재 시간 기준 
            //From : -7일 
            //To : 오늘 6시
            this.dtmFrom.Value = DateTime.Now.AddDays(-7);
            

            int currentHour = DateTime.Now.Hour;

            this.dtmTo.Value = DateTime.Now.AddHours(-currentHour).AddHours(CUTOM_START_HOUR);

            try
            {
                //웹서비스 호출
                this.GetData();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            DateTime dtFrom = this.dtmFrom.Value;

            //if(this.dtmTo.Value > this.dtmFrom.Value)
            //{

            //}
            //TimeSpan
            TimeSpan ts1 = this.dtmTo.Value - this.dtmFrom.Value;
            TimeSpan ts2 = this.dtmTo.Value.Subtract(this.dtmFrom.Value);

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.fpSpread1.ActiveSheet.DataSource = this.dsGlobal.Tables[0];
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string strQuery
                = String.Format("timeValue >= #{0}# and timeValue <= #{1}#"
                , this.dtmFrom.Value.ToString("yyyy-MM-dd"), this.dtmTo.Value.AddDays(1).ToString("yyyy-MM-dd"));

            //strQuery = String.Format("timeValue >= #{0}# ", this.dtmFrom.Value.ToString("yyyy-MM-dd"));
            //strQuery = String.Format("timeValue <= #{0}# ", this.dtmTo.Value.AddDays(1).ToString("yyyy-MM-dd hh:mm:ss"));
            DataRow [] selectedRows 
                = this.dsGlobal.Tables[0].Select(strQuery);
        }

        private void dtmTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
