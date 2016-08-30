using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ThongTin
    {
        DAL_ThongTin dal_ThongTin = new DAL_ThongTin();

        public DataTable Get_DanhSach()
        {
            return dal_ThongTin.Get_DanhSach();
        }

        public DataTable Search_DanhSach(string input)
        {
            return dal_ThongTin.Search_DanhSach(input);
        }

        public DataTable ClearDataGridView()
        {
            return dal_ThongTin.ClearDataGridView();
        }

        public DataTable Get_FullData(string maDV, string tenBang)
        {
            return dal_ThongTin.Get_FullData(maDV, tenBang);
        }

        public DataTable Get_QTCT_MAPB(string maDV, string maPB)
        {
            return dal_ThongTin.Get_QTCT_MAPB(maDV, maPB);
        }

        public DataTable Get_QuaTrinhCongTac(string maDV)
        {
            return dal_ThongTin.Get_QuaTrinhCongTac(maDV);
        }

        public DataTable get_MaPB(string str)
        {
            return dal_ThongTin.get_MaPB(str);
        }
    }
}
