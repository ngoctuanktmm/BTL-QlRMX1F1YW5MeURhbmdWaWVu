using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaDinh
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private string _quanHe;

        public string QuanHe
        {
            get { return _quanHe; }
            set { _quanHe = value; }
        }

        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        private string _namSinh;

        public string NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
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


        public GiaDinh(string strMaDV, string strQuanHe, string strHoTen, string dtNamSinh, string strQueQuan, string strDiaChi)
        {
            this._maDV = strMaDV;
            this._quanHe = strQuanHe;
            this._hoTen = strHoTen;
            this._namSinh = dtNamSinh;
            this._queQuan = strQueQuan;
            this._diaChi = strDiaChi;
        }


        public GiaDinh() { }
    }
}
