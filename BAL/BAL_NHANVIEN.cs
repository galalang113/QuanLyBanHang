using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
namespace BAL
{
    public class BAL_NHANVIEN
    {
        private DAL_NHANVIEN dal_nv = new DAL_NHANVIEN();
        public bool KiemTraTaiKhoan(BEL_NHANVIEN bel_nv)
        {
            
            return dal_nv.KiemTraTaiKhoan(bel_nv);
        }
        public bool ThemTaiKhoan(BEL_NHANVIEN bEL_NHANVIEN)
        {
            return dal_nv.ThemTaiKhoan(bEL_NHANVIEN);
        }
        public bool KiemTraTrungTK(BEL_NHANVIEN bEL_NHANVIEN)
        {
            return dal_nv.KiemTraTrungTaiKhoan(bEL_NHANVIEN);
        }
        public bool ThemTK(BEL_NHANVIEN bEL_NHANVIEN)
        {
            return dal_nv.ThemTaiKhoan(bEL_NHANVIEN);
        }
        public string LayIDNV(BEL_NHANVIEN bEL_NHANVIEN)
        {
            return dal_nv.LayIDNV(bEL_NHANVIEN);
        }
        public BEL_NHANVIEN ThongTinTaiKhoan(string id)
        {
            return dal_nv.ThongTinTaiKhoan(id);
        }
    }
}
