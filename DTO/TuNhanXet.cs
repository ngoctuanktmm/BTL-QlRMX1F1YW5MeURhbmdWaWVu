using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuNhanXet
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private string _phamChat;

        public string PhamChat
        {
            get { return _phamChat; }
            set { _phamChat = value; }
        }

        private string _daoDuc;

        public string DaoDuc
        {
            get { return _daoDuc; }
            set { _daoDuc = value; }
        }

        private string _nangLuc;

        public string NangLuc
        {
            get { return _nangLuc; }
            set { _nangLuc = value; }
        }

        private string _quanHeQC;

        public string QuanHeQC
        {
            get { return _quanHeQC; }
            set { _quanHeQC = value; }
        }

        private string _khuyetDiem;

        public string KhuyetDiem
        {
            get { return _khuyetDiem; }
            set { _khuyetDiem = value; }
        }


        public TuNhanXet(string strMaDV, string strPhamChat, string strDaoDuc, string strNangLuc, string strQuanHeQC, string strKhuyetDiem)
        {
            this._maDV = strMaDV;
            this._phamChat = strPhamChat;
            this._daoDuc = strDaoDuc;
            this._nangLuc = strNangLuc;
            this._quanHeQC = strQuanHeQC;
            this._khuyetDiem = strKhuyetDiem;
        }

        public TuNhanXet() { }
    }
}
