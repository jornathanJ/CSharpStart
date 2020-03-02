using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet HelloWorld(String test)
        {
            DataSet dsGlobal = new DataSet();
            assdasdasda
            #region Data Table 생성 및 컬럼 정의

            DataTable dtTemp = new DataTable();
            DataColumn dColKey = new DataColumn("key", typeof(int));
            DataColumn dColName = new DataColumn("name", typeof(String));

            dtTemp.Columns.Add(dColKey);
            dtTemp.Columns.Add(dColName);

            dtTemp.Columns.Add(new DataColumn("role"));

            #endregion


            dsGlobal.Tables.Add(dtTemp);

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

            return dsGlobal;
        }
    }
}
