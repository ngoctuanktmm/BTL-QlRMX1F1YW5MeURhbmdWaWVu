using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDo
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private string _trinhDoPT;

        public string TrinhDoPT
        {
            get { return _trinhDoPT; }
            set { _trinhDoPT = value; }
        }

        private string _chuyenMon;

        public string ChuyenMon
        {
            get { return _chuyenMon; }
            set { _chuyenMon = value; }
        }

        private string _hocVi;

        public string HocVi
        {
            get { return _hocVi; }
            set { _hocVi = value; }
        }

        private DateTime _dtHocVi;

        public DateTime DTHocVi
        {
            get { return _dtHocVi; }
            set { _dtHocVi = value; }
        }


        private string _hocHam;

        public string HocHam
        {
            get { return _hocHam; }
            set { _hocHam = value; }
        }

        private DateTime _dtHocHam;

        public DateTime DTHocham
        {
            get { return _dtHocHam; }
            set { _dtHocHam = value; }
        }


        private string _lyLuanCT;

        public string LyLuanCT
        {
            get { return _lyLuanCT; }
            set { _lyLuanCT = value; }
        }

        private string _ngoaiNgu;

        public string NgoaiNgu
        {
            get { return _ngoaiNgu; }
            set { _ngoaiNgu = value; }
        }

        private int _viTri;

        public int ViTri
        {
            get { return _viTri; }
            set { _viTri = value; }
        }



        public TrinhDo(string strMaDV, string strTrinhDoPT, string strChuyenMon, string strHocVi, DateTime dtHocVi, string strHocHam, DateTime dtHocHam, string strLyLuanCT, string strNgoaiNgu, int viTri)
        {
            this._maDV = strMaDV;
            this._trinhDoPT = strTrinhDoPT;
            this._chuyenMon = strChuyenMon;
            this._hocVi = strHocVi;
            this._dtHocVi = dtHocVi;
            this._hocHam = strHocHam;
            this._dtHocHam = dtHocHam;
            this._lyLuanCT = strLyLuanCT;
            this._ngoaiNgu = strNgoaiNgu;
            this._viTri = viTri;
        }

        public TrinhDo(string strMaDV, string strTrinhDoPT, string strChuyenMon, string strHocVi, DateTime dtHocVi, string strLyLuanCT, string strNgoaiNgu, int viTri)
        {
            this._maDV = strMaDV;
            this._trinhDoPT = strTrinhDoPT;
            this._chuyenMon = strChuyenMon;
            this._hocVi = strHocVi;
            this._dtHocVi = dtHocVi;
            this._lyLuanCT = strLyLuanCT;
            this._ngoaiNgu = strNgoaiNgu;
            this._viTri = viTri;
        }

        public TrinhDo() { }

    }
}
