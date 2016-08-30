using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTin
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        private string _tenKhaiSinh;

        public string TenKhaiSinh
        {
            get { return _tenKhaiSinh; }
            set { _tenKhaiSinh = value; }
        }

        private string _biDanh;

        public string BiDanh
        {
            get { return _biDanh; }
            set { _biDanh = value; }
        }

        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        private string _queQuan;

        public string QueQuan
        {
            get { return _queQuan; }
            set { _queQuan = value; }
        }

        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private string _danToc;

        public string DanToc
        {
            get { return _danToc; }
            set { _danToc = value; }
        }

        private string _tonGiao;

        public string TonGiao
        {
            get { return _tonGiao; }
            set { _tonGiao = value; }
        }

        private string _linkAnh;

        public string LinkAnh
        {
            get { return _linkAnh; }
            set { _linkAnh = value; }
        }

        private string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }



        public ThongTin(string strMaDV, string strHoten, string strKhaiSinh, string strBiDanh, string strGioiTinh, DateTime dtNgaySinh, string strQueQuan, string strDiaChi, string strDanToc, string strTonGiao, string strAnh, string sdt, string email)
        {
            this._maDV = strMaDV;
            this._hoTen = strHoten;
            this._tenKhaiSinh = strKhaiSinh;
            this._biDanh = strBiDanh;
            this._gioiTinh = strGioiTinh;
            this._ngaySinh = dtNgaySinh;
            this._queQuan = strQueQuan;
            this._diaChi = strDiaChi;
            this._danToc = strDanToc;
            this._tonGiao = strTonGiao;
            this._linkAnh = strAnh;
            this._sdt = sdt;
            this._email = email;
        }

        public ThongTin() { }

    }
}