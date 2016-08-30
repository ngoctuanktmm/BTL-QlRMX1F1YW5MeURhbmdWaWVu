using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Login : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable = new DataTable();

        public int getLogin(string user, string password)
        {
            try
            {
                string sql = "SP_LOGIN";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@USER", user));
                command.Parameters.Add(new SqlParameter("@PASSWORD", password));

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                int count = dataTable.Rows.Count;
                
                return count;
                
            }
            catch { return 0; }
        }


        public bool createAccount(string maDV)
        { 

            string strConn = "Data Source=NGOCTUAN\\SQLEXPRESS;Initial Catalog=QLDV;Integrated Security=True";

            SqlConnection _conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_DANGNHAP";

            cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = maDV;

            cmd.Connection = _conn;

            try
            {
                _conn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
            finally { _conn.Close(); }

        }
    }
}
