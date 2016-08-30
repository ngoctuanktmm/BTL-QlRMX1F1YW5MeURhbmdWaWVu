using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_Update : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable = new DataTable();
        private SqlCommandBuilder comm;

        private SqlConnection _conn = new SqlConnection("Data Source=NGOCTUAN\\SQLEXPRESS;Initial Catalog=QLDV;Integrated Security=True");


        public bool Update_ThongTin(ThongTin thongTin)
        {
            try
            {
                string sql = "SP_UPDATE_THONGTIN";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@MADV", thongTin.MaDV));
                command.Parameters.Add(new SqlParameter("@HOTEN", thongTin.HoTen));
                command.Parameters.Add(new SqlParameter("@HOTENKHAISINH", thongTin.TenKhaiSinh));
                command.Parameters.Add(new SqlParameter("@BIDANH", thongTin.BiDanh));

                command.Parameters.Add(new SqlParameter("@GIOITINH", thongTin.GioiTinh));
                command.Parameters.Add(new SqlParameter("@NGAYSINH", thongTin.NgaySinh));
                command.Parameters.Add(new SqlParameter("@QUEQUAN", thongTin.QueQuan));
                command.Parameters.Add(new SqlParameter("@DIACHI", thongTin.DiaChi));

                command.Parameters.Add(new SqlParameter("@DANTOC", thongTin.DanToc));
                command.Parameters.Add(new SqlParameter("@TONGIAO", thongTin.TonGiao));
                command.Parameters.Add(new SqlParameter("@SDT", thongTin.SDT));
                command.Parameters.Add(new SqlParameter("@EMAIL", thongTin.Email));

                command.Parameters.Add(new SqlParameter("@ANH", thongTin.LinkAnh));


                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                return true;

            }
            catch { return false; }
        }

        public bool Update_ThemThongTin(ThemThongTin themThongTin)
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM THEMTHONGTIN", conn);
                DataRow row = dataTable.Rows.Find(themThongTin.MaDV);

                if (row != null)
                {
                    row["NGAYVAODOAN"] = themThongTin.NgayVaoDoan;
                    row["NOIVAODOAN"] = themThongTin.NoiVaoDoan;
                    row["NGAYVAODANG_L1"] = themThongTin.NgayVaoDangL1;
                    row["NOIVAODANG_L1"] = themThongTin.NoiVaoDangL1;
                    row["NGAYCHINHTHUC_L1"] = themThongTin.NgayChinhThucL1;
                    row["NOICONGNHAN_L1"] = themThongTin.NoiVaoDangL1;
                    row["NGUOIGT_L1"] = themThongTin.NguoiGioiThieuL1;

                }

                comm = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataTable);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // TRÌNH ĐỘ
        public bool Update_TrinhDo(TrinhDo trinhDo)
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
                cmd.CommandText = "SP_Update_TRINHDO_0";
                cmd.Parameters.Add("@HOCHAM", SqlDbType.NVarChar).Value = trinhDo.HocHam;
                cmd.Parameters.Add("@DATE_HH", SqlDbType.Date).Value = trinhDo.DTHocham;
            }
            else
                cmd.CommandText = "SP_Update_TRINHDO_1";

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
        public bool Update_QuaTrinhCT(QuaTrinhCongTac quaTrinhCT)
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
                cmd.CommandText = "SP_Update_QUATRINHCT_0";
                cmd.Parameters.Add("@KETTHUC", SqlDbType.Date).Value = quaTrinhCT.KetThuc;
            }
            else
                cmd.CommandText = "SP_Update_QUATRINHCT_1";

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
        public bool Update_DaoTao_BoiDuong(DaoTao_BoiDuong daoTaoBD)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_DAOTAO_BOIDUONG";

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
        public bool Update_DiNuocNgoai(DiNuocNgoai diNuocNgoai)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_DINUOCNGOAI";

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
        public bool Update_KhenThuong(KhenThuong khenThuong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_KHENTHUONG";

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
        public bool Update_KyLuat(KyLuat kyLuat)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_KYLUAT";

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
        public bool Update_GiaDinh(GiaDinh giaDinh)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_GIADINH";

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


        public bool Update_TuNhanXet(TuNhanXet tuNhanXet)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_TUNHANXET";

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



        public int Update_Password(string user, string password, string newPassword)
        {
            try
            {
                string sql = "SP_CHANGE_PASSWORD";
                SqlCommand command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@USER", user));
                command.Parameters.Add(new SqlParameter("@PASSWORD", password));
                command.Parameters.Add(new SqlParameter("@NEWPASSWORD", newPassword));

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                int count = new DAL_Login().getLogin(user, newPassword);

                return count;

            }
            catch { return 0; }
        }

    }
}
