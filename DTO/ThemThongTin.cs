using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThemThongTin
    {
        private string _maDV;

        public string MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private DateTime _ngayVaoDoan;

        public DateTime NgayVaoDoan
        {
            get { return _ngayVaoDoan; }
            set { _ngayVaoDoan = value; }
        }

        private string _noiVaoDoan;

        public string NoiVaoDoan
        {
            get { return _noiVaoDoan; }
            set { _noiVaoDoan = value; }
        }

        private DateTime _ngayVaoDangL1;

        public DateTime NgayVaoDangL1
        {
            get { return _ngayVaoDangL1; }
            set { _ngayVaoDangL1 = value; }
        }

        private string _noiVaoDangL1;

        public string NoiVaoDangL1
        {
            get { return _noiVaoDangL1; }
            set { _noiVaoDangL1 = value; }
        }

        private DateTime _ngayChinhThucL1;

        public DateTime NgayChinhThucL1
        {
            get { return _ngayChinhThucL1; }
            set { _ngayChinhThucL1 = value; }
        }

        private string _noiCongNhanL1;

        public string NoiCongNhanL1
        {
            get { return _noiCongNhanL1; }
            set { _noiCongNhanL1 = value; }
        }

        private string _nguoiGioiThieuL1;

        public string NguoiGioiThieuL1
        {
            get { return _nguoiGioiThieuL1; }
            set { _nguoiGioiThieuL1 = value; }
        }

        private int _viTri;

        public int ViTri
        {
            get { return _viTri; }
            set { _viTri = value; }
        }


        public ThemThongTin(string strMaDV, DateTime dtVaoDoan, string strNoiVaoDoan, DateTime dtVaoDangL1, string strNoiVaoDangL1, DateTime dtChinhThucL1, string strNoiCongNhanL1, string strNguoiGioiThieuL1, int viTri)
        {
            this._maDV = strMaDV;
            this._ngayVaoDoan = dtVaoDoan;
            this._noiVaoDoan = strNoiVaoDoan;
            this._ngayVaoDangL1 = dtVaoDangL1;
            this._noiVaoDangL1 = strNoiVaoDangL1;
            this._ngayChinhThucL1 = dtChinhThucL1;
            this._noiCongNhanL1 = strNoiCongNhanL1;
            this._nguoiGioiThieuL1 = strNguoiGioiThieuL1;
            this._viTri = viTri;
        }

        public ThemThongTin(string strMaDV, DateTime dtVaoDoan, string strNoiVaoDoan, DateTime dtVaoDangL1, string strNoiVaoDangL1, string strNguoiGioiThieuL1, int viTri)
        {
            this._maDV = strMaDV;
            this._ngayVaoDoan = dtVaoDoan;
            this._noiVaoDoan = strNoiVaoDoan;
            this._ngayVaoDangL1 = dtVaoDangL1;
            this._noiVaoDangL1 = strNoiVaoDangL1;
            this._nguoiGioiThieuL1 = strNguoiGioiThieuL1;
            this._viTri = viTri;
        }

        public ThemThongTin(string strMaDV, DateTime dtVaoDoan, string strNoiVaoDoan, int viTri)
        {
            this._maDV = strMaDV;
            this._ngayVaoDoan = dtVaoDoan;
            this._noiVaoDoan = strNoiVaoDoan;
            this._viTri = viTri;
        }

        public ThemThongTin() { }

    }
}
