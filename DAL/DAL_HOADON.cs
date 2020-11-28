using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HOADON : General
    {
        public bool ThemHD(BEL_HOADON hd)
        {
            string truyvan = "insert into HOADON(IDNV,IDKH,Ngaylap,GioLap,TongTien) values("+hd.IDNV+","+hd.IDKH+",'"+hd.NGAYLAP+"','"+hd.GIOLAP+"',"+hd.TONGTIEN+")";
            return this.Change(truyvan);
        }
        public bool ThemChiTietHoaDon(BEL_CHITIETHOADON cthd)
        {
            string truyvan = "insert into CHITIETHOADON values(" + cthd.IDHD + "," + cthd.IDSP + "," + cthd.SOLUONG + "," + cthd.ThanhTien + ")";
            return this.Change(truyvan);
        }
        public int LayIDHD()
        {
            string truyvan = "select MAX(IDHD) as IDHD from HOADON";
            return int.Parse(this.Read(truyvan).Rows[0]["IDHD"].ToString());
        }
    }
}
