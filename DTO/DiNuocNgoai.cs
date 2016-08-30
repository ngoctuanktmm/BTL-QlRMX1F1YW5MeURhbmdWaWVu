using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiNuocNgoai
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



        private string _noiDung;

        public string NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }

        private string _diaDiem;

        public string DiaDiem
        {
            get { return _diaDiem; }
            set { _diaDiem = value; }
        }

        public DiNuocNgoai(string strMaDV, DateTime batDau, DateTime ketThuc, string strNoiDung, string strDiaDiem)
        {
            this._maDV = strMaDV;
            this._batDau = batDau;
            this._ketThuc = ketThuc;
            this._noiDung = strNoiDung;
            this._diaDiem = strDiaDiem;
        }

        public DiNuocNgoai() { }
    }
}
