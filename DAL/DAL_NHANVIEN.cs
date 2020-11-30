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
        public bool KiemTraTrungNhanVien(BEL_NHANVIEN bel_nv)
        {
            DataTable dt = new DataTable();
            string truyvan = "select IDNV from NHANVIEN where NHANVIEN.CMND = '" + bel_nv.CMND + "'";
            dt = this.Read(truyvan);

            if (dt.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }
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
            return nv;
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
        public List<BEL_NHANVIEN> DuLieuNhanVien()
        {
            List<BEL_NHANVIEN> listNhanVien = new List<BEL_NHANVIEN>();
            DataTable dt = new DataTable();
            string truyvan = "select IDNV,Hoten,IDLoaiNV,Dienthoai,Gioitinh,CONVERT(varchar, Ngaysinh, 103) as Ngaysinh,CMND,TaiKhoan,MatKhau,Diachi,Trangthai from NHANVIEN ";
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_NHANVIEN nhanvien = new BEL_NHANVIEN(item);
                listNhanVien.Add(nhanvien);
            }
            return listNhanVien;
        }
        public bool ThemTaiKhoan(BEL_NHANVIEN nv)
        {
            string maHoaTK = this.Encrypt(nv.TaiKhoan);
            string maHoaMK = this.Encrypt(nv.MatKhau);
            string truyvan = "Insert into NHANVIEN (Hoten,IDLoaiNV,Dienthoai,Gioitinh,Ngaysinh,CMND,TaiKhoan,MatKhau,Diachi,Trangthai) values (N'" + nv.Hoten + "','" + nv.LoaiNV + "','" + nv.DienThoai + "',N'" + nv.GioiTinh + "','" + nv.NgaySinh + "','" + nv.CMND + "','" + maHoaTK + "','" + maHoaMK + "',N'" + nv.DiaChi + "'," + nv.TrangThai + ")";
            return this.Change(truyvan);

        }
        public bool KhoiPhucMatKhauNhanVien(BEL_NHANVIEN nv)
        {
            string maHoaMK = this.Encrypt(nv.MatKhau);
            string truyvan = "update NHANVIEN set MatKhau='" + maHoaMK + "'  where IDNV='" + nv.IDNV + "'";
            return this.Change(truyvan);
        }
        public bool CapNhatNhanVien(BEL_NHANVIEN nv)
        {
            string truyvan = "update NHANVIEN set Hoten=N'" + nv.Hoten + "',Dienthoai='" + nv.DienThoai + "',Ngaysinh='" + nv.NgaySinh + "',CMND='" + nv.CMND + "',Gioitinh=N'" + nv.GioiTinh + "',IDLoaiNV='" + nv.LoaiNV + "',Trangthai='" + nv.TrangThai + "',Diachi=N'" + nv.DiaChi + "' where IDNV='" + nv.IDNV + "'";
            return this.Change(truyvan);
        }
    }
}
