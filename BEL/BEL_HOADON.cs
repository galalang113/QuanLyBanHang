using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace BEL
{
    public class BEL_HOADON
    {
        private string _MaHD;
        private string _MaNV;
        private string _MaKM;
        private string _Ngaylap;
        private string _GioLap;
        private int _TongTien;
        private int _KhachTra;
        private int _TienThua;
        private int _Trangthai;
        public BEL_HOADON()
        {
            _MaHD = null;
            _MaNV = null;
            _MaKM = null;
            _Ngaylap = null;
            _GioLap = null;
        }
        public BEL_HOADON(DataRow row)
        {
            this._MaHD = row["MaHD"].ToString();
            this._MaNV = row["MaNV"].ToString();
            this._Ngaylap = row["Ngaylap"].ToString();
            this._GioLap = row["GioLap"].ToString();
            this._TongTien = (int)row["TongTien"];
            this._KhachTra = (int)row["KhachTra"];
            this._TienThua = (int)row["TienThua"];
            this._Trangthai = (int)row["Trangthai"];
        }
        public BEL_HOADON(string mahd,string manv, string makm, string ngaylap, int trangthai)
        {
            this._MaHD = mahd;
            this._MaNV = manv;
            this._MaKM = makm;
            this._Ngaylap = ngaylap;
            this._Trangthai = trangthai;
        }
        public string MAHD
        {
            get { return this._MaHD; }
            set { this._MaHD = value; }
        }
        public string MANV
        {
            get { return this._MaNV; }
            set { this._MaNV = value; }
        }
        public string MAKM
        {
            get { return this._MaKM; }
            set { this._MaKM = value; }
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
        public string GIOLAP
        {
            get { return this._GioLap; }
            set { this._GioLap = value; }
        }
        public int TONGTIEN
        {
            get { return this._TongTien; }
            set { this._TongTien = value; }
        }
        public int KHACHTRA
        {
            get { return this._KhachTra; }
            set { this._KhachTra = value; }
        }
        public int TIENTHUA
        {
            get { return this._TienThua; }
            set { this._TienThua = value; }
        }
    }
}
