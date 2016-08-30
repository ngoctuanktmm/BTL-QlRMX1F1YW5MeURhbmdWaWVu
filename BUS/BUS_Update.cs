using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Update
    {
        DAL_Update dal_Update = new DAL_Update();

        public int Update_Password(string user, string password, string newPassword)
        {
            return dal_Update.Update_Password(user, password, newPassword);
        }


        // THÔNG TIN
        public bool Update_ThongTin(ThongTin thongTin)
        {
            return dal_Update.Update_ThongTin(thongTin);
        }

        // THÊM THÔNG TIN
        public bool Update_ThemThongTin(ThemThongTin themThongTin)
        {
            return dal_Update.Update_ThemThongTin(themThongTin);
        }


        // TRÌNH ĐỘ
        public bool Update_TrinhDo(TrinhDo trinhDo)
        {
            return dal_Update.Update_TrinhDo(trinhDo);
        }


        // QUÁ TRÌNH CÔNG TÁC.
        public bool Update_QuaTrinhCongTac(QuaTrinhCongTac quaTrinhCT)
        {
            return dal_Update.Update_QuaTrinhCT(quaTrinhCT);
        }


        // ĐÀO TẠO - BỒI DƯỠNG.
        public bool Update_DaoTao_BoiDuong(DaoTao_BoiDuong daoTaoBD)
        {
            return dal_Update.Update_DaoTao_BoiDuong(daoTaoBD);
        }


        // ĐI NƯỚC NGOÀI.
        public bool Update_DiNuocNgoai(DiNuocNgoai diNuocNgoai)
        {
            return dal_Update.Update_DiNuocNgoai(diNuocNgoai);
        }


        // KHEN THƯỞNG.
        public bool Update_KhenThuong(KhenThuong khenThuong)
        {
            return dal_Update.Update_KhenThuong(khenThuong);
        }


        // KỶ LUẬT.
        public bool Update_KyLuat(KyLuat kyLuat)
        {
            return dal_Update.Update_KyLuat(kyLuat);
        }


        // GIA ĐÌNH.
        public bool Update_GiaDinh(GiaDinh giaDinh)
        {
            return dal_Update.Update_GiaDinh(giaDinh);
        }


        public bool Update_TuNhanXet(TuNhanXet tuNhanXet)
        {
            return dal_Update.Update_TuNhanXet(tuNhanXet);
        }
    }
}
