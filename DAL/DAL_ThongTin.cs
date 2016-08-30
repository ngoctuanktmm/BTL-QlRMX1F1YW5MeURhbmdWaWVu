using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThongTin : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable = new DataTable();
        private SqlCommandBuilder comm;

        public DAL_ThongTin()
        {
            dataTable = Get_DanhSach();
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[0] };
        }

        public DataTable Get_DanhSach()
        {
            try
            {
                string sql = "SP_GET_DANHSACH";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch { return null; }
        }

        public DataTable Search_DanhSach(string input)
        {
            try
            {
                string sql = "SP_SEARCH_DANHSACH";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.Parameters.Add(new SqlParameter(@"INPUT", input));
                command.CommandType = CommandType.StoredProcedure;

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable ClearDataGridView()
        {
            dataTable.Clear();
            return dataTable;
        }

        public DataTable Get_FullData(string maDV, string tenBang)
        {
            try
            {
                string sql = "SELECT * FROM " + tenBang + " WHERE MADV = N'" + maDV + "'";
                dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_TrinhDo()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM TRINHDO", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_QuaTrinhCongTac(string maDV)
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM QUATRINHCT WHERE MADV = N'" + maDV + "'", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_QTCT_MAPB(string maDV, string maPB)
        {
            try
            {
                string sql = "SP_GET_QTCT_MAPB";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@MADV", maDV));
                command.Parameters.Add(new SqlParameter("@MAPB", maPB));

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_DaoTao_BoiDuong()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM DAOTAO_BOIDUONG", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_DiNuocNgoai()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM DINUOCNGOAI", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_KhenThuong()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM KHENTHUONG", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_KyLuat()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM KYLUAT", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_GiaDinh()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM GIADINH", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }

        public DataTable Get_TuNhanXet()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM TUNHANXET", conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }


        public DataTable get_MaPB(string maDV)
        {
            try
            {
                string sql = "SELECT * FROM QUATRINHCT WHERE MADV = N'" + maDV + "'";
                dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch { return null; }
        }


    }
}
