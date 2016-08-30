using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DaoTao_BoiDuong
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

        private string _tenLop;

        public string TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }

        private string _hinhThuc;

        public string HinhThuc
        {
            get { return _hinhThuc; }
            set { _hinhThuc = value; }
        }

        private string _chungChi;

        public string ChungChi
        {
            get { return _chungChi; }
            set { _chungChi = value; }
        }



        public DaoTao_BoiDuong(string strMaDV, DateTime batDau, DateTime ketThuc, string strTenLop, string strHinhThuc, string strChungChi)
        {
            this._maDV = strMaDV;
            this._batDau = batDau;
            this._ketThuc = ketThuc;
            this._tenLop = strTenLop;
            this._hinhThuc = strHinhThuc;
            this._chungChi = strChungChi;
        }

        public DaoTao_BoiDuong() { }

    }
}
