using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
namespace DAL
{
    public class DAL_SANPHAM : General
    {
        public List<BEL_SANPHAM> HienThiLView(int trangthai)
        {
            List<BEL_SANPHAM> listSanPham = new List<BEL_SANPHAM>();
            DataTable dt = new DataTable();
            string truyvan = "select IDSP,TenSP,CAST(Dongia as int) as DonGia,SANPHAM.Trangthai from SANPHAM where  SANPHAM.Trangthai=" + trangthai;
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_SANPHAM sanpham = new BEL_SANPHAM(item);
                listSanPham.Add(sanpham);
            }
            return listSanPham;
        }
        public bool ThemSanPham(BEL_SANPHAM bel_sp)
        {
            string truyvan = "insert into SANPHAM (TenSP,Dongia,Trangthai) values(N'"+bel_sp.TenSP+"',"+bel_sp.DonGia+","+bel_sp.TrangThai+")";
            return this.Change(truyvan);
        }
        public bool CapNhatSanPham(BEL_SANPHAM bel_sp)
        {
            string truyvan = "update SANPHAM set TenSP = N'"+bel_sp.TenSP+"',Dongia = '"+bel_sp.DonGia+"',Trangthai='"+bel_sp.TrangThai+"' where IDSP = '"+bel_sp.IDSP+"'";
            return this.Change(truyvan);
        }
        public List<BEL_SANPHAM> DuLieuSanPham()
        {
            List<BEL_SANPHAM> listSanPham = new List<BEL_SANPHAM>();
            DataTable dt = new DataTable();
            string truyvan = "select IDSP,TenSP,CAST(Dongia as int) as DonGia,SANPHAM.Trangthai from SANPHAM";
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_SANPHAM bel_sp = new BEL_SANPHAM(item);
                listSanPham.Add(bel_sp);
            }
            return listSanPham;
        }
    }
}
