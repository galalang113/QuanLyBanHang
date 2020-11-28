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
    public partial class DanhSachKhachHang : Form
    {
        private bool flag = true;
        public BEL_KHACHHANG bel_kh = new BEL_KHACHHANG();
        List<BEL_KHACHHANG> listKhachHang = new List<BEL_KHACHHANG>();
        public DanhSachKhachHang()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
            timer1.Start();
            HienThiLView();
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
            if (this.flag)
            {
                if (int.Parse(giayStr) % 2 == 0)
                {
                    labLuuY.ForeColor = Color.Red;
                }
                else
                {
                    labLuuY.ForeColor = Color.Black;
                }
            }
        }

        private void labLuuY_TextChanged(object sender, EventArgs e)
        {
            this.flag = false;
            labLuuY.ForeColor = Color.White;
            labLuuY.BackColor = Color.FromArgb(128, 64, 0);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Equals("") || txtSDT.Text.Length != 10 || txtSDT.Text.Equals(""))
            {
                if (txtTenKH.Text.Equals(""))
                {
                    txtTenKH.Focus();
                    MessageBox.Show("Vui lòng nhập họ tên! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSDT.Text.Equals(""))
                {
                    txtSDT.Focus();
                    MessageBox.Show("Vui lòng nhập SĐT! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSDT.Text.Length != 10)
                {
                    txtSDT.Focus();
                    MessageBox.Show("Vui lòng nhập SĐT là 10 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                BAL_KHACHHANG bAL_KHACHHANG = new BAL_KHACHHANG();
                bel_kh = new BEL_KHACHHANG();
                bel_kh.HoTen = txtTenKH.Text.ToString();
                bel_kh.DienThoai = txtSDT.Text;
                if(radNam.Checked == true)
                {
                    bel_kh.GioiTinh = "Nam";
                }
                else
                {
                    bel_kh.GioiTinh = "Nữ";
                }
                if (bAL_KHACHHANG.KiemTraTrungKH(this.bel_kh))
                {
                    MessageBox.Show("Khách hàng đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bAL_KHACHHANG.ThemKhachHang(this.bel_kh))
                    {
                        string temp = this.bel_kh.DienThoai;
                        HienThiLView();
                        this.bel_kh = new BEL_KHACHHANG(bAL_KHACHHANG.ThongTinKH(temp));
                        labLuuY.Text = "Khách hàng:  " + bel_kh.HoTen + " - " + bel_kh.DienThoai.Substring(bel_kh.DienThoai.Length - 4, 4);
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void lvKhachHang_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvKhachHang.SelectedItems)
                {
                    this.bel_kh = new BEL_KHACHHANG(this.listKhachHang[KiemTraTrung(item.SubItems[1].Text, this.listKhachHang)]);
                    labLuuY.Text = "Khách hàng:  "+ bel_kh.HoTen +" - " + bel_kh.DienThoai.Substring(bel_kh.DienThoai.Length - 4,4);
                    break;
                }
            }
        }
        public int KiemTraTrung(string tenkh, List<BEL_KHACHHANG> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].HoTen.ToLower().Equals(tenkh.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }
        public void HienThiLView()
        {
            BAL_KHACHHANG kh = new BAL_KHACHHANG();
            listKhachHang = kh.HienThiLView(1);
            lvKhachHang.Items.Clear();
            int i = 0;
            foreach (BEL_KHACHHANG khachhang in listKhachHang)
            {
                lvKhachHang.Items.Add((i + 1).ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.HoTen.ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.DienThoai.ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.GioiTinh.ToString());
                i++;
            }
        }
        public void HienThiLView(string timkiem)
        {
            lvKhachHang.Items.Clear();
            int i = 0;
            foreach (BEL_KHACHHANG khachhang in listKhachHang)
            {
                if (khachhang.DienThoai.ToLower().Contains(timkiem.ToLower()))
                {
                    lvKhachHang.Items.Add((i + 1).ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.HoTen.ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.DienThoai.ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.GioiTinh.ToString());
                    i++;
                }
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            HienThiLView(txtTimKiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtTimKiem.Text = "";
            radNam.Checked = true;
        }

        private void txtHoTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {

        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
