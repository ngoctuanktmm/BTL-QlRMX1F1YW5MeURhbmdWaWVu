using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DTO;
using BUS;

namespace BTL_QuanLyDangVien
{
    public partial class frmThemMoi : Form
    {

        BUS_Insert bus_Insert = new BUS_Insert();

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

        public frmThemMoi()
        {
            InitializeComponent();

            this.Width = 300;
            btnInsert.Visible = false;
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

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

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



            _itemValue = cbMenu.SelectedIndex;
            MessageBox.Show(_itemValue.ToString() + "\n"+cbMenu.SelectedItem);

            switch (_itemValue)
            {
                case 0:
                    this.Width = 600;
                    
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbThongTin.Location = new Point(15, 130);
                    gbThongTin.Visible = true;
                    cb_TT_GT.SelectedIndex = 0;
                    break;
                case 1:
                    this.Width = 385;
                    this.Height = gbThemThongTin.Height +240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbThemThongTin.Location = new Point(15, 130);
                    gbThemThongTin.Visible = true;
                    
                    break;
                case 2:
                    this.Width = 530;
                    this.Height = gbTrinhdo.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbTrinhdo.Location = new Point(15, 130);
                    gbTrinhdo.Visible = true;
                    cb_TD_HV.SelectedIndex = 0;
                    cb_TD_HH.SelectedIndex = 0;
                    break;
                case 3:
                    this.Width = 530;
                    this.Height = gbQuatrinhCT.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbQuatrinhCT.Location = new Point(15, 130);
                    gbQuatrinhCT.Visible = true;
                    break;
                case 4:
                    this.Width = 300;
                    this.Height = gbDaoTao.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbDaoTao.Location = new Point(15, 130);
                    gbDaoTao.Visible = true;
                    break;
                case 5:
                    this.Width = 320;
                    this.Height = gbDiNN.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbDiNN.Location = new Point(15, 130);
                    gbDiNN.Visible = true;
                    break;
                case 6:
                    this.Width = 320;
                    this.Height = gbKhenThuong.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbKhenThuong.Location = new Point(15, 130);
                    gbKhenThuong.Visible = true;
                    break;
                case 7:
                    this.Width = 320;
                    this.Height = gbKyluat.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbKyluat.Location = new Point(15, 130);
                    gbKyluat.Visible = true;
                    break;
                case 8:
                    this.Width = 320;
                    this.Height = gbGiadinh.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbGiadinh.Location = new Point(15, 130);
                    gbGiadinh.Visible = true;
                    break;
                case 9:
                    this.Width = 300;
                    this.Height = gbTuNhanXet.Height + 240;
                    lblMenu.Location = new Point(((this.ClientSize.Width - lblMenu.Width) / 2), 15);
                    cbMenu.Location = new Point(((this.ClientSize.Width - cbMenu.Width) / 2), 45);
                    btnInsert.Location = new Point((this.ClientSize.Width - btnInsert.Width) / 2, this.Height - 75);
                    btnInsert.Visible = true;
                    gbTuNhanXet.Location = new Point(15, 130);
                    gbTuNhanXet.Visible = true;
                    break;

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            switch (_itemValue)
            {
                case 0:
                    {
                        Insert_ThongTin();
                        if (bus_Insert.Insert_ThongTin(_thongTin))
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
                        Insert_ThemThongTin();
                        if (bus_Insert.Insert_ThemThongTin(_themThongTin))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 2:
                    {
                        Insert_TrinhDo();
                        if (bus_Insert.Insert_TrinhDo(_trinhDo))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 3:
                    {
                        Insert_QTCT();
                        if (bus_Insert.Insert_QuaTrinhCongTac(_quaTrinhCT))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 4:
                    {
                        Insert_DTBD();
                        if (bus_Insert.Insert_DaoTao_BoiDuong(_daoTaoBD))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 5:
                    {
                        Insert_DNN();
                        if (bus_Insert.Insert_DiNuocNgoai(_diNuocNgoai))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 6:
                    {
                        Insert_KT();
                        if (bus_Insert.Insert_KhenThuong(_khenThuong))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 7:
                    {
                        Insert_KL();
                        if (bus_Insert.Insert_KyLuat(_kyLuat))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 8:
                    {
                        Insert_GD();
                        if (bus_Insert.Insert_GiaDinh(_giaDinh))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 9:
                    {
                        Insert_TNX();
                        if (bus_Insert.Insert_TuNhanXet(_tuNhanXet))
                            MessageBox.Show("Thêm mới Đảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm mới Đảng viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

            }
        }




        //Insert Thông tin
        private ThongTin Insert_ThongTin()
        {
            string maDV = txtMaDV.Text;
            string hoTen = txtHoten.Text;
            string hoTenKS = txtTenKS.Text;
            string biDanh = txtBidanh.Text;
            string gioiTinh = cb_TT_GT.SelectedItem.ToString();
            DateTime ngaySinh = ConvertStringToDate(txtNgaysinh.Text);
            string queQuan = txtQuequan.Text;
            string diaChi = rtxtDiachi.Text;
            string danToc = txtDantoc.Text;
            string tonGiao = txtTongiao.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;

            string[] str = txtFileName.Text.Split('\\');
            string linkAnh = str[str.Length - 1];

            if (maDV == "" || hoTen == "" || hoTenKS == "" || gioiTinh == "" || ngaySinh.ToString() == "" || queQuan == "" || diaChi == "" || danToc == "" || tonGiao == "" || sdt == "" || email == "" || linkAnh == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _thongTin = new ThongTin(maDV, hoTen, hoTenKS, biDanh, gioiTinh, ngaySinh, queQuan, diaChi, danToc, tonGiao, linkAnh, sdt, email);
                return _thongTin;
            }
        }

        //Insert Thêm thông tin
        private ThemThongTin Insert_ThemThongTin()
        {
            string maDV = txt_TTT_MaDV.Text;
            string noiVaoDoan = txt_TTT_NoiVD.Text;
            string noiVaoDangL1 = txt_TTT_NoiVDL1.Text;
            string noiCTL1 = txt_TTT_NoiCT_L1.Text;
            string nguoiGTL1 = txt_TTT_NguoiGT_L1.Text;

            string strVD = txt_TTT_NgayVD.Text;
            string strVDL1 = txt_TTT_NgayVDL1.Text;
            string strCTL1 = txt_TTT_NgayCTL1.Text;

            DateTime ngayVaoDoan = ConvertStringToDate(txt_TTT_NgayVD.Text);
            DateTime ngayVaoDangL1;
            DateTime ngayCTL1;

            if (maDV == "")
            {
                MessageBox.Show("Vui lòng nhập Mã ĐV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
            else
            {
                if (strVDL1 != "" )
                {
                    ngayVaoDangL1 = ConvertStringToDate(txt_TTT_NgayVDL1.Text);
                    if (strCTL1 != "")
                    {
                        ngayCTL1 = ConvertStringToDate(txt_TTT_NgayCTL1.Text);
                        _themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, ngayVaoDangL1, noiVaoDangL1, ngayCTL1, noiCTL1, nguoiGTL1, 0);
                        
                    }
                    else
                    {
                        _themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, ngayVaoDangL1, noiVaoDangL1, nguoiGTL1, 1);
                        
                    }
                }
                else
                {
                    _themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, 2);
                    
                }
                //_themThongTin = new ThemThongTin(maDV, ngayVaoDoan, noiVaoDoan, ngayVaoDangL1, noiVaoDangL1, ngayCTL1, noiCTL1, nguoiGTL1);
                return _themThongTin;
            }

        }

        // Insert Trình độ.
        private TrinhDo Insert_TrinhDo()
        {
            string maDV = txt_TD_MaDV.Text;
            string trinhDoPT = txt_TD_PT.Text;
            string chuyenMon = txt_TD_Chuyenmon.Text;
            string hocVi = cb_TD_HV.SelectedItem.ToString();
            string hocHam = cb_TD_HH.SelectedItem.ToString();

            string lyLuanCT = txt_TD_Lyluan.Text;
            string ngoaiNgu = rtxt_TD_NN.Text;

            DateTime dt_HV = ConvertStringToDate(txt_TD_CTHV.Text);
            DateTime dt_HH;

            if (maDV == "")
            {
                MessageBox.Show("Vui lòng nhập Mã ĐV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                if (txt_TD_CTHH.Text != "")
                {
                    dt_HH = ConvertStringToDate(txt_TD_CTHH.Text);
                    _trinhDo = new TrinhDo(maDV, trinhDoPT, chuyenMon, hocVi, dt_HV, hocHam, dt_HH, lyLuanCT, ngoaiNgu, 0);
                }
                else
                    _trinhDo = new TrinhDo(maDV, trinhDoPT, chuyenMon, hocVi, dt_HV, lyLuanCT, ngoaiNgu, 1);

                return _trinhDo;
            }

        }

        // Insert Quá trình Công tác.
        private QuaTrinhCongTac Insert_QTCT()
        {
            string maDV = txt_QT_MaDV.Text;
            string maPB = txt_QT_MaPB.Text;
            string phongBan = txt_QT_TenPB.Text;
            string congViec = txt_QT_Congviec.Text;
            string diaDiem = txt_QT_Diadiem.Text;
            string chucVu = txt_QT_Chucvu.Text;

            DateTime dt_BD = ConvertStringToDate(txt_QT_Batdau.Text);
            DateTime dt_KT;

            if (maDV == "")
            {
                MessageBox.Show("Vui lòng nhập Mã ĐV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                if (txt_QT_Ketthuc.Text != "")
                {
                    dt_KT = ConvertStringToDate(txt_QT_Ketthuc.Text);
                    _quaTrinhCT = new QuaTrinhCongTac(maDV, dt_BD, dt_KT, congViec, diaDiem, chucVu, maPB, phongBan, 0);
                }
                else
                    _quaTrinhCT = new QuaTrinhCongTac(maDV, dt_BD, congViec, diaDiem, chucVu, maPB, phongBan, 1);

                return _quaTrinhCT;
            }
        }

        // Insert Đào tạo - Bồi dưỡng
        private DaoTao_BoiDuong Insert_DTBD()
        {
            string maDV = txt_DT_MaDV.Text;
            string tenLop = txt_DT_Tenlop.Text;
            string hinhThuc = txt_DT_Hinhthuc.Text;
            string chungChi = txt_DT_Chungchi.Text;

            DateTime dt_BD = ConvertStringToDate(txt_DT_BD.Text);
            DateTime dt_KT = ConvertStringToDate(txt_DT_KT.Text);

            if (maDV == "" || tenLop == "" || hinhThuc == "" || chungChi == "") 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _daoTaoBD = new DaoTao_BoiDuong(maDV, dt_BD, dt_KT, tenLop, hinhThuc, chungChi);
                return _daoTaoBD;
            }

        }

        // Insert Đi nước ngoài
        private DiNuocNgoai Insert_DNN()
        {
            string maDV = txt_DNN_MaDV.Text;
            string noiDung = rtxt_DNN_ND.Text;
            string diaDiem = txt_DNN_DD.Text;

            DateTime dt_BD = ConvertStringToDate(txt_DNN_BD.Text);
            DateTime dt_KT = ConvertStringToDate(txt_DNN_KT.Text);

            if (maDV == "" || noiDung == "" || diaDiem == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _diNuocNgoai = new DiNuocNgoai(maDV, dt_BD, dt_KT, noiDung, diaDiem);
                return _diNuocNgoai;
            }

        }

        // Insert Khen thưởng
        private KhenThuong Insert_KT()
        {
            string maDV = txt_KT_MaDV.Text;
            string lyDo = rtxt_KT_Lydo.Text;
            string hinhThuc = txt_KT_Hinhthuc.Text;
            string capQD = txt_KT_CapQD.Text;

            DateTime dt_TG = ConvertStringToDate(txt_KT_TG.Text);

            if (maDV == "" || lyDo == "" || hinhThuc == "" || capQD == "") 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _khenThuong = new KhenThuong(maDV, dt_TG, lyDo, hinhThuc, capQD);
                return _khenThuong;
            }

        }

        // Insert Kỷ luật
        private KyLuat Insert_KL()
        {
            string maDV = txt_KL_MaDV.Text;
            string lyDo = rtxt_KL_Lydo.Text;
            string hinhThuc = txt_KL_Hinhthuc.Text;
            string capQD = txt_KL_CapQD.Text;

            DateTime dt_TG = ConvertStringToDate(txt_KL_TG.Text);

            if (maDV == "" || lyDo == "" || hinhThuc == "" || capQD == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _kyLuat = new KyLuat(maDV, dt_TG, lyDo, hinhThuc, capQD);
                return _kyLuat;
            }

        }

        // Insert Gia đình
        private GiaDinh Insert_GD()
        {
            string maDV = txt_GD_MaDV.Text;
            string quanHe = txt_GD_QH.Text;
            string hoTen = txt_GD_Hoten.Text;
            string namSinh = txt_GD_Namsinh.Text;
            string queQuan = txt_GD_Quequan.Text;
            string diaChi = rtxt_GD_Diachi.Text;


            if (maDV == "" || quanHe == "" || hoTen == "" || namSinh == "" || queQuan == "" || diaChi == "") 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _giaDinh = new GiaDinh(maDV, quanHe, hoTen, namSinh, queQuan, diaChi);
                return _giaDinh;
            }

        }

        // Insert Tự nhận xét.
        private TuNhanXet Insert_TNX()
        {
            string maDV = txt_TNX_MaDV.Text;
            string phamChat = txt_TNX_PC.Text;
            string daoDuc = txt_TNX_DD.Text;
            string nangLuc = txt_TNX_NL.Text;
            string quanHeQC = txt_TNX_QHQC.Text;
            string khuyeDiem = txt_TNX_KD.Text;


            if (maDV == "" || phamChat == "" || daoDuc == "" || nangLuc == "" || quanHeQC == "" || khuyeDiem == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                _tuNhanXet = new TuNhanXet(maDV, phamChat, daoDuc, nangLuc, quanHeQC, khuyeDiem);
                return _tuNhanXet;
            }

        }

        private DateTime ConvertStringToDate(string str)
        {
            DateTime dt = DateTime.ParseExact(str, "MM/dd/yyyy", null);
            return dt;
        }

        private void CopyFile(string sourcePath, string targetPath )
        {
            string[] str = sourcePath.Split('\\');
            string link = str[str.Length - 1];
            FileInfo file = new FileInfo(sourcePath);
            file.CopyTo(targetPath + link);
        }
        
    }
}
