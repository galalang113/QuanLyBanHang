using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_CHITIETHOADON
    {
        private string _MaHD;
        private string _TenSP;
        private int _Soluong;
        private string _Ngaylap;
        private int _Trangthai;
        public BEL_CHITIETHOADON()
        {
            _MaHD = null;
            _TenSP = null;
            _Soluong = 0;
            _Ngaylap = null;
            _Trangthai = 0;
        }
        public BEL_CHITIETHOADON(string mahd, string tensp, int soluong, string ngaylap, int trangthai)
        {
            this._MaHD = mahd;
            this._TenSP = tensp;
            this._Soluong = soluong;
            this._Ngaylap = ngaylap;
            this._Trangthai = trangthai;
        }
        public string MAHD
        {
            get { return this._MaHD; }
            set { this._MaHD = value; }
        }
        public string TENSP
        {
            get { return this._TenSP; }
            set { this._TenSP = value; }
        }
        public int SOLUONG
        {
            get { return this._Soluong; }
            set { this._Soluong = value; }
        }
        public string NGAYLAP
        {
            get { return this._Ngaylap; }
            set { this._Ngaylap = value; }
        }
        public int TRANGTHAI
        {
            get { return this._Trangthai; }
            set { this._Trangthai = value; }
        }
    }
}
