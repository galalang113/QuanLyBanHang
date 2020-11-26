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
        private string _MaSP;
        private string _TenSP;
        private string _LoaiSP;
        private int _DonGia;
        private int _TrangThai;
        private int _SoLuong;
        private int _TongTien;
        private string _MaHD;
        private string _KhuyenMai;
        private int _GiaTriKhuyenMai;
        private string _MaKM;
        private int _TrangThaiKM;
        private string _TenLoaiSP;
        public BEL_SANPHAM()
        {
            this._MaSP = null;
            this._TenSP = null;
            this._LoaiSP = null;
            this._MaHD = null;
            this._KhuyenMai = null;
            this._MaKM = null;
            this._TenLoaiSP = null;
        }
        public BEL_SANPHAM(string masp, string tensp, string loaisp, int dongia, int trangthai)
        {
            this._MaSP = masp;
            this._TenSP = tensp;
            this._DonGia = dongia;
            this._TrangThai = trangthai;
            this._LoaiSP = loaisp;
        }
        public BEL_SANPHAM(DataRow row)
        {
            this._MaSP = row["MaSP"].ToString();
            this._TenSP = row["TenSP"].ToString();
            this._DonGia = (int)row["DonGia"];
            this._KhuyenMai = row["TenKM"].ToString();
            this._GiaTriKhuyenMai = (int)row["GiaTriKM"];
            this._TrangThai = (int)row["TrangThai"];
            this._MaKM= row["MaKM"].ToString();
            this._TrangThaiKM = (int)row["KMTrangthai"];
            this._LoaiSP = row["LoaiSP"].ToString();
            this._TenLoaiSP = row["TenLoaiSP"].ToString();
        }
        public string MaSP
        {
            get { return this._MaSP; }
            set { this._MaSP = value; }
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
        public string LOAISP
        {
            get { return this._LoaiSP; }
            set { this._LoaiSP = value; }
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
        public string KHUYENMAI
        {
            get { return this._KhuyenMai; }
            set { this._KhuyenMai = value; }
        }
        public int GIATRIKHUYENMAI
        {
            get { return this._GiaTriKhuyenMai; }
            set { this._GiaTriKhuyenMai = value; }
        }
        public string MAKM
        {
            get { return this._MaKM; }
            set { this._MaKM = value; }
        }
        public int TrangThaiKM
        {
            get { return this._TrangThaiKM; }
            set { this._TrangThaiKM = value; }
        }
        public string TenLoaiSP
        {
            get { return this._TenLoaiSP; }
            set { this._TenLoaiSP = value; }
        }
    }
}
