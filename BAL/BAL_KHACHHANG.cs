using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BAL
{
    public class BAL_KHACHHANG
    {
        private DAL_KHACHHANG dal_kh = new DAL_KHACHHANG();
        public List<BEL_KHACHHANG> HienThiLView(int Trangthai)
        {
            return this.dal_kh.HienThiLView(Trangthai);
        }
        public bool ThemKhachHang(BEL_KHACHHANG bEL_KHACHHANG)
        {
            return dal_kh.ThemKhachHang(bEL_KHACHHANG);
        }
        public bool KiemTraTrungKH(BEL_KHACHHANG bEL_KHACHHANG)
        {
            return dal_kh.KiemTraTrungKH(bEL_KHACHHANG);
        }
        public BEL_KHACHHANG ThongTinKH(string sdt)
        {
            return dal_kh.ThongTinKH(sdt);
        }
    }
}
