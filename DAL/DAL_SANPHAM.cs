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
            string truyvan = "select IDSP,TenSP,CAST(Dongia as int) as DonGia,SANPHAM.Trangthai from SANPHAM where  SANPHAM.Trangthai="+trangthai;
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_SANPHAM sanpham = new BEL_SANPHAM(item);
                listSanPham.Add(sanpham);
            }
            return listSanPham;
        }
    }
}
