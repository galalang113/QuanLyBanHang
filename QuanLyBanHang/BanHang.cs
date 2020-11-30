using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;


namespace QuanLyBanHang
{
    public partial class form_BANHANG : Form
    {
        public BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
        public form_BANHANG()
        {
            InitializeComponent();
            txtTenKH.Enabled = true;
            this.CenterToScreen();
            cboChonSoLuongSP.Text = "1";
            
        }
        public bool IsNumberInt(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnChuyenPhaiALL_Click(object sender, EventArgs e)
        {
            BAL_SANPHAM sp = new BAL_SANPHAM();
            bool addInBill = false;
            if (lvSanPham.Items.Count > 0)
            {
                if (int.Parse(cboChonSoLuongSP.Text) > 0)
                {
                    foreach (ListViewItem item in lvSanPham.Items)
                    {
                        if (sp.KiemTraTrung(item.SubItems[1].Text, this.listSanPhamDatHang) != -1)
                        {
                            ThemvaoDatHang(sp.KiemTraTrung(item.SubItems[1].Text, listSanPhamDatHang), int.Parse(cboChonSoLuongSP.Text));
                        }
                        else
                        {
                            ThemvaoDatHang(item.SubItems[1].Text, int.Parse(cboChonSoLuongSP.Text));
                            addInBill = true;
                        }

                    }
                    TongTien(this.listSanPhamDatHang);
                    HienThiDatHang(lvBill, this.listSanPhamDatHang);
                    txtThanhTien.Text = ThanhTien(this.listSanPhamDatHang).ToString("#,##0") + " VNĐ";
                    if (addInBill == true)
                    {
                        MessageBox.Show("Đã thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Đã thêm hết sản phẩm!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (this.listSanPhamDatHang.Count < 1)
            {
                MessageBox.Show("Đơn đặt hàng rỗng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn hủy đơn đặt hàng!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.listSanPhamDatHang.Clear();
                    txtTenKH.Text = "";
                    txtThanhTien.Text = "";
                    HienThiDatHang(lvBill, this.listSanPhamDatHang);
                    MessageBox.Show("Hủy thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void form_BANHANG_Load(object sender, EventArgs e)
        {
            labTenNV.Text = this.bel_nv.Hoten;
            this.HienThiLView();
            timer1.Start();
            labLich.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTenKH.Enabled = false;
            txtThanhTien.Enabled = false;
            btnThanhToan.Enabled = false;
        }
        
        private void btnQLLoaiSanPham_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang danhSachKhachHang = new DanhSachKhachHang();
            this.Hide();
            danhSachKhachHang.ShowDialog();
            this.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ThongTin thongTin = new ThongTin();
            thongTin.bel_nv = new BEL_NHANVIEN(this.bel_nv);
            thongTin.ShowDialog();
        }

        private void cboChonSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void cboChonSoLuongSP_Leave(object sender, EventArgs e)
        {
            if (cboChonSoLuongSP.Text.Length > 1)
            {
                if (IsNumberInt(cboChonSoLuongSP.Text) && double.Parse(cboChonSoLuongSP.Text) > 100)
                {
                    cboChonSoLuongSP.Text = "100";
                    cboChonSoLuongSP.Focus();
                }
                else if((IsNumberInt(cboChonSoLuongSP.Text) && double.Parse(cboChonSoLuongSP.Text) < 1))
                {
                    cboChonSoLuongSP.Text = "1";
                }
            }
            else if(cboChonSoLuongSP.Text.Length < 1)
            {
                cboChonSoLuongSP.Text = "1";
            }
        }
        List<BEL_SANPHAM> listSanPham = new List<BEL_SANPHAM>();
        List<BEL_SANPHAM> listSanPhamDatHang = new List<BEL_SANPHAM>();
        List<BEL_SANPHAM> listSanPhamTemp = new List<BEL_SANPHAM>();
        public void HienThiLView()
        {
            BAL_SANPHAM sp = new BAL_SANPHAM();
            listSanPham = sp.HienThiLView(1);
            lvSanPham.Items.Clear();
            int i = 0;
            foreach (BEL_SANPHAM sanpham in listSanPham)
            {
                lvSanPham.Items.Add((i + 1).ToString());
                lvSanPham.Items[i].SubItems.Add(sanpham.TenSP.ToString());
                lvSanPham.Items[i].SubItems.Add(sanpham.DonGia.ToString("#,##0") + " VNĐ");
                i++;
            }
        }
        public void HienThiDatHang(ListView lv, List<BEL_SANPHAM> arr)
        {
            lv.Items.Clear();
            for (int i = 0; i < arr.Count; i++)
            {
                lv.Items.Add((i + 1).ToString());
                lv.Items[i].SubItems.Add(arr[i].TenSP.ToString());
                lv.Items[i].SubItems.Add(arr[i].SoLuong.ToString("#,##0"));
                lv.Items[i].SubItems.Add(arr[i].DonGia.ToString("#,##0") + " VNĐ");
                lv.Items[i].SubItems.Add(arr[i].TongTien.ToString("#,##0") + " VNĐ");
            }
        }
        private void TongTien(List<BEL_SANPHAM> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i].TongTien = arr[i].DonGia * arr[i].SoLuong;
            }
        }
        private int ThanhTien(List<BEL_SANPHAM> arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i].TongTien;
            }
            return sum;
        }
        public void HienThiLView(string timkiem)
        {
            BAL_SANPHAM sp = new BAL_SANPHAM();
            lvSanPham.Items.Clear();
            int i = 0;
            foreach (BEL_SANPHAM sanpham in this.listSanPham)
            {
                if (sanpham.TenSP.ToLower().Contains(timkiem.ToLower()))
                {
                    lvSanPham.Items.Add((i + 1).ToString());
                    lvSanPham.Items[i].SubItems.Add(sanpham.TenSP.ToString());
                    lvSanPham.Items[i].SubItems.Add(sanpham.DonGia.ToString("#,##0") + " VNĐ");
                    listSanPhamTemp.Add(sanpham);
                    i++;
                }
            }
        }
       
        private void txtTKTenSP_TextChanged(object sender, EventArgs e)
        {
            this.HienThiLView(txtTimKiemSP.Text);
        }
        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            BAL_SANPHAM sp = new BAL_SANPHAM();
            bool addInBill = false;
            if (lvSanPham.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvSanPham.SelectedItems)
                {
                    if (sp.KiemTraTrung(item.SubItems[1].Text, listSanPhamDatHang) != -1)
                    {
                        ThemvaoDatHang(sp.KiemTraTrung(item.SubItems[1].Text, listSanPhamDatHang), int.Parse(cboChonSoLuongSP.Text));
                    }
                    else
                    {
                        ThemvaoDatHang(item.SubItems[1].Text, int.Parse(cboChonSoLuongSP.Text));
                        addInBill = true;
                    }
                }
                TongTien(this.listSanPhamDatHang);
                HienThiDatHang(lvBill, this.listSanPhamDatHang);
                txtThanhTien.Text = ThanhTien(this.listSanPhamDatHang).ToString("#,##0") + " VNĐ";
                if (addInBill == true)
                {
                    MessageBox.Show("Đã thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ThemvaoDatHang(string tensp, int soluong)
        {
            for (int i = 0; i < listSanPham.Count; i++)
            {
                if (listSanPham[i].TenSP.ToLower().Equals(tensp.ToLower()))
                {
                    listSanPham[i].SoLuong = soluong;
                    this.listSanPhamDatHang.Add(listSanPham[i]);
                    break;
                }
            }
        }
        private void ThemvaoDatHang(int vitri, int soluong)
        {
            this.listSanPhamDatHang[vitri].SoLuong += soluong;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;
            int giay = DateTime.Now.Second;

            string giayStr = null, phutStr = null, gioStr = null;
            if (giay < 10)
            {
                giayStr = "0" + giay.ToString();
            }
            else
            {
                giayStr = giay.ToString();
            }
            if (phut < 10)
            {
                phutStr = "0" + phut.ToString();
            }
            else
            {
                phutStr = phut.ToString();
            }
            if (gio < 10)
            {
                gioStr = "0" + gio.ToString();
            }
            else
            {
                gioStr = gio.ToString();
            }
            if(int.Parse(giayStr) % 2 == 0)
            {
                labLuuY.ForeColor = Color.Red;
            }
            else
            {
                labLuuY.ForeColor = Color.Black;
            }
            labTime.Text = gioStr + ":" + phutStr + ":" + giayStr;
        }

        private void lvBill_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvBill.SelectedItems)
            {
                ThayDoiSoLuong tdsl = new ThayDoiSoLuong(item.SubItems[1].Text, this.listSanPhamDatHang);
                tdsl.ShowDialog();
                this.listSanPhamDatHang[tdsl.ViTri].SoLuong = tdsl.SoLuong;
                TongTien(this.listSanPhamDatHang);
                HienThiDatHang(lvBill, this.listSanPhamDatHang);
                txtThanhTien.Text = ThanhTien(this.listSanPhamDatHang).ToString("#,##0") + " VNĐ";
                break;
            }
        }

        private void btnXoaChonBill_Click(object sender, EventArgs e)
        {
            if (this.listSanPhamDatHang.Count < 1)
            {
                MessageBox.Show("Đơn đặt hàng rỗng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lvBill.SelectedItems.Count > 0)
                {
                    BEL_SANPHAM sp = new BEL_SANPHAM();
                    foreach (ListViewItem item in lvBill.SelectedItems)
                    {
                        XoaTenTheoDatHang(item.SubItems[1].Text, this.listSanPhamDatHang);
                    }
                    TongTien(this.listSanPhamDatHang);
                    HienThiDatHang(lvBill, this.listSanPhamDatHang);
                    txtThanhTien.Text = ThanhTien(this.listSanPhamDatHang).ToString("#,##0") + " VNĐ";
                    MessageBox.Show("Xóa sản phẩm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm trong đơn đặt hàng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void XoaTenTheoDatHang(string tensp, List<BEL_SANPHAM> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].TenSP.Equals(tensp))
                {
                    arr.Remove(arr[i]);
                    break;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(this.listSanPhamDatHang.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BEL_HOADON bel_hd = new BEL_HOADON();
                BAL_HOADON bAL_HOADON = new BAL_HOADON();



                bel_hd.IDNV = this.bel_nv.IDNV;
                bel_hd.IDKH = this.bel_kh.IDKH;
                bel_hd.NGAYLAP = DateTime.Now.ToShortDateString();
                bel_hd.GIOLAP = labTime.Text;
                bel_hd.TONGTIEN = ThanhTien(this.listSanPhamDatHang);


                bAL_HOADON.ThemHD(bel_hd);
                bel_hd.IDHD = bAL_HOADON.LayIDHD().ToString();
                for (int i = 0; i < this.listSanPhamDatHang.Count; i++)
                {
                    BEL_CHITIETHOADON bel_cthd = new BEL_CHITIETHOADON(this.listSanPhamDatHang[i]);
                    bel_cthd.IDHD = bel_hd.IDHD;
                    bAL_HOADON.ThemChiTietHoaDon(bel_cthd);
                }

                //---
                this.listSanPhamDatHang.Clear();
                txtTenKH.Text = "";
                txtThanhTien.Text = "";
                HienThiDatHang(lvBill, this.listSanPhamDatHang);
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Length > 0)
            {
                btnThanhToan.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
            }
        }
        private BEL_KHACHHANG bel_kh = new BEL_KHACHHANG();
        private void btnTenKH_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang danhSachKhachHang = new DanhSachKhachHang();
            this.Hide();
            danhSachKhachHang.ShowDialog();
            if (danhSachKhachHang.bel_kh.HoTen != null)
            {
                this.bel_kh = new BEL_KHACHHANG(danhSachKhachHang.bel_kh);
                txtTenKH.Text = this.bel_kh.HoTen;
            }
            this.Show();
        }
    }
}
