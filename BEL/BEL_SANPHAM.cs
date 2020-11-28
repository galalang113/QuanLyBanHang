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
    public class BEL_SANPHAM
    {
        private string _IDSP;
        private string _TenSP;
        private int _DonGia;
        private int _TrangThai;
        private int _SoLuong;
        private int _TongTien;
        private string _MaHD;
        public BEL_SANPHAM()
        {
            this._IDSP = null;
            this._TenSP = null;
            this._MaHD = null;
        }
        public BEL_SANPHAM(string masp, string tensp, int dongia, int trangthai)
        {
            this._IDSP = masp;
            this._TenSP = tensp;
            this._DonGia = dongia;
            this._TrangThai = trangthai;
        }
        public BEL_SANPHAM(DataRow row)
        {
            this._IDSP = row["IDSP"].ToString();
            this._TenSP = row["TenSP"].ToString();
            this._DonGia = (int)row["DonGia"];
            this._TrangThai = (int)row["TrangThai"];
        }
        public string IDSP
        {
            get { return this._IDSP; }
            set { this._IDSP = value; }
        }
        public string TenSP
        {
            get { return this._TenSP; }
            set { this._TenSP = value; }
        }
        public int DonGia
        {
            get { return this._DonGia; }
            set { this._DonGia = value; }
        }
        public int TrangThai
        {
            get { return this._TrangThai; }
            set { this._TrangThai = value; }
        }
        public int SoLuong
        {
            get { return this._SoLuong; }
            set { this._SoLuong = value; }
        }
        public int TongTien
        {
            get { return this._TongTien; }
            set { this._TongTien = value; }
        }
        public string MAHD
        {
            get { return this._MaHD; }
            set { this._MaHD = value; }
        }
    }
}
