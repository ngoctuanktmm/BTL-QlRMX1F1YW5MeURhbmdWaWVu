using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;
using BUS;

namespace BTL_QuanLyDangVien
{
    public partial class frmUpdate : Form
    {

        BUS_Update bus_Update = new BUS_Update();

        private ThongTin _thongTin;
        private ThemThongTin _themThongTin;
        private TrinhDo _trinhDo;
        private QuaTrinhCongTac _quaTrinhCT;
        private DaoTao_BoiDuong _daoTaoBD;
        private DiNuocNgoai _diNuocNgoai;
        private KhenThuong _khenThuong;
        private KyLuat _kyLuat;
        private GiaDinh _giaDinh;
        private TuNhanXet _tuNhanXet;

        private int _itemValue;

        
        private string _maDV;

        public frmUpdate(Object obj, int item)
        {
            InitializeComponent();

            gbThongTin.Visible = false;
            gbThemThongTin.Visible = false;
            gbTrinhdo.Visible = false;
            gbQuatrinhCT.Visible = false;
            gbDaoTao.Visible = false;
            gbDiNN.Visible = false;
            gbKhenThuong.Visible = false;
            gbKyluat.Visible = false;
            gbGiadinh.Visible = false;
            gbTuNhanXet.Visible = false;

            switch (item)
            {
                case 0:
                    this._thongTin = (ThongTin)obj;
                    Update_ThongTin(_thongTin);
                    gbThongTin.Visible = true;
                    break;
                case 1:
                    this._themThongTin = (ThemThongTin)obj;
                    Update_ThemThongTin(_themThongTin);
                    gbThemThongTin.Visible = true;
                    break;
                case 2:
                    this._trinhDo = (TrinhDo)obj;
                    Update_TrinhDo(_trinhDo);
                    gbTrinhdo.Visible = true;
                    break;
                case 3:
                    this._quaTrinhCT = (QuaTrinhCongTac)obj;
                    Update_QTCT(_quaTrinhCT);
                    gbQuatrinhCT.Visible = true;
                    break;
                case 4:
                    this._daoTaoBD = (DaoTao_BoiDuong)obj;
                    Update_DTBD(_daoTaoBD);
                    gbDaoTao.Visible = true;
                    break;
                case 5:
                    this._diNuocNgoai = (DiNuocNgoai)obj;
                    Update_DNN(_diNuocNgoai);
                    gbDiNN.Visible = true;
                    break;
                case 6:
                    this._khenThuong = (KhenThuong)obj;
                    Update_KT(_khenThuong);
                    gbKhenThuong.Visible = true;
                    break;
                case 7:
                    this._kyLuat = (KyLuat)obj;
                    Update_KL(_kyLuat);
                    gbKyluat.Visible = true;
                    break;
                case 8:
                    this._giaDinh = (GiaDinh)obj;
                    Update_GD(_giaDinh);
                    gbGiadinh.Visible = true;
                    break;
                case 9:
                    this._tuNhanXet = (TuNhanXet)obj;
                    Update_TNX(_tuNhanXet);
                    gbTuNhanXet.Visible = true;
                    break;
            }
            
        }


        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (_itemValue)
            {
                case 0:
                    {
                        Update_ThongTin(_thongTin);
                        if (bus_Update.Update_ThongTin(_thongTin))
                        {
                            CopyFile(txtFileName.Text, @"C:\Users\Ngoc Tuan\Documents\Visual Studio 2015\Projects\Visual C#\Desktop\BTL_QuanLyDangVien\BTL_QuanLyDangVien\Resources\Avatar\");
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 1:
                    {
                        Update_ThemThongTin(_themThongTin);
                        if (bus_Update.Update_ThemThongTin(_themThongTin))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 2:
                    {
                        Update_TrinhDo(_trinhDo);
                        if (bus_Update.Update_TrinhDo(_trinhDo))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 3:
                    {
                        Update_QTCT(_quaTrinhCT);
                        if (bus_Update.Update_QuaTrinhCongTac(_quaTrinhCT))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 4:
                    {
                        Update_DTBD(_daoTaoBD);
                        if (bus_Update.Update_DaoTao_BoiDuong(_daoTaoBD))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 5:
                    {
                        Update_DNN(_diNuocNgoai);
                        if (bus_Update.Update_DiNuocNgoai(_diNuocNgoai))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 6:
                    {
                        Update_KT(_khenThuong);
                        if (bus_Update.Update_KhenThuong(_khenThuong))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 7:
                    {
                        Update_KL(_kyLuat);
                        if (bus_Update.Update_KyLuat(_kyLuat))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 8:
                    {
                        Update_GD(_giaDinh);
                        if (bus_Update.Update_GiaDinh(_giaDinh))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 9:
                    {
                        Update_TNX(_tuNhanXet);
                        if (bus_Update.Update_TuNhanXet(_tuNhanXet))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        } 



        //Update Thông tin
        private void Update_ThongTin(ThongTin thongTin)
        {
            txtMaDV.Text = thongTin.MaDV;
            txtHoten.Text = thongTin.HoTen;
            txtTenKS.Text = thongTin.TenKhaiSinh;
            txtBidanh.Text = thongTin.BiDanh;
            cb_TT_GT.SelectedText = thongTin.GioiTinh;
            txtNgaysinh.Text = thongTin.NgaySinh.ToShortDateString();
            txtQuequan.Text = thongTin.QueQuan;
            rtxtDiachi.Text = thongTin.DiaChi;
            txtDantoc.Text = thongTin.DanToc;
            txtTongiao.Text = thongTin.TonGiao;
            txtSDT.Text = thongTin.SDT;
            txtEmail.Text = thongTin.Email;


            //if (maDV == "" || hoTen == "" || hoTenKS == "" || gioiTinh == "" || ngaySinh.ToString() == "" || queQuan == "" || diaChi == "" || danToc == "" || tonGiao == "" || sdt == "" || email == "" || linkAnh == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _thongTin = new ThongTin(maDV, hoTen, hoTenKS, biDanh, gioiTinh, ngaySinh, queQuan, diaChi, danToc, tonGiao, linkAnh, sdt, email);
            //    return _thongTin;
            //}

            pictureBox.Image = Image.FromFile(@"C:\Users\Ngoc Tuan\Documents\Visual Studio 2015\Projects\Visual C#\Desktop\BTL_QuanLyDangVien\BTL_QuanLyDangVien\Resources\Avatar\" + thongTin.LinkAnh);
        }


        //Update Thêm thông tin
        private void Update_ThemThongTin(ThemThongTin themThongTin)
        {
            txt_TTT_MaDV.Text = themThongTin.MaDV;
            txt_TTT_NoiVD.Text = themThongTin.NoiVaoDoan;
            txt_TTT_NoiVDL1.Text = themThongTin.NoiVaoDangL1;
            txt_TTT_NoiCT_L1.Text = themThongTin.NoiCongNhanL1;
            txt_TTT_NguoiGT_L1.Text = themThongTin.NguoiGioiThieuL1;

            txt_TTT_NgayVD.Text = themThongTin.NgayVaoDoan.ToShortDateString();
            txt_TTT_NgayVDL1.Text = themThongTin.NgayVaoDangL1.ToShortDateString();
            txt_TTT_NgayCTL1.Text = themThongTin.NgayChinhThucL1.ToShortDateString();

            //DateTime ngayVaoDoan = ConvertStringToDate(txt_TTT_NgayVD.Text);
            //DateTime ngayVaoDangL1;
            //DateTime ngayCTL1;

            //if (maDV == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Mã ĐV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;

            //}
            //else
            //{
            //    if (strVDL1 != "")
            //    {
            //        ngayVaoDangL1 = ConvertStringToDate(txt_TTT_NgayVDL1.Text);
            //        if (strCTL1 != "")
            //        {
            //            ngayCTL1 = ConvertStringToDate(txt_TTT_NgayCTL1.Text);
            //            _themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, ngayVaoDangL1, noiVaoDangL1, ngayCTL1, noiCTL1, nguoiGTL1, 0);

            //        }
            //        else
            //        {
            //            _themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, ngayVaoDangL1, noiVaoDangL1, nguoiGTL1, 1);

            //        }
            //    }
            //    else
            //    {
            //        _themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, 2);

            //    }
            //    //_themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, ngayVaoDangL1, noiVaoDangL1, ngayCTL1, noiCTL1, nguoiGTL1);
                //return _themThongTin;
            //}

        }

        // Update Trình độ.
        private void Update_TrinhDo(TrinhDo trinhDo)
        {
            txt_TD_MaDV.Text = trinhDo.MaDV;
            txt_TD_PT.Text = trinhDo.TrinhDoPT;
            txt_TD_Chuyenmon.Text = trinhDo.ChuyenMon;
            cb_TD_HV.SelectedText = trinhDo.HocVi;
            cb_TD_HH.SelectedText = trinhDo.HocHam;

            txt_TD_Lyluan.Text = trinhDo.LyLuanCT;
            rtxt_TD_NN.Text = trinhDo.NgoaiNgu;
            txt_TD_CTHV.Text = trinhDo.DTHocVi.ToShortDateString();
            txt_TD_CTHH.Text = trinhDo.DTHocham.ToShortDateString();

            //if (maDV == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Mã ĐV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    if (txt_TD_CTHH.Text != "")
            //    {
            //        dt_HH = ConvertStringToDate(txt_TD_CTHH.Text);
            //        _trinhDo = new TrinhDo(maDV, trinhDoPT, chuyenMon, hocVi, dt_HV, hocHam, dt_HH, lyLuanCT, ngoaiNgu, 0);
            //    }
            //    else
            //        _trinhDo = new TrinhDo(maDV, trinhDoPT, chuyenMon, hocVi, dt_HV, lyLuanCT, ngoaiNgu, 1);

            //    return _trinhDo;
            //}

        }

        // Update Quá trình Công tác.
        private void Update_QTCT(QuaTrinhCongTac quaTrinhCT)
        {
            txt_QT_MaDV.Text = quaTrinhCT.MaDV;
            txt_QT_MaPB.Text = quaTrinhCT.MaPB;
            txt_QT_TenPB.Text = quaTrinhCT.PhongBan;
            txt_QT_Congviec.Text = quaTrinhCT.CongViec;
            txt_QT_Diadiem.Text = quaTrinhCT.DiaDiem;
            txt_QT_Chucvu.Text = quaTrinhCT.ChucVu;

            txt_QT_Batdau.Text = quaTrinhCT.BatDau.ToShortDateString();
            txt_QT_Ketthuc.Text = quaTrinhCT.KetThuc.ToShortDateString();

            //if (maDV == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Mã ĐV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    if (txt_QT_Ketthuc.Text != "")
            //    {
            //        dt_KT = ConvertStringToDate(txt_QT_Ketthuc.Text);
            //        _quaTrinhCT = new QuaTrinhCongTac(maDV, dt_BD, dt_KT, congViec, diaDiem, chucVu, maPB, phongBan, 0);
            //    }
            //    else
            //        _quaTrinhCT = new QuaTrinhCongTac(maDV, dt_BD, congViec, diaDiem, chucVu, maPB, phongBan, 1);

            //    return _quaTrinhCT;
            //}
        }

        // Update Đào tạo - Bồi dưỡng
        private void Update_DTBD(DaoTao_BoiDuong daoTaoBD)
        {
            txt_DT_MaDV.Text = daoTaoBD.MaDV;
            txt_DT_Tenlop.Text = daoTaoBD.TenLop;
            txt_DT_Hinhthuc.Text = daoTaoBD.HinhThuc;
            txt_DT_Chungchi.Text = daoTaoBD.ChungChi;

            txt_DT_BD.Text = daoTaoBD.BatDau.ToShortDateString();
            txt_DT_BD.Text = daoTaoBD.KetThuc.ToShortDateString();

            //if (maDV == "" || tenLop == "" || hinhThuc == "" || chungChi == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _daoTaoBD = new DaoTao_BoiDuong(maDV, dt_BD, dt_KT, tenLop, hinhThuc, chungChi);
            //    return _daoTaoBD;
            //}

        }

        // Update Đi nước ngoài
        private void Update_DNN(DiNuocNgoai DNN)
        {
            txt_DNN_MaDV.Text = DNN.MaDV;
            rtxt_DNN_ND.Text = DNN.NoiDung;
            txt_DNN_DD.Text = DNN.DiaDiem;

            txt_DNN_BD.Text = DNN.BatDau.ToShortDateString();
            txt_DNN_KT.Text = DNN.KetThuc.ToShortDateString();

            //if (maDV == "" || noiDung == "" || diaDiem == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _diNuocNgoai = new DiNuocNgoai(maDV, dt_BD, dt_KT, noiDung, diaDiem);
            //    return _diNuocNgoai;
            //}

        }

        // Update Khen thưởng
        private void Update_KT(KhenThuong khenThuong)
        {
            txt_KT_MaDV.Text = khenThuong.MaDV;
            rtxt_KT_Lydo.Text = khenThuong.LyDo;
            txt_KT_Hinhthuc.Text = khenThuong.HinhThuc;
            txt_KT_CapQD.Text = khenThuong.CapQD;

            txt_KT_TG.Text = khenThuong.ThoiGian.ToShortDateString();

            //if (maDV == "" || lyDo == "" || hinhThuc == "" || capQD == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _khenThuong = new KhenThuong(maDV, dt_TG, lyDo, hinhThuc, capQD);
            //    return _khenThuong;
            //}

        }

        // Update Kỷ luật
        private void Update_KL(KyLuat kyLuat)
        {
            txt_KL_MaDV.Text = kyLuat.MaDV;
            rtxt_KL_Lydo.Text = kyLuat.LyDo;
            txt_KL_Hinhthuc.Text = kyLuat.HinhThuc;
            txt_KL_CapQD.Text = kyLuat.CapQD;

            txt_KL_TG.Text = kyLuat.ThoiGian.ToShortDateString();

            //if (maDV == "" || lyDo == "" || hinhThuc == "" || capQD == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _kyLuat = new KyLuat(maDV, dt_TG, lyDo, hinhThuc, capQD);
            //    return _kyLuat;
            //}

        }

        // Update Gia đình
        private void Update_GD(GiaDinh giaDinh)
        {
            txt_GD_MaDV.Text = giaDinh.MaDV;
            txt_GD_QH.Text = giaDinh.QuanHe;
            txt_GD_Hoten.Text = giaDinh.HoTen;
            txt_GD_Namsinh.Text = giaDinh.NamSinh;
            txt_GD_Quequan.Text = giaDinh.QueQuan;
            rtxt_GD_Diachi.Text = giaDinh.DiaChi;


            //if (maDV == "" || quanHe == "" || hoTen == "" || namSinh == "" || queQuan == "" || diaChi == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _giaDinh = new GiaDinh(maDV, quanHe, hoTen, namSinh, queQuan, diaChi);
            //    return _giaDinh;
            //}

        }

        // Update Tự nhận xét.
        private void Update_TNX(TuNhanXet TNX)
        {
            txt_TNX_MaDV.Text = TNX.MaDV;
            txt_TNX_PC.Text = TNX.PhamChat;
            txt_TNX_DD.Text = TNX.DaoDuc;
            txt_TNX_NL.Text = TNX.NangLuc;
            txt_TNX_QHQC.Text = TNX.QuanHeQC;
            txt_TNX_KD.Text = TNX.KhuyetDiem;


            //if (maDV == "" || phamChat == "" || daoDuc == "" || nangLuc == "" || quanHeQC == "" || khuyeDiem == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            //else
            //{
            //    _tuNhanXet = new TuNhanXet(maDV, phamChat, daoDuc, nangLuc, quanHeQC, khuyeDiem);
            //    return _tuNhanXet;
            //}

        }

        private DateTime ConvertStringToDate(string str)
        {
            DateTime dt = DateTime.ParseExact(str, "MM/dd/yyyy", null);
            return dt;
        }

        private void CopyFile(string sourcePath, string targetPath)
        {
            string[] str = sourcePath.Split('\\');
            string link = str[str.Length - 1];
            FileInfo file = new FileInfo(sourcePath);
            file.CopyTo(targetPath + link);
        }

        private void btn_TT_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //open.Filter = open.Filter = "JPG files (*.jpg)| *.jpg | All files (*.*) | *.* ";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = open.FileName;
                txtFileName.Text = open.FileName;
            }

        }
    }
}
