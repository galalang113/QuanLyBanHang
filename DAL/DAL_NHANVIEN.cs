using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;


namespace DAL
{
    public class DAL_NHANVIEN : General
    {
        public bool KiemTraTaiKhoan(BEL_NHANVIEN bel_nv)
        {
            DataTable dt = new DataTable();
            string truyvan = "select * from NHANVIEN where NHANVIEN.TaiKhoan = '"+ this.Encrypt(bel_nv.TaiKhoan) +"' and NHANVIEN.MatKhau = '" + this.Encrypt(bel_nv.MatKhau) +"'";
            dt = this.Read(truyvan);

            if (dt.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }
        public string LayIDNV(BEL_NHANVIEN bel_nv)
        {
            DataTable dt = new DataTable();
            string truyvan = "select * from NHANVIEN where NHANVIEN.TaiKhoan = '" + this.Encrypt(bel_nv.TaiKhoan) + "' and NHANVIEN.MatKhau = '" + this.Encrypt(bel_nv.MatKhau) + "'";
            dt = this.Read(truyvan);

            if (dt.Rows.Count < 1)
            {
                return null;
            }
            return dt.Rows[0]["IDNV"].ToString();
        }
        public BEL_NHANVIEN ThongTinTaiKhoan(string id)
        {
            DataTable dt = new DataTable();
            string truyvan = "select * from NHANVIEN where IDNV ='" + id + "'";
            dt = this.Read(truyvan);
            BEL_NHANVIEN nv = new BEL_NHANVIEN(dt.Rows[0]);
            //nv.IDNV = dt.Rows[0]["IDNV"].ToString();
            //nv.Hoten = dt.Rows[0]["Hoten"].ToString();
            //nv.LoaiNV = dt.Rows[0]["IDLoaiNV"].ToString();
            //nv.DienThoai = dt.Rows[0]["Dienthoai"].ToString();
            //nv.GioiTinh = dt.Rows[0]["Gioitinh"].ToString();
            //nv.NgaySinh = dt.Rows[0]["Ngaysinh"].ToString();
            //nv.TrangThai = int.Parse(dt.Rows[0]["Trangthai"].ToString());
            //nv.DiaChi = dt.Rows[0]["Diachi"].ToString();
            //nv.CMND = dt.Rows[0]["CMND"].ToString();
            return nv;
        }
        public bool ThemTaiKhoan(BEL_NHANVIEN nv)
        {
            string maHoaTK = this.Encrypt(nv.TaiKhoan);
            string maHoaMK = this.Encrypt(nv.MatKhau);
            string truyvan = "Insert into NHANVIEN (Hoten,IDLoaiNV,Dienthoai,Gioitinh,Ngaysinh,CMND,TaiKhoan,MatKhau,Diachi,Trangthai) values (N'" + nv.Hoten + "','" + nv.LoaiNV + "','" + nv.DienThoai + "',N'" + nv.GioiTinh + "','" + nv.NgaySinh + "','" + nv.CMND + "','" + maHoaTK + "','" + maHoaMK + "',N'" + nv.DiaChi + "'," + nv.TrangThai + ")";
            return this.Change(truyvan);
        
        }
        public bool KiemTraTrungTaiKhoan(BEL_NHANVIEN nv)
        {
            DataTable dt = new DataTable();
            string truyvan = "select IDNV from NHANVIEN where NHANVIEN.CMND = '" + nv.CMND + "'";
            dt = this.Read(truyvan);

            if (dt.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }
    }
}
