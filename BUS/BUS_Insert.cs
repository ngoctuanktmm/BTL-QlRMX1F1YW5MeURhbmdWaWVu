using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Insert
    {
        DAL_Insert dal_Insert = new DAL_Insert();

        public int Insert_DangNhap(string username)
        {
            return dal_Insert.Insert_DangNhap(username);
        }

        // THÔNG TIN
        public bool Insert_ThongTin(ThongTin thongTin)
        {
            return dal_Insert.Insert_ThongTin(thongTin);
        }

        // THÊM THÔNG TIN
        public bool Insert_ThemThongTin(ThemThongTin themThongTin)
        {
            return dal_Insert.Insert_ThemThongTin(themThongTin);
        }


        // TRÌNH ĐỘ
        public bool Insert_TrinhDo(TrinhDo trinhDo)
        {
            return dal_Insert.Insert_TrinhDo(trinhDo);
        }


        // QUÁ TRÌNH CÔNG TÁC.
        public bool Insert_QuaTrinhCongTac(QuaTrinhCongTac quaTrinhCT)
        {
            return dal_Insert.Insert_QuaTrinhCT(quaTrinhCT);
        }


        // ĐÀO TẠO - BỒI DƯỠNG.
        public bool Insert_DaoTao_BoiDuong(DaoTao_BoiDuong daoTaoBD)
        {
            return dal_Insert.Insert_DaoTao_BoiDuong(daoTaoBD);
        }


        // ĐI NƯỚC NGOÀI.
        public bool Insert_DiNuocNgoai(DiNuocNgoai diNuocNgoai)
        {
            return dal_Insert.Insert_DiNuocNgoai(diNuocNgoai);
        }


        // KHEN THƯỞNG.
        public bool Insert_KhenThuong(KhenThuong khenThuong)
        {
            return dal_Insert.Insert_KhenThuong(khenThuong);
        }


        // KỶ LUẬT.
        public bool Insert_KyLuat(KyLuat kyLuat)
        {
            return dal_Insert.Insert_KyLuat(kyLuat);
        }


        // GIA ĐÌNH.
        public bool Insert_GiaDinh(GiaDinh giaDinh)
        {
            return dal_Insert.Insert_GiaDinh(giaDinh);
        }


        public bool Insert_TuNhanXet(TuNhanXet tuNhanXet)
        {
            return dal_Insert.Insert_TuNhanXet(tuNhanXet);
        }
    }
}
