using System; 
using System.Data;
using System.Data.SqlClient; 

namespace WebEmployee.Center
{
    public class DBConnect
    { 
        private SqlConnection sqlCon;
        private SqlDataAdapter sqlDa;
        private SqlConnection sqlConCn = new SqlConnection();
        private Boolean bConFT = false;
        //+++++++++++++++++++++++++++++ 
        private string _tServer = "localhost";
        private string _tDatabase = "Employee";
        private string _tAdmin_User = "";
        private string _tPassword = "";
        //DB
        SqlCommand sqlCom;
        public void Cpv_Connect()
        {
            bConFT = false;
            try
            {
                string strConn = "Data Source=" + _tServer.Trim() + ";Initial Catalog=" + _tDatabase.Trim() + ";User ID=" + _tAdmin_User.Trim() + ";Password=" + _tPassword + "; Connect Timeout=200";

                if (sqlConCn.State == ConnectionState.Open)
                    sqlConCn.Close();
                sqlConCn.ConnectionString = strConn;
                sqlConCn.Open();
                sqlCom = sqlConCn.CreateCommand();
                sqlCon = new SqlConnection(strConn);
                bConFT = true;

            }
            catch
            {
                bConFT = false;
                return;

            }
            finally
            {

            }

        }

        public Boolean Cpb_Action(string _tAction)
        { 
            try
            {
                Cpv_Connect();
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
                sqlCon.Open();
                SqlCommand sqlCM = new SqlCommand(_tAction, sqlCon);
                sqlCM.ExecuteNonQuery();
                sqlCon.Close();
                return (true);
            }
            catch
            {
                return (false);
            }
            finally
            {
                sqlConCn.Close();
            }
        }


        public DataSet Cpds_ShowDB(string _tSql, string tTable, DataSet _ds)
        {
            if (bConFT == false)
            {
                Cpv_Connect();
            }
            try
            {
                _ds.Clear();
                sqlDa = new SqlDataAdapter(_tSql, sqlCon);

                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
                sqlCon.Open();
                SqlCommandBuilder MyCmd = new SqlCommandBuilder(sqlDa);
                sqlDa.Fill(_ds, tTable);
                sqlCon.Close();

                return (_ds);
            }
            catch
            {

                return (null);
            }
            finally
            {
                sqlConCn.Close();
            }
        }

        public SqlDataAdapter CpsqlDa_returnAda
        {
            get
            {

                return sqlDa;
            }
            set
            {
                sqlDa = value;
            }
        }
    }
}
