using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BAL_HOADON
    {
        private DAL_HOADON dal_hd = new DAL_HOADON();
        public bool ThemHD(BEL_HOADON hd)
        {
            return dal_hd.ThemHD(hd);
        }
        public int LayIDHD()
        {
            return dal_hd.LayIDHD();
        }
        public bool ThemChiTietHoaDon(BEL_CHITIETHOADON cthd)
        {
            return dal_hd.ThemChiTietHoaDon(cthd);
        }
        public List<BEL_HOADON> DuLieuHoaDon()
        {
            return dal_hd.DuLieuHoaDon();
        }
        public List<BEL_CHITIETHOADON> DuLieuCTHoaDon()
        {
            return dal_hd.DuLieuCTHoaDon();
        }
    }
}
