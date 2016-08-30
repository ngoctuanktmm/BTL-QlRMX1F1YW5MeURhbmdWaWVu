using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuaTrinhCongTac
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private DateTime _batDau;

        public DateTime BatDau
        {
            get { return _batDau; }
            set { _batDau = value; }
        }

        private DateTime _ketThuc;

        public DateTime KetThuc
        {
            get { return _ketThuc; }
            set { _ketThuc = value; }
        }

        private string _congViec;

        public string CongViec
        {
            get { return _congViec; }
            set { _congViec = value; }
        }

        private string _diaDiem;

        public string DiaDiem
        {
            get { return _diaDiem; }
            set { _diaDiem = value; }
        }

        private string _chucVu;

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }

        private string _maPB;

        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }

        private string _phongBan;

        public string PhongBan
        {
            get { return _phongBan; }
            set { _phongBan = value; }
        }

        private int _viTri;

        public int ViTri
        {
            get { return _viTri; }
            set { _viTri = value; }
        }


        public QuaTrinhCongTac(string strMaDV, DateTime batDau, DateTime ketThuc, string strCongViec, string strDiaDiem, string strChucVu, string maPB, string phongBan, int viTri)
        {
            this._maDV = strMaDV;
            this._batDau = batDau;
            this._ketThuc = ketThuc;
            this._congViec = strCongViec;
            this._diaDiem = strDiaDiem;
            this._chucVu = strChucVu;
            this._maPB = maPB;
            this._phongBan = phongBan;
            this.ViTri = viTri;
        }

        public QuaTrinhCongTac(string strMaDV, DateTime batDau, string strCongViec, string strDiaDiem, string strChucVu, string maPB, string phongBan, int viTri)
        {
            this._maDV = strMaDV;
            this._batDau = batDau;
            this._congViec = strCongViec;
            this._diaDiem = strDiaDiem;
            this._chucVu = strChucVu;
            this._maPB = maPB;
            this._phongBan = phongBan;
            this.ViTri = viTri;
        }

        public QuaTrinhCongTac() { }

    }
}
