using BAL;
using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
        List<BEL_NHANVIEN> listNhanVien = new List<BEL_NHANVIEN>();
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            radNam.Checked = true;
            radNhanVien.Checked = true;
            radMoKhoa.Checked = true;
            HienThiThongTinNhanVien(lvNhanVien);


        }
        public void HienThiThongTinNhanVien(ListView lv)
        {
            lv.Items.Clear();
            BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();
            listNhanVien = bal_nv.DuLieuNhanVien();
            int i = 0;
            foreach (BEL_NHANVIEN nhanvien in this.listNhanVien)
            {
                lv.Items.Add((i + 1).ToString());
                lv.Items[i].SubItems.Add(nhanvien.IDNV.ToString());
                lv.Items[i].SubItems.Add(nhanvien.Hoten.ToString());
                lv.Items[i].SubItems.Add(nhanvien.DienThoai.ToString());
                lv.Items[i].SubItems.Add(nhanvien.NgaySinh.ToString());
                lv.Items[i].SubItems.Add(nhanvien.CMND.ToString());
                lv.Items[i].SubItems.Add(nhanvien.GioiTinh.ToString());
                if (nhanvien.LoaiNV.Equals("1"))
                {
                    lv.Items[i].SubItems.Add("Nhân viên");
                }
                else
                {
                    lv.Items[i].SubItems.Add("Quản lý");
                }
                if (nhanvien.TrangThai == 1)
                {
                    lv.Items[i].SubItems.Add("Mở khóa");
                }
                else
                {
                    lv.Items[i].SubItems.Add("Đã khóa");
                }
                lv.Items[i].SubItems.Add(nhanvien.DiaChi.ToString());
                i++;
            }
        }
        private int Age(DateTime dateTime)
        {
            string today = dateTime.ToShortDateString();
            DateTime birthday = DateTime.Parse(today, System.Globalization.CultureInfo.InvariantCulture);
            int age = (Int32.Parse(DateTime.Today.ToString("yyyyMMdd")) - Int32.Parse(birthday.ToString("yyyyMMdd"))) / 10000;
            return age;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text.Equals(""))
            {
                txtHoTenNV.Focus();
                MessageBox.Show("Vui lòng nhập họ tên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (txtSDT.Text.Equals(""))
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng nhập SĐT ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSDT.Text.Length != 10)
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng nhập SĐT là 10 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtCMND.Text.Equals(""))
            {
                txtCMND.Focus();
                MessageBox.Show("Vui lòng nhập CMND/CCCD ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtCMND.Text.Length != 9 && txtCMND.Text.Length != 12)
            {
                txtCMND.Focus();
                MessageBox.Show("Vui lòng nhập CMND 9 hoặc 12 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Age(dtNgaySinh.Value) < 18)
            {
                dtNgaySinh.Focus();
                MessageBox.Show("Ngày sinh >= 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDiachiNV.Text.Equals(""))
            {
                txtDiachiNV.Focus();
                MessageBox.Show("Vui lòng nhập địa chỉ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();

                BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();


                bel_nv.Hoten = txtHoTenNV.Text;
                bel_nv.DienThoai = txtSDT.Text;
                bel_nv.NgaySinh = dtNgaySinh.Value.ToShortDateString();
                bel_nv.CMND = txtCMND.Text;
                if (radNam.Checked == true)
                {
                    bel_nv.GioiTinh = "Nam";
                }
                else
                {
                    bel_nv.GioiTinh = "Nữ";
                }
                if (radQuanLy.Checked == true)
                {
                    bel_nv.LoaiNV = "2";
                }
                else
                {
                    bel_nv.LoaiNV = "1";
                }
                if (radMoKhoa.Checked == true)
                {
                    bel_nv.TrangThai = 1;
                }
                else
                {
                    bel_nv.TrangThai = 0;
                }
                bel_nv.DiaChi = txtDiachiNV.Text;
                bel_nv.TaiKhoan = txtSDT.Text;
                bel_nv.MatKhau = labMKMatDinh.Text;
                if (bal_nv.KiemTraTrungNhanVien(bel_nv))
                {
                    MessageBox.Show("Nhân viên đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bal_nv.ThemTaiKhoan(bel_nv))
                    {
                        HienThiThongTinNhanVien(lvNhanVien);
                        MessageBox.Show("Thêm nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtDiachiNV.Text = "";
            radNam.Checked = true;
            radNhanVien.Checked = true;
            radMoKhoa.Checked = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKhoiPhucMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();
                BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
                bel_nv.IDNV = txtMaNV.Text;
                bel_nv.MatKhau = labMKMatDinh.Text;
                if (bal_nv.KhoiPhucMatKhauNhanVien(bel_nv))
                {
                    MessageBox.Show("Khôi phục mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Khôi phục mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radKhoa.Checked == true && this.bel_nv.IDNV.Equals(txtMaNV.Text))
                {
                    MessageBox.Show("Không thể thực hiện với chính bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radMoKhoa.Checked = true;
                }
                else
                {
                    BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
                    BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();
                    BEL_NHANVIEN bel_nv_temp = new BEL_NHANVIEN();
                    bel_nv_temp = new BEL_NHANVIEN(bal_nv.ThongTinTaiKhoan(txtMaNV.Text));
                    bel_nv.IDNV = txtMaNV.Text;
                    bel_nv.Hoten = txtHoTenNV.Text;
                    bel_nv.DienThoai = txtSDT.Text;
                    bel_nv.NgaySinh = dtNgaySinh.Value.ToShortDateString();
                    bel_nv.CMND = txtCMND.Text;
                    bel_nv.TaiKhoan = bel_nv_temp.TaiKhoan;
                    bel_nv.MatKhau = bel_nv_temp.MatKhau;
                    if (radNam.Checked == true)
                    {
                        bel_nv.GioiTinh = "Nam";
                    }
                    else
                    {
                        bel_nv.GioiTinh = "Nữ";
                    }
                    if (radQuanLy.Checked == true)
                    {
                        bel_nv.LoaiNV = "2";
                    }
                    else
                    {
                        bel_nv.LoaiNV = "1";
                    }
                    if (radMoKhoa.Checked == true)
                    {
                        bel_nv.TrangThai = 1;
                    }
                    else
                    {
                        bel_nv.TrangThai = 0;
                    }
                    bel_nv.DiaChi = txtDiachiNV.Text;


                    if (bal_nv.CapNhatNhanVien(bel_nv))
                    {
                        HienThiThongTinNhanVien(lvNhanVien);
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }    
        }

        private void lvNhanVien_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvNhanVien.SelectedItems[0];

            txtMaNV.Text = item.SubItems[1].Text;
            txtHoTenNV.Text = item.SubItems[2].Text;
            txtSDT.Text = item.SubItems[3].Text;
            string ngay, thang, nam;
            ngay = item.SubItems[4].Text.Substring(0, 2);
            thang = item.SubItems[4].Text.Substring(3, 2);
            nam = item.SubItems[4].Text.Substring(6, item.SubItems[4].Text.Length - 6);
            dtNgaySinh.Text = thang + "/" + ngay + "/" + nam;
            txtCMND.Text = item.SubItems[5].Text;
            if (item.SubItems[6].Text.Equals("Nam"))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            if (item.SubItems[7].Text.Equals("Quản lý"))
            {
                radQuanLy.Checked = true;
            }
            else
            {
                radNhanVien.Checked = true;
            }
            if (item.SubItems[8].Text.Equals("Mở khóa"))
            {
                radMoKhoa.Checked = true;
            }
            else
            {
                radKhoa.Checked = true;
            }
            txtDiachiNV.Text = item.SubItems[9].Text;
        }
    }
}
