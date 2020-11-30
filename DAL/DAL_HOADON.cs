using BEL;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<BEL_HOADON > DuLieuHoaDon()
        {
            List<BEL_HOADON> listHoaDon = new List<BEL_HOADON>();
            DataTable dt = new DataTable();
            string truyvan = "select IDHD,IDNV,IDKH,CONVERT(varchar, Ngaylap, 103) as Ngaylap,GioLap,CAST(TongTien as int) as TongTien from HOADON";
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_HOADON nhanvien = new BEL_HOADON(item);
                listHoaDon.Add(nhanvien);
            }
            return listHoaDon;
        }
        public List<BEL_CHITIETHOADON> DuLieuCTHoaDon()
        {
            List<BEL_CHITIETHOADON> listCTHoaDon = new List<BEL_CHITIETHOADON>();
            DataTable dt = new DataTable();
            string truyvan = "select IDHD,IDSP,Soluong,CAST(ThanhTien as int) as ThanhTien from CHITIETHOADON";
            dt = this.Read(truyvan);
            foreach (DataRow item in dt.Rows)
            {
                BEL_CHITIETHOADON cthd = new BEL_CHITIETHOADON(item);
                listCTHoaDon.Add(cthd);
            }
            return listCTHoaDon;
        }
    }
}
