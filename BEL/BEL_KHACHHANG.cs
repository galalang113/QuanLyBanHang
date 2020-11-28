using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public  class BEL_KHACHHANG
    {
        private string _IDKH;
        private string _HoTen;
        private string _DienThoai;
        private string _GioiTinh;
        private int _Trangthai;
        public BEL_KHACHHANG()
        {
            this._HoTen = null;
            this._IDKH = null;
            this._GioiTinh = null;
            this._DienThoai = null;
        }
        public BEL_KHACHHANG(BEL_KHACHHANG kh)
        {
            this._HoTen = kh.HoTen;
            this._IDKH = kh.IDKH;
            this._GioiTinh = kh.GioiTinh;
            this._DienThoai = kh.DienThoai;
            this._Trangthai = kh.Trangthai;
        }
        public BEL_KHACHHANG(DataRow row)
        {

            this._HoTen = row["Hoten"].ToString();
            this._IDKH = row["IDKH"].ToString();
            this._GioiTinh = row["Gioitinh"].ToString();
            this._DienThoai = row["Dienthoai"].ToString();
            this._Trangthai = (int)row["Trangthai"];
        }

        public string IDKH { get => _IDKH; set => _IDKH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string DienThoai { get => _DienThoai; set => _DienThoai = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public int Trangthai { get => _Trangthai; set => _Trangthai = value; }
    }
}
