using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_CHITIETHOADON
    {
        private string _IDHD;
        private string _IDSP;
        private int _Soluong;
        private int _ThanhTien;
        public BEL_CHITIETHOADON()
        {
            _IDHD = null;
            _IDSP = null;
        }
        public BEL_CHITIETHOADON(BEL_SANPHAM sp)
        {
            this._IDSP = sp.IDSP;
            this._Soluong = sp.SoLuong;
            this._ThanhTien = (sp.SoLuong * sp.DonGia);
        }
        public BEL_CHITIETHOADON(DataRow row)
        {
            this._IDHD = row["IDHD"].ToString();
            this._Soluong = int.Parse(row["Soluong"].ToString());
            this._ThanhTien  = int.Parse(row["ThanhTien"].ToString());
            this._IDSP = row["IDSP"].ToString();
        }
        public BEL_CHITIETHOADON(string idhd, string idsp, int soluong, int thanhtien)
        {
            this._IDHD = idhd;
            this._IDSP = idsp;
            this._Soluong = soluong;
            this._ThanhTien = thanhtien;
        }
        public string IDHD
        {
            get { return this._IDHD; }
            set { this._IDHD = value; }
        }
        public string IDSP
        {
            get { return this._IDSP; }
            set { this._IDSP = value; }
        }
        public int SOLUONG
        {
            get { return this._Soluong; }
            set { this._Soluong = value; }
        }
        public int ThanhTien
        {
            get { return this._ThanhTien; }
            set { this._ThanhTien = value; }
        }
    }
}
