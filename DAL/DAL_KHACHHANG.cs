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
        public List<BEL_KHACHHANG> DuLieuKhachHang()
        {
            List<BEL_KHACHHANG> listKhachHang = new List<BEL_KHACHHANG>();
            DataTable dt = new DataTable();
            string truyvan = "select IDKH, Hoten,Dienthoai,Gioitinh,Trangthai  from KHACHHANG ";
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
            string truyvan = "insert into KHACHHANG(Hoten,Dienthoai,Gioitinh,Trangthai) values (N'"+bEL_KHACHHANG.HoTen+"','"+ bEL_KHACHHANG.DienThoai + "',N'"+ bEL_KHACHHANG.GioiTinh + "',"+bEL_KHACHHANG.Trangthai+")";
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
        public string KiemTraTrungKHID(string sdt)
        {
            string truyvan = "select IDKH, Hoten,Dienthoai,Gioitinh,Trangthai  from KHACHHANG where Dienthoai = " + sdt;
            if (this.Read(truyvan).Rows.Count > 0)
            {
                return this.Read(truyvan).Rows[0]["IDKH"].ToString();
            }
            return null;
        }
        public BEL_KHACHHANG ThongTinKH(string sdt)
        {
            string truyvan = "select IDKH, Hoten,Dienthoai,Gioitinh,Trangthai  from KHACHHANG where Dienthoai = "+sdt+" and  Trangthai = 1";
            BEL_KHACHHANG bEL_KHACHHANG = new BEL_KHACHHANG(this.Read(truyvan).Rows[0]);

            return bEL_KHACHHANG;
        }
        public bool CapNhatKH(BEL_KHACHHANG bel_kh)
        {
            string truyvan = "update KHACHHANG set Hoten= N'"+bel_kh.HoTen+"',Dienthoai='"+bel_kh.DienThoai+"',Gioitinh=N'"+bel_kh.GioiTinh+"',Trangthai='"+bel_kh.Trangthai+"' where IDKH='"+bel_kh.IDKH+"'";
            return this.Change(truyvan);
        }
    }
}
