using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace QuanLyBanHang
{
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        List<BEL_NHANVIEN> listNhanVien = new List<BEL_NHANVIEN>();
        List<BEL_HOADON> listHoaDon = new List<BEL_HOADON>();
        List<BEL_CHITIETHOADON> listCTHoaDon = new List<BEL_CHITIETHOADON>();
        List<BEL_KHACHHANG> listKhachHang = new List<BEL_KHACHHANG>();
        List<BEL_SANPHAM> listSanPham = new List<BEL_SANPHAM>();
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            DuLieuNhanVien();
            DuLieukhachHang();
            DuLieuSanPham();
            DuLieuHoaDon();
            DuLieuCTHD();
            HienThiLViewHoaDon();
        }
        private void DuLieuNhanVien()
        {
            BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();
            listNhanVien = bal_nv.DuLieuNhanVien();
        }
        private void DuLieuSanPham()
        {
            BAL_SANPHAM bal_sp = new BAL_SANPHAM();
            this.listSanPham = bal_sp.DuLieuSanPham();
        }
        private void DuLieuHoaDon()
        {
            BAL_HOADON bal_hd = new BAL_HOADON();
            this.listHoaDon = bal_hd.DuLieuHoaDon();
        }
        private void DuLieuCTHD()
        {
            BAL_HOADON bal_hd = new BAL_HOADON();
            this.listCTHoaDon = bal_hd.DuLieuCTHoaDon();
        }
        private void DuLieukhachHang()
        {
            BAL_KHACHHANG bal_kh = new BAL_KHACHHANG();
            this.listKhachHang =  bal_kh.DuLieuKhachHang();
        }
        private void HienThiLViewHoaDon()
        {
            BAL_HOADON hd = new BAL_HOADON();
            lvHoaDon.Items.Clear();
            int i = 0;
            foreach (BEL_HOADON hoadon in this.listHoaDon)
            {
                lvHoaDon.Items.Add((i + 1).ToString());
                lvHoaDon.Items[i].SubItems.Add(hoadon.IDHD.ToString());
                lvHoaDon.Items[i].SubItems.Add(LayTenNhanVien(hoadon.IDNV.ToString()));
                lvHoaDon.Items[i].SubItems.Add(LayTenKhachHang(hoadon.IDKH.ToString()));
                lvHoaDon.Items[i].SubItems.Add(hoadon.NGAYLAP.ToString());
                lvHoaDon.Items[i].SubItems.Add(hoadon.GIOLAP.ToString());
                lvHoaDon.Items[i].SubItems.Add(hoadon.TONGTIEN.ToString());
                i++;
            }
        }
        private string LayTenNhanVien(string id)
        {
            foreach(BEL_NHANVIEN values in this.listNhanVien)
            {
                if (values.IDNV.Equals(id))
                {
                    return values.Hoten;
                }
            }
            return null;
        }
        private string LayTenKhachHang(string id)
        {
            foreach (BEL_KHACHHANG values in this.listKhachHang)
            {
                if (values.IDKH.Equals(id))
                {
                    return values.HoTen;
                }
            }
            return null;
        }
        private string ghichu = "Thông tin chi tiết của hóa đơn: ";
        private void HienThiLViewChiTietHoaDon(string idhd)
        {
            labIDHD.Text = ghichu + idhd;
            BAL_HOADON hd = new BAL_HOADON();
            lvChiTietHoaDon.Items.Clear();
            int i = 0;
            foreach (BEL_CHITIETHOADON chitiethoadon in this.listCTHoaDon)
            {
                if (chitiethoadon.IDHD.Equals(idhd))
                {
                    lvChiTietHoaDon.Items.Add((i + 1).ToString());
                    lvChiTietHoaDon.Items[i].SubItems.Add(TenSanPham(chitiethoadon.IDSP.ToString()));
                    lvChiTietHoaDon.Items[i].SubItems.Add(DonGiaSanPham(chitiethoadon.IDSP.ToString()));
                    lvChiTietHoaDon.Items[i].SubItems.Add(chitiethoadon.SOLUONG.ToString());
                    lvChiTietHoaDon.Items[i].SubItems.Add(chitiethoadon.ThanhTien.ToString());
                    i++;
                }
                
            }
        }
        private string TenSanPham(string id)
        {
            foreach (BEL_SANPHAM values in this.listSanPham)
            {
                if (values.IDSP.Equals(id))
                {
                    return values.TenSP;
                }
            }
            return null;
        }
        private string DonGiaSanPham(string id)
        {
            foreach (BEL_SANPHAM values in this.listSanPham)
            {
                if (values.IDSP.Equals(id))
                {
                    return values.DonGia.ToString();
                }
            }
            return null;
        }
        private void lvHoaDon_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in lvHoaDon.SelectedItems)
                {
                    HienThiLViewChiTietHoaDon(item.SubItems[1].Text.ToString());
                    break;
                }
            }
        }
    }
}
