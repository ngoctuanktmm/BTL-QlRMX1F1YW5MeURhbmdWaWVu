using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Insert : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable = new DataTable();
        private SqlCommandBuilder comm;

        private SqlConnection _conn = new SqlConnection("Data Source=NGOCTUAN\\SQLEXPRESS;Initial Catalog=QLDV;Integrated Security=True");

        // THÔNG TIN
        public bool Insert_ThongTin(ThongTin thongTin)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_THONGTIN";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = thongTin.MaDV;
            cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = thongTin.HoTen;
            cmd.Parameters.Add("@HOTENKHAISINH", SqlDbType.NVarChar).Value = thongTin.TenKhaiSinh;
            cmd.Parameters.Add("@BIDANH", SqlDbType.NVarChar).Value = thongTin.BiDanh;

            cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = thongTin.GioiTinh;
            cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = thongTin.NgaySinh;
            cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar).Value = thongTin.QueQuan;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = thongTin.DiaChi;

            cmd.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = thongTin.DanToc;
            cmd.Parameters.Add("@TONGIAO", SqlDbType.NVarChar).Value = thongTin.TonGiao;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = thongTin.SDT;
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = thongTin.Email;

            cmd.Parameters.Add("@ANH", SqlDbType.NVarChar).Value = thongTin.LinkAnh;

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


        // THÊM THÔNG TIN
        public bool Insert_ThemThongTin(ThemThongTin themThongTin)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = themThongTin.MaDV;
            cmd.Parameters.Add("@NGAYVAODOAN", SqlDbType.Date).Value = themThongTin.NgayVaoDoan;
            cmd.Parameters.Add("@NOIVAODAON", SqlDbType.NVarChar).Value = themThongTin.NoiVaoDoan;

            if (themThongTin.ViTri == 0)
            {
                cmd.CommandText = "SP_INSERT_THEMTHONGTIN_0";
                cmd.Parameters.Add("@NGAYVAODANG_L1", SqlDbType.Date).Value = themThongTin.NgayVaoDangL1;

                cmd.Parameters.Add("@NOIVAODANG_L1", SqlDbType.NVarChar).Value = themThongTin.NoiVaoDangL1;
                cmd.Parameters.Add("@NGAYCHINHTHUC_L1", SqlDbType.Date).Value = themThongTin.NgayChinhThucL1;
                cmd.Parameters.Add("@NOICONGNHAN_L1", SqlDbType.NVarChar).Value = themThongTin.NoiCongNhanL1;
                cmd.Parameters.Add("@NGUOIGT_L1", SqlDbType.NVarChar).Value = themThongTin.NguoiGioiThieuL1;
            }
            else if (themThongTin.ViTri == 1)
            {
                cmd.CommandText = "SP_INSERT_THEMTHONGTIN_1";
                cmd.Parameters.Add("@NGAYVAODANG_L1", SqlDbType.Date).Value = themThongTin.NgayVaoDangL1;

                cmd.Parameters.Add("@NOIVAODANG_L1", SqlDbType.NVarChar).Value = themThongTin.NoiVaoDangL1;
                cmd.Parameters.Add("@NGUOIGT_L1", SqlDbType.NVarChar).Value = themThongTin.NguoiGioiThieuL1;
            }
            else
            {
                cmd.CommandText = "SP_INSERT_THEMTHONGTIN_2";
            }

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


        // TRÌNH ĐỘ
        public bool Insert_TrinhDo(TrinhDo trinhDo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = trinhDo.MaDV;
            cmd.Parameters.Add("@TRINHDOPT", SqlDbType.NVarChar).Value = trinhDo.TrinhDoPT;
            cmd.Parameters.Add("@CHUYENMON", SqlDbType.NVarChar).Value = trinhDo.ChuyenMon;
            cmd.Parameters.Add("@HOCVI", SqlDbType.NVarChar).Value = trinhDo.HocVi;
            cmd.Parameters.Add("@DATE_HV", SqlDbType.Date).Value = trinhDo.DTHocVi;
            cmd.Parameters.Add("@LYLUANCT", SqlDbType.NVarChar).Value = trinhDo.LyLuanCT;
            cmd.Parameters.Add("@NGOAINGU", SqlDbType.NVarChar).Value = trinhDo.NgoaiNgu;

            if (trinhDo.ViTri == 0)
            {
                cmd.CommandText = "SP_INSERT_TRINHDO_0";
                cmd.Parameters.Add("@HOCHAM", SqlDbType.NVarChar).Value = trinhDo.HocHam;
                cmd.Parameters.Add("@DATE_HH", SqlDbType.Date).Value = trinhDo.DTHocham;
            }
            else
                cmd.CommandText = "SP_INSERT_TRINHDO_1";

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

        // QUÁ TRÌNH CÔNG TÁC.
        public bool Insert_QuaTrinhCT(QuaTrinhCongTac quaTrinhCT)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = quaTrinhCT.MaDV;
            cmd.Parameters.Add("@MAPB", SqlDbType.NVarChar).Value = quaTrinhCT.MaPB;
            cmd.Parameters.Add("@PHONGBAN", SqlDbType.NVarChar).Value = quaTrinhCT.PhongBan;
            cmd.Parameters.Add("@BATDAU", SqlDbType.Date).Value = quaTrinhCT.BatDau;

            cmd.Parameters.Add("@CONGVIEC", SqlDbType.NVarChar).Value = quaTrinhCT.CongViec;
            cmd.Parameters.Add("@DIADIEM", SqlDbType.NVarChar).Value = quaTrinhCT.DiaDiem;
            cmd.Parameters.Add("@CHUCVU", SqlDbType.NVarChar).Value = quaTrinhCT.ChucVu;

            if (quaTrinhCT.ViTri == 0)
            {
                cmd.CommandText = "SP_INSERT_QUATRINHCT_0";
                cmd.Parameters.Add("@KETTHUC", SqlDbType.Date).Value = quaTrinhCT.KetThuc;
            }
            else
                cmd.CommandText = "SP_INSERT_QUATRINHCT_1";

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


        // ĐÀO TẠO - BỒI DƯỠNG.
        public bool Insert_DaoTao_BoiDuong(DaoTao_BoiDuong daoTaoBD)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_DAOTAO_BOIDUONG";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = daoTaoBD.MaDV;
            cmd.Parameters.Add("@BATDAU", SqlDbType.Date).Value = daoTaoBD.BatDau;
            cmd.Parameters.Add("@KETTHUC", SqlDbType.Date).Value = daoTaoBD.KetThuc;
            cmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = daoTaoBD.TenLop;

            cmd.Parameters.Add("@HINHTHUC", SqlDbType.NVarChar).Value = daoTaoBD.HinhThuc;
            cmd.Parameters.Add("@CHUNGCHI", SqlDbType.NVarChar).Value = daoTaoBD.ChungChi;

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


        // ĐI NƯỚC NGOÀI.
        public bool Insert_DiNuocNgoai(DiNuocNgoai diNuocNgoai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_DINUOCNGOAI";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = diNuocNgoai.MaDV;
            cmd.Parameters.Add("@BATDAU", SqlDbType.Date).Value = diNuocNgoai.BatDau;
            cmd.Parameters.Add("@KETTHUC", SqlDbType.Date).Value = diNuocNgoai.KetThuc;
            cmd.Parameters.Add("@NOIDUNG", SqlDbType.NVarChar).Value = diNuocNgoai.NoiDung;
            cmd.Parameters.Add("@DIADIEM", SqlDbType.NVarChar).Value = diNuocNgoai.DiaDiem;

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


        // KHEN THƯỞNG.
        public bool Insert_KhenThuong(KhenThuong khenThuong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_KHENTHUONG";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = khenThuong.MaDV;
            cmd.Parameters.Add("@THOIGIAN", SqlDbType.Date).Value = khenThuong.ThoiGian;
            cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = khenThuong.LyDo;
            cmd.Parameters.Add("@HINHTHUC", SqlDbType.NVarChar).Value = khenThuong.HinhThuc;
            cmd.Parameters.Add("@CAPQUYETDINH", SqlDbType.NVarChar).Value = khenThuong.CapQD;

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


        // KỶ LUẬT.
        public bool Insert_KyLuat(KyLuat kyLuat)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_KYLUAT";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = kyLuat.MaDV;
            cmd.Parameters.Add("@THOIGIAN", SqlDbType.Date).Value = kyLuat.ThoiGian;
            cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = kyLuat.LyDo;
            cmd.Parameters.Add("@HINHTHUC", SqlDbType.NVarChar).Value = kyLuat.HinhThuc;
            cmd.Parameters.Add("@CAPQUYETDINH", SqlDbType.NVarChar).Value = kyLuat.CapQD;

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


        // GIA ĐÌNH.
        public bool Insert_GiaDinh(GiaDinh giaDinh)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_GIADINH";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = giaDinh.MaDV;
            cmd.Parameters.Add("@QUANHE", SqlDbType.NVarChar).Value = giaDinh.QuanHe;
            cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = giaDinh.HoTen;
            cmd.Parameters.Add("@NAMSINH", SqlDbType.NVarChar).Value = giaDinh.NamSinh;

            cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar).Value = giaDinh.QueQuan;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = giaDinh.DiaChi;

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


        public bool Insert_TuNhanXet(TuNhanXet tuNhanXet)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERT_TUNHANXET";

            cmd.Parameters.Add("@MADV", SqlDbType.NVarChar).Value = tuNhanXet.MaDV;
            cmd.Parameters.Add("@PHAMCHAT", SqlDbType.NVarChar).Value = tuNhanXet.PhamChat;
            cmd.Parameters.Add("@DAODUC", SqlDbType.NVarChar).Value = tuNhanXet.DaoDuc;
            cmd.Parameters.Add("@NANGLUC", SqlDbType.NVarChar).Value = tuNhanXet.NangLuc;

            cmd.Parameters.Add("@QUANHE_QC", SqlDbType.NVarChar).Value = tuNhanXet.QuanHeQC;
            cmd.Parameters.Add("@KHUYETDIEM", SqlDbType.NVarChar).Value = tuNhanXet.KhuyetDiem;

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

        public int Insert_DangNhap(string username)
        {
            try
            {
                string sql = "SP_INSERT_DANGNHAP";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@USER", username));

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                int count = new DAL_Login().getLogin(username, username);
                return count;

            }
            catch { return 0; }
        }
    }
}
