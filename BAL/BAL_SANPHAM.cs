using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;


namespace BAL
{
    public class BAL_SANPHAM
    {
        DAL_SANPHAM dal_sp = new DAL_SANPHAM();


        public List<BEL_SANPHAM> HienThiLView(int Trangthai)
        {
            
            return this.dal_sp.HienThiLView(Trangthai);
        }
        public int KiemTraTrung(string tensp, List<BEL_SANPHAM> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].TenSP.ToLower().Equals(tensp.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ThemSanPham(BEL_SANPHAM bel_sp)
        {
            return dal_sp.ThemSanPham(bel_sp);
        }
        public bool CapNhatSanPham(BEL_SANPHAM bel_sp)
        {
            return dal_sp.CapNhatSanPham(bel_sp);
        }
        public List<BEL_SANPHAM > DuLieuSanPham()
        {
            return dal_sp.DuLieuSanPham();
        }
    }
}
