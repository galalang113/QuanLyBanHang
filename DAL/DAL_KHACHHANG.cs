using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class DAL_KHACHHANG : General
    {
        public List<BEL_KHACHHANG> HienThiLView(int trangthai)
        {
            List<BEL_KHACHHANG> listKhachHang = new List<BEL_KHACHHANG>();
            DataTable dt = new DataTable();
            string truyvan = "select IDKH, Hoten,Dienthoai,Gioitinh,Trangthai  from KHACHHANG where Trangthai =" + trangthai;
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_KHACHHANG khachhang = new BEL_KHACHHANG(item);
                listKhachHang.Add(khachhang);
            }
            return listKhachHang;
        }
        public bool ThemKhachHang(BEL_KHACHHANG bEL_KHACHHANG)
        {
            string truyvan = "insert into KHACHHANG(Hoten,Dienthoai,Gioitinh,Trangthai) values (N'"+bEL_KHACHHANG.HoTen+"','"+ bEL_KHACHHANG.DienThoai + "',N'"+ bEL_KHACHHANG.GioiTinh + "',1)";
            return this.Change(truyvan);
        }
        public bool KiemTraTrungKH(BEL_KHACHHANG bEL_KHACHHANG)
        {
            DataTable dt = new DataTable();
            string truyvan = "select IDKH, Hoten,Dienthoai,Gioitinh,Trangthai  from KHACHHANG where Dienthoai = " + bEL_KHACHHANG.DienThoai;
            dt = this.Read(truyvan);

            if (dt.Rows.Count < 1)
            {
                return false;
            }
            return true;
        }
        public BEL_KHACHHANG ThongTinKH(string sdt)
        {
            string truyvan = "select IDKH, Hoten,Dienthoai,Gioitinh,Trangthai  from KHACHHANG where Dienthoai = "+sdt+" and  Trangthai = 1";
            BEL_KHACHHANG bEL_KHACHHANG = new BEL_KHACHHANG(this.Read(truyvan).Rows[0]);

            return bEL_KHACHHANG;
        }
    }
}
