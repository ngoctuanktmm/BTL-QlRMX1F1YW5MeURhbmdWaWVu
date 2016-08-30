using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace BTL_QuanLyDangVien
{
    public partial class frmChiTiet : Form
    {
        BUS_ThongTin bus_ThongTin = new BUS_ThongTin();

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

        private frmUpdate _frmUpdate;

        public delegate string SendMessage(string Message);
        public SendMessage Sender;
        private string _maDV;
        private string _linkAnh;

        private object row;
        int _itemValue;
        public frmChiTiet()
        {
            InitializeComponent();
            Sender = new SendMessage(getMessage);
            lblChonBG.Visible = false;
            cbBanGhi.Visible = false;
            this.Width = 600;
        }


        private string getMessage(string Message)
        {
            _maDV = Message;
            return _maDV;
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            
        }

        // THÔNG TIN
        private void Load_GroupBox_TT()
        {
            row = dataGridView.DataSource;

            //string _Row = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
           

            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("Text", row, "MADV");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", row, "HOTEN");
            txtTenKS.DataBindings.Clear();
            txtTenKS.DataBindings.Add("Text", row, "HOTENKHAISINH");
            txtBidanh.DataBindings.Clear();
            txtBidanh.DataBindings.Add("Text", row, "BIDANH");

            txtNgaysinh.DataBindings.Clear();
            txtNgaysinh.DataBindings.Add("Text", row, "NGAYSINH");
            
            txtNgaysinh.Text = Split_String(txtNgaysinh.Text);

            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", row, "GIOITINH");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("Text", row, "QUEQUAN");
            rtxtDiachi.DataBindings.Clear();
            rtxtDiachi.DataBindings.Add("Text", row, "DIACHI");

            txtDantoc.DataBindings.Clear();
            txtDantoc.DataBindings.Add("Text", row, "DANTOC");
            txtTongiao.DataBindings.Clear();
            txtTongiao.DataBindings.Add("Text", row, "TONGIAO");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", row, "SDT");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", row, "EMAIL");

            
            foreach(DataGridViewRow _row in dataGridView.Rows)
            {
                foreach (DataGridViewCell _cell in _row.Cells)
                {
                    _linkAnh = _cell.Value.ToString();
                }
            }

            pictureBox1.Image = Image.FromFile(@"C:\Users\Ngoc Tuan\Documents\Visual Studio 2015\Projects\Visual C#\Desktop\BTL_QuanLyDangVien\BTL_QuanLyDangVien\Resources\Avatar\" + _linkAnh);

        }

        // THÊM THÔNG TIN
        private void Load_GroupBox_TTT()
        {
            row = dataGridView.DataSource;

            txt_TTT_MaDV.DataBindings.Clear();
            txt_TTT_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_TTT_NgayVD.DataBindings.Clear();
            txt_TTT_NgayVD.DataBindings.Add("Text", row, "NGAYVAODOAN");
            txt_TTT_NoiVD.DataBindings.Clear();
            txt_TTT_NoiVD.DataBindings.Add("Text", row, "NOIVAODAON");
            txt_TTT_NgayVDL1.DataBindings.Clear();
            txt_TTT_NgayVDL1.DataBindings.Add("Text", row, "NGAYVAODANG_L1");

            txt_TTT_NoiVDL1.DataBindings.Clear();
            txt_TTT_NoiVDL1.DataBindings.Add("Text", row, "NOIVAODANG_L1");
            txt_TTT_NgayCTL1.DataBindings.Clear();
            txt_TTT_NgayCTL1.DataBindings.Add("Text", row, "NGAYCHINHTHUC_L1");
            txt_TTT_NoiCT_L1.DataBindings.Clear();
            txt_TTT_NoiCT_L1.DataBindings.Add("Text", row, "NOICONGNHAN_L1");
            txt_TTT_NguoiGT_L1.DataBindings.Clear();
            txt_TTT_NguoiGT_L1.DataBindings.Add("Text", row, "NGUOIGT_L1");
            
        }

        // TRÌNH ĐỘ
        private void Load_GroupBox_TD()
        {
            row = dataGridView.DataSource;

            txt_TD_MaDV.DataBindings.Clear();
            txt_TD_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_TD_PT.DataBindings.Clear();
            txt_TD_PT.DataBindings.Add("Text", row, "TRINHDOPT");
            txt_TD_Chuyenmon.DataBindings.Clear();
            txt_TD_Chuyenmon.DataBindings.Add("Text", row, "CHUYENMON");
            txt_TD_Hocvi.DataBindings.Clear();
            txt_TD_Hocvi.DataBindings.Add("Text", row, "HOCVI");

            txt_TD_CTHV.DataBindings.Clear();
            txt_TD_CTHV.DataBindings.Add("Text", row, "DATE_HV");
            txt_TD_Hocham.DataBindings.Clear();
            txt_TD_Hocham.DataBindings.Add("Text", row, "HOCHAM");
            txt_TD_CTHH.DataBindings.Clear();
            txt_TD_CTHH.DataBindings.Add("Text", row, "DATE_HH");
            txt_TD_Lyluan.DataBindings.Clear();
            txt_TD_Lyluan.DataBindings.Add("Text", row, "LYLUANCT");
            rtxt_TD_NN.DataBindings.Clear();
            rtxt_TD_NN.DataBindings.Add("Text", row, "NGOAINGU");

        }

        // QUÁ TRÌNH CÔNG TÁC
        private void Load_GroupBox_QTCT()
        {
            row = dataGridView.DataSource;

            txt_QT_MaDV.DataBindings.Clear();
            txt_QT_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_QT_MaPB.DataBindings.Clear();
            txt_QT_MaPB.DataBindings.Add("Text", row, "MAPB");
            txt_QT_TenPB.DataBindings.Add("Text", row, "PHONGBAN");
            txt_QT_Batdau.DataBindings.Clear();
            txt_QT_Batdau.DataBindings.Add("Text", row, "BATDAU");

            txt_QT_Ketthuc.DataBindings.Clear();
            txt_QT_Ketthuc.DataBindings.Add("Text", row, "KETTHUC");
            txt_QT_Congviec.DataBindings.Clear();
            txt_QT_Congviec.DataBindings.Add("Text", row, "CONGVIEC");
            txt_QT_Diadiem.DataBindings.Clear();
            txt_QT_Diadiem.DataBindings.Add("Text", row, "DIADIEM");
            txt_QT_Chucvu.DataBindings.Clear();
            txt_QT_Chucvu.DataBindings.Add("Text", row, "CHUCVU");
        }

        // ĐI NƯỚC NGOÀI
        private void Load_GroupBox_DNN()
        {
            row = dataGridView.DataSource;

            txt_DNN_MaDV.DataBindings.Clear();
            txt_DNN_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_DNN_BD.DataBindings.Clear();
            txt_DNN_BD.DataBindings.Add("Text", row, "BATDAU");
            txt_DNN_KT.DataBindings.Clear();
            txt_DNN_KT.DataBindings.Add("Text", row, "KETTHUC");
            txt_DNN_DD.DataBindings.Clear();
            txt_DNN_DD.DataBindings.Add("Text", row, "DIADIEM");

            rtxt_DNN_ND.DataBindings.Clear();
            rtxt_DNN_ND.DataBindings.Add("Text", row, "NOIDUNG");

        }

        // ĐÀO TẠO - BỒI DƯỠNG
        private void Load_GroupBox_DTBD()
        {
            row = dataGridView.DataSource;

            txt_DT_MaDV.DataBindings.Clear();
            txt_DT_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_DT_BD.DataBindings.Clear();
            txt_DT_BD.DataBindings.Add("Text", row, "BATDAU");
            txt_DT_KT.DataBindings.Clear();
            txt_DT_KT.DataBindings.Add("Text", row, "KETTHUC");
            txt_DT_Tenlop.DataBindings.Clear();
            txt_DT_Tenlop.DataBindings.Add("Text", row, "TENLOP");

            txt_DT_Hinhthuc.DataBindings.Clear();
            txt_DT_Hinhthuc.DataBindings.Add("Text", row, "HINHTHUC");
            txt_DT_Chungchi.DataBindings.Clear();
            txt_DT_Chungchi.DataBindings.Add("Text", row, "CHUNGCHI");
            
        }

        // KHEN THƯỞNG
        private void Load_GroupBox_KT()
        {
            row = dataGridView.DataSource;

            txt_KT_MaDV.DataBindings.Clear();
            txt_KT_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_KT_TG.DataBindings.Clear();
            txt_KT_TG.DataBindings.Add("Text", row, "THOIGIAN");
            txt_KT_Hinhthuc.DataBindings.Clear();
            txt_KT_Hinhthuc.DataBindings.Add("Text", row, "HINHTHUC");
            txt_KT_CapQD.DataBindings.Clear();
            txt_KT_CapQD.DataBindings.Add("Text", row, "CAPQUYETDINH");

            rtxt_KT_Lydo.DataBindings.Clear();
            rtxt_KT_Lydo.DataBindings.Add("Text", row, "LYDO");

        }

        // KỶ LUẬT
        private void Load_GroupBox_KL()
        {
            row = dataGridView.DataSource;

            txt_KL_MaDV.DataBindings.Clear();
            txt_KL_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_KL_TG.DataBindings.Clear();
            txt_KL_TG.DataBindings.Add("Text", row, "THOIGIAN");
            txt_KL_Hinhthuc.DataBindings.Clear();
            txt_KL_Hinhthuc.DataBindings.Add("Text", row, "HINHTHUC");
            txt_KL_CapQD.DataBindings.Clear();
            txt_KL_CapQD.DataBindings.Add("Text", row, "CAPQUYETDINH");

            rtxt_KL_Lydo.DataBindings.Clear();
            rtxt_KL_Lydo.DataBindings.Add("Text", row, "LYDO");

        }

        // GIA ĐÌNH
        private void Load_GroupBox_GD()
        {
            row = dataGridView.DataSource;

            txt_GD_MaDV.DataBindings.Clear();
            txt_GD_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_GD_QH.DataBindings.Clear();
            txt_GD_QH.DataBindings.Add("Text", row, "QUANHE");
            txt_GD_Hoten.DataBindings.Clear();
            txt_GD_Hoten.DataBindings.Add("Text", row, "HOTEN");
            txt_GD_Namsinh.DataBindings.Clear();
            txt_GD_Namsinh.DataBindings.Add("Text", row, "NAMSINH");

            txt_GD_Quequan.DataBindings.Clear();
            txt_GD_Quequan.DataBindings.Add("Text", row, "QUEQUAN");
            rtxt_GD_Diachi.DataBindings.Clear();
            rtxt_GD_Diachi.DataBindings.Add("Text", row, "DIACHI");

        }

        // TỰ NHẬN XÉT
        private void Load_GroupBox_TNX()
        {
            row = dataGridView.DataSource;

            txt_TNX_MaDV.DataBindings.Clear();
            txt_TNX_MaDV.DataBindings.Add("Text", row, "MADV");
            txt_TNX_PC.DataBindings.Clear();
            txt_TNX_PC.DataBindings.Add("Text", row, "PHAMCHAT");
            txt_TNX_DD.DataBindings.Clear();
            txt_TNX_DD.DataBindings.Add("Text", row, "DAODUC");
            txt_TNX_NL.DataBindings.Clear();
            txt_TNX_NL.DataBindings.Add("Text", row, "NANGLUC");

            txt_TNX_QHQC.DataBindings.Clear();
            txt_TNX_QHQC.DataBindings.Add("Text", row, "QUANHE_QC");
            txt_TNX_KD.DataBindings.Clear();
            txt_TNX_KD.DataBindings.Add("Text", row, "KHUYETDIEM");
        }



        //private void cbBanGhi_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch(_itemValue)
        //    {
        //        case 3:
        //            {
        //                //dataGridView.DataSource = bus_ThongTin.ClearDataGridView();
        //                //dataGridView.DataSource = bus_ThongTin.Get_QTCT_MAPB(_maDV, cbBanGhi.SelectedValue.ToString());
        //                //Load_GroupBox_QTCT();

        //                cbBanGhi.DataSource = bus_ThongTin.get_MaPB(_maDV);
        //                cbBanGhi.DisplayMember = "MAPB";
        //                cbBanGhi.ValueMember = "MAPB";

        //                string str = cbBanGhi.SelectedValue.ToString();
        //                MessageBox.Show(str);
        //                break;
        //            }
        //    }
        //}

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView.CurrentRow.Selected = true;
            }
            catch { }
        }


        private void set_Index_cbBanGhi(string str)
        {
            int rowCount = Convert.ToInt32(str);
            for (int i=1; i<=rowCount; i++)
            {
                cbBanGhi.Items.Add(i);
            }

            cbBanGhi.SelectedIndex = 0;
            lblChonBG.Visible = true;
            cbBanGhi.Visible = true;
        }
        

        private void set_Location(int width)
        {
            gbControler.Location = new Point((this.Width - gbControler.Width) / 2, 10);
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int _countRow;
            dataGridView.DataSource = bus_ThongTin.ClearDataGridView();
            _itemValue = cbMenu.SelectedIndex;

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
            lblChonBG.Visible = false;
            cbBanGhi.Visible = false;

            switch (_itemValue)
            {
                case 0:
                    {
                        this.Width = 600;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "THONGTIN");
                        //MessageBox.Show(dataGridView.Rows[0].Selected.ToString());
                        Load_GroupBox_TT();
                        gbThongTin.Location = new Point(15, 165);
                        gbThongTin.Visible = true;
                        break;
                    }
                case 1:
                    {
                        this.Width = 385;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "THEMTHONGTIN");
                        Load_GroupBox_TTT();
                        gbThemThongTin.Location = new Point(15, 165);
                        gbThemThongTin.Visible = true;
                        break;
                    }
                case 2:
                    {
                        this.Width = 530;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "TRINHDO");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_TD();
                        this.Width = 530;
                        gbTrinhdo.Location = new Point(15, 165);
                        gbTrinhdo.Visible = true;
                        break;
                    }
                case 3:
                    {
                        this.Width = 530;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "QUATRINHCT");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_QTCT();
                        this.Width = 550;
                        gbQuatrinhCT.Location = new Point(15, 165);
                        gbQuatrinhCT.Visible = true;
                        break;
                    }
                case 4:
                    {
                        this.Width = 300;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "DAOTAO_BOIDUONG");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_DTBD();
                        this.Width = 335;
                        gbDaoTao.Location = new Point(15, 165);
                        gbDaoTao.Visible = true;
                        break;
                    }
                case 5:
                    {
                        this.Width = 320;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "DINUOCNGOAI");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_DNN();
                        this.Width = 320;
                        gbDiNN.Location = new Point(15, 165);
                        gbDiNN.Visible = true;
                        break;
                    }

                case 6:
                    {
                        this.Width = 320;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "KHENTHUONG");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_KT();
                        this.Width = 320;
                        gbKhenThuong.Location = new Point(15, 165);
                        gbKhenThuong.Visible = true;
                        break;
                    }

                case 7:
                    {
                        this.Width = 320;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "KYLUAT");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_KL();
                        this.Width = 320;
                        gbKyluat.Location = new Point(15, 165);
                        gbKyluat.Visible = true;
                        break;

                    }

                case 8:
                    {
                        this.Width = 320;
                        set_Location(this.Width);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "GIADINH");
                        lblChonBG.Visible = true;
                        cbBanGhi.Visible = true;
                        Load_GroupBox_GD();
                        this.Width = 320;
                        gbGiadinh.Location = new Point(15, 165);
                        gbGiadinh.Visible = true;
                        break;
                    }

                case 9:
                    {
                        this.Width = 300;
                        set_Location(300);
                        dataGridView.DataSource = bus_ThongTin.Get_FullData(_maDV, "TUNHANXET");
                        Load_GroupBox_TNX();
                        this.Width = 320;
                        gbTuNhanXet.Location = new Point(15, 165);
                        gbTuNhanXet.Visible = true;
                        break;
                    }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (_itemValue)
            {
                case 0:
                    {
                        _thongTin = new ThongTin();

                        _thongTin.MaDV = txtMaDV.Text;
                        _thongTin.HoTen = txtHoten.Text;
                        _thongTin.TenKhaiSinh = txtTenKS.Text;
                        _thongTin.BiDanh = txtBidanh.Text;
                        _thongTin.GioiTinh = txtGioitinh.Text;

                        _thongTin.NgaySinh = convertStringToDate(txtNgaysinh.Text);
                        _thongTin.QueQuan = txtQuequan.Text;
                        _thongTin.DiaChi = rtxtDiachi.Text;
                        _thongTin.SDT = txtSDT.Text;

                        _thongTin.Email = txtEmail.Text;
                        _thongTin.DanToc = txtDantoc.Text;
                        _thongTin.TonGiao = txtTongiao.Text;
                        _thongTin.LinkAnh = _linkAnh;

                        _frmUpdate = new frmUpdate(_thongTin, 0);
                        _frmUpdate.Show();

                        break;
                    }
                case 1:
                    {
                        _themThongTin = new ThemThongTin();

                        _themThongTin.MaDV = txt_TTT_MaDV.Text;
                        _themThongTin.NgayVaoDoan = convertStringToDate(txt_TTT_NgayVD.Text);
                        _themThongTin.NoiVaoDoan = txt_TTT_MaDV.Text;
                        _themThongTin.NgayVaoDangL1 = convertStringToDate(txt_TTT_NgayVDL1.Text);

                        _themThongTin.NoiVaoDangL1 = txt_TTT_MaDV.Text;
                        _themThongTin.NgayChinhThucL1 = convertStringToDate(txt_TTT_NgayCTL1.Text);
                        _themThongTin.NoiCongNhanL1 = txt_TTT_MaDV.Text;
                        _themThongTin.NguoiGioiThieuL1 = txt_TTT_MaDV.Text;

                        _frmUpdate = new frmUpdate(_themThongTin, 1);
                        _frmUpdate.Show();
                        break;
                    }
                case 2:
                    {
                        _trinhDo = new TrinhDo();

                        _trinhDo.MaDV = txt_TD_MaDV.Text;
                        _trinhDo.TrinhDoPT = txt_TD_PT.Text;
                        _trinhDo.ChuyenMon = txt_TD_Chuyenmon.Text;
                        _trinhDo.HocVi = txt_TD_Hocvi.Text;

                        _trinhDo.DTHocVi = convertStringToDate(txt_TD_CTHV.Text);
                        _trinhDo.HocHam = txt_TD_Hocham.Text;
                        _trinhDo.DTHocham = convertStringToDate(txt_TD_CTHH.Text);
                        _trinhDo.LyLuanCT = txt_TD_Lyluan.Text;

                        _trinhDo.NgoaiNgu = rtxt_TD_NN.Text;

                        _frmUpdate = new frmUpdate(_trinhDo, 2);
                        _frmUpdate.Show();
                        break;
                    }
                case 3:
                    {
                        _quaTrinhCT = new QuaTrinhCongTac();

                        _quaTrinhCT.MaDV = txt_QT_MaDV.Text;
                        _quaTrinhCT.MaPB = txt_QT_MaPB.Text;
                        _quaTrinhCT.PhongBan = txt_QT_TenPB.Text;
                        _quaTrinhCT.BatDau = convertStringToDate(txt_QT_Batdau.Text);

                        _quaTrinhCT.KetThuc = convertStringToDate(txt_QT_Ketthuc.Text);
                        _quaTrinhCT.CongViec = txt_QT_Congviec.Text;
                        _quaTrinhCT.DiaDiem = txt_QT_Diadiem.Text;
                        _quaTrinhCT.ChucVu = txt_QT_Chucvu.Text;

                        _frmUpdate = new frmUpdate(_quaTrinhCT, 3);
                        _frmUpdate.Show();
                        break;
                    }
                case 4:
                    {
                        _daoTaoBD = new DaoTao_BoiDuong();

                        _daoTaoBD.MaDV = txt_DT_MaDV.Text;
                        _daoTaoBD.BatDau = convertStringToDate(txt_DT_BD.Text);
                        _daoTaoBD.KetThuc = convertStringToDate(txt_DT_KT.Text);
                        _daoTaoBD.TenLop = txt_DT_Tenlop.Text;

                        _daoTaoBD.HinhThuc = txt_DT_Hinhthuc.Text;
                        _daoTaoBD.ChungChi = txt_DT_Chungchi.Text;

                        _frmUpdate = new frmUpdate(_daoTaoBD, 4);
                        _frmUpdate.Show();
                        break;
                    }
                case 5:
                    {
                        _diNuocNgoai = new DiNuocNgoai();

                        _diNuocNgoai.MaDV = txt_DNN_MaDV.Text;
                        _diNuocNgoai.BatDau = convertStringToDate(txt_DNN_BD.Text);
                        _diNuocNgoai.KetThuc = convertStringToDate(txt_DNN_KT.Text);
                        _diNuocNgoai.NoiDung = rtxt_DNN_ND.Text;
                        _diNuocNgoai.DiaDiem = txt_DNN_DD.Text;

                        _frmUpdate = new frmUpdate(_diNuocNgoai, 5);
                        _frmUpdate.Show();
                        break;
                    }

                case 6:
                    {
                        _khenThuong = new KhenThuong();

                        _khenThuong.MaDV = txt_KT_MaDV.Text;
                        _khenThuong.ThoiGian = convertStringToDate(txt_KT_TG.Text);
                        _khenThuong.HinhThuc = txt_KT_Hinhthuc.Text;
                        _khenThuong.CapQD = txt_KT_CapQD.Text;
                        _khenThuong.LyDo = rtxt_KT_Lydo.Text;

                        _frmUpdate = new frmUpdate(_khenThuong, 6);
                        _frmUpdate.Show();
                        break;
                    }

                case 7:
                    {
                        _kyLuat = new KyLuat();

                        _kyLuat.MaDV = txt_KL_MaDV.Text;
                        _kyLuat.ThoiGian = convertStringToDate(txt_KL_TG.Text);
                        _kyLuat.HinhThuc = txt_KL_Hinhthuc.Text;
                        _kyLuat.CapQD = txt_KL_CapQD.Text;
                        _kyLuat.LyDo = rtxt_KL_Lydo.Text;

                        _frmUpdate = new frmUpdate(_kyLuat, 7);
                        _frmUpdate.Show();
                        break;

                    }

                case 8:
                    {
                        _giaDinh = new GiaDinh();

                        _giaDinh.MaDV = txt_GD_MaDV.Text;
                        _giaDinh.QuanHe = txt_GD_QH.Text;
                        _giaDinh.HoTen = txt_GD_Hoten.Text;
                        _giaDinh.NamSinh = txt_GD_Namsinh.Text;
                        _giaDinh.QueQuan = txt_GD_Quequan.Text;
                        _giaDinh.DiaChi = rtxt_GD_Diachi.Text;

                        _frmUpdate = new frmUpdate(_giaDinh, 8);
                        _frmUpdate.Show();
                        break;
                    }

                case 9:
                    {
                        _tuNhanXet = new TuNhanXet();

                        _tuNhanXet.MaDV = txt_TNX_MaDV.Text;
                        _tuNhanXet.PhamChat = txt_TNX_PC.Text;
                        _tuNhanXet.DaoDuc = txt_TNX_DD.Text;
                        _tuNhanXet.NangLuc = txt_TNX_NL.Text;
                        _tuNhanXet.QuanHeQC = txt_TNX_QHQC.Text;
                        _tuNhanXet.KhuyetDiem = txt_TNX_KD.Text;

                        _frmUpdate = new frmUpdate(_tuNhanXet, 9);
                        _frmUpdate.Show();
                        break;
                    }
            }
        }


        private DateTime convertStringToDate(string str)
        {
            DateTime dt = DateTime.ParseExact(str, "MM/dd/yyyy", null);
            return dt;
        }

        private string Split_String(string str)
        {
            string[] _str = str.Split(' ');
            return _str[0];
        }

        
    }
}
