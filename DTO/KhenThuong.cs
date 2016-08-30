using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhenThuong
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private DateTime _thoiGian;

        public DateTime ThoiGian
        {
            get { return _thoiGian; }
            set { _thoiGian = value; }
        }

        private string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }

        private string _hinhThuc;

        public string HinhThuc
        {
            get { return _hinhThuc; }
            set { _hinhThuc = value; }
        }

        private string _capQD;

        public string CapQD
        {
            get { return _capQD; }
            set { _capQD = value; }
        }

        public KhenThuong(string strMaDV, DateTime dtThoiGian, string strLyDo, string strHinhThuc, string strCapQD)
        {
            this._maDV = strMaDV;
            this._thoiGian = dtThoiGian;
            this._lyDo = strLyDo;
            this._hinhThuc = strHinhThuc;
            this._capQD = strCapQD;
        }


        public KhenThuong() { }

    }
}
