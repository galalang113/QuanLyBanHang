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
    public class BEL_NHANVIEN
    {
        private string _HoTen;
        private string _IDNV;
        private string _LoaiNV;
        private string _GioiTinh;
        private string _NgaySinh;
        private string _DiaChi;
        private string _TaiKhoan;
        private string _MatKhau;
        private int _TrangThai;
        private string _DienThoai;
        private string _CMND;
        public BEL_NHANVIEN()
        {
            this._HoTen = null;
            this._IDNV = null;
            this._GioiTinh = null;
            this._NgaySinh = null;
            this._DiaChi = null;
            this._TaiKhoan = null;
            this._MatKhau = null;
            this._LoaiNV = null;
            this._DienThoai = null;
            this._CMND = null;
        }

        public BEL_NHANVIEN(string ten, string ma, string gt, string day, string dc, string tk, string mk, int tt)
        {
            this._HoTen = ten;
            this._IDNV = ma;
            this._GioiTinh = gt;
            this._NgaySinh = day;
            this._DiaChi = dc;
            this._TaiKhoan = tk;
            this._MatKhau = mk;
            this._TrangThai = tt;
        }
        public BEL_NHANVIEN(BEL_NHANVIEN nv)
        {
            this._HoTen = nv.Hoten;
            this._IDNV = nv.IDNV;
            this._GioiTinh = nv.GioiTinh;
            this._NgaySinh = nv.NgaySinh;
            this._DiaChi = nv.DiaChi;
            this._TaiKhoan = nv.TaiKhoan;
            this._MatKhau = nv.MatKhau;
            this._LoaiNV = nv.LoaiNV;
            this._DienThoai = nv.DienThoai;
            this._TrangThai = nv.TrangThai;
            this._CMND = nv._CMND;
        }
        public BEL_NHANVIEN(DataRow row)
        {

            this._HoTen = row["Hoten"].ToString(); 
            this._IDNV = row["IDNV"].ToString();
            this._GioiTinh = row["Gioitinh"].ToString();
            this._NgaySinh = row["Ngaysinh"].ToString();
            this._DiaChi = row["Diachi"].ToString();
            this._TaiKhoan = row["TaiKhoan"].ToString();
            this._MatKhau = row["Matkhau"].ToString();
            this._LoaiNV = row["IDLoaiNV"].ToString();
            this._DienThoai = row["Dienthoai"].ToString();
            this._TrangThai = (int)row["Trangthai"];
            this._CMND = row["CMND"].ToString();
        }
        public string Hoten
        {
            get { return this._HoTen; }
            set { this._HoTen = value; }
        }
        public string IDNV
        {
            get { return this._IDNV; }
            set { this._IDNV = value; }
        }
        public string GioiTinh
        {
            get { return this._GioiTinh; }
            set { this._GioiTinh = value; }
        }
        public string NgaySinh
        {
            get { return this._NgaySinh; }
            set { this._NgaySinh = value; }
        }
        public string DiaChi
        {
            get { return this._DiaChi; }
            set { this._DiaChi = value; }
        }
        public string TaiKhoan
        {
            get { return this._TaiKhoan; }
            set { this._TaiKhoan = value; }
        }
        public string MatKhau
        {
            get { return this._MatKhau; }
            set { this._MatKhau = value; }
        }
        public int TrangThai
        {
            get { return this._TrangThai; }
            set { this._TrangThai = value; }
        }
        public string LoaiNV
        {
            get { return this._LoaiNV; }
            set { this._LoaiNV = value; }
        }
        public string DienThoai
        {
            get { return this._DienThoai; }
            set { this._DienThoai = value; }
        }
        public string CMND
        {
            get { return this._CMND; }
            set { this._CMND = value; }
        }
    }
}
