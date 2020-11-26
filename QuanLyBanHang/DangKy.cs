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
    public partial class DangKy : Form
    {
        private BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();
        public DangKy()
        {
            InitializeComponent();
            this.CenterToScreen();
            radNam.Checked = true;
            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLai.UseSystemPasswordChar = true;
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Equals("") || txtMatKhau.Text.Equals("") || txtNhapLai.Text.Equals("") || txtCMND.Text.Equals("") || txtCMND.Text.Length > 12 || txtSDT.Text.Length != 10 || txtDiachi.Text.Equals("") || txtSDT.Text.Equals(""))
            {
                if (txtTaiKhoan.Text.Equals(""))
                {
                    txtTaiKhoan.Focus();
                    MessageBox.Show("Vui lòng nhập Tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtMatKhau.Text.Equals(""))
                {
                    txtMatKhau.Focus();
                    MessageBox.Show("Vui lòng nhập Mật Khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtNhapLai.Text.Equals(""))
                {
                    txtNhapLai.Focus();
                    MessageBox.Show("Vui lòng nhập lại Mật Khẩu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtHoTen.Text.Equals(""))
                {
                    txtHoTen.Focus();
                    MessageBox.Show("Vui lòng nhập họ tên! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSDT.Text.Equals(""))
                {
                    txtSDT.Focus();
                    MessageBox.Show("Vui lòng nhập SĐT! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtCMND.Text.Equals(""))
                {
                    txtCMND.Focus();
                    MessageBox.Show("Vui lòng nhập CMND/CCCD ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtDiachi.Text.Equals(""))
                {
                    txtDiachi.Focus();
                    MessageBox.Show("Vui lòng nhập địa chỉ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtCMND.Text.Length > 12)
                {
                    txtCMND.Focus();
                    MessageBox.Show("Vui lòng nhập CMND <= 12 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSDT.Text.Length != 10)
                {
                    txtSDT.Focus();
                    MessageBox.Show("Vui lòng nhập SĐT là 10 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 
            }
            else 
            {
                
                BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
                bel_nv.Hoten = txtHoTen.Text;
                bel_nv.DienThoai = txtSDT.Text;
                bel_nv.NgaySinh = dtNgaySinh.Value.ToShortDateString();
                bel_nv.CMND = txtCMND.Text;
                bel_nv.TrangThai = 0;
                bel_nv.TaiKhoan = txtTaiKhoan.Text;
                bel_nv.MatKhau = txtMatKhau.Text;
                bel_nv.LoaiNV = "1";
                if (radNam.Checked == true)
                {
                    bel_nv.GioiTinh = "Nam";
                }
                else
                {
                    bel_nv.GioiTinh = "Nữ";
                }
                bel_nv.DiaChi = txtDiachi.Text;

                if (bal_nv.KiemTraTrungTK(bel_nv))
                {
                    MessageBox.Show("Nhân viên đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bal_nv.ThemTaiKhoan(bel_nv))
                    {
                        MessageBox.Show("Đăng ký thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNhapLai_Leave(object sender, EventArgs e)
        {
            if (txtNhapLai.Text.Length > 0)
            {
                if (txtNhapLai.Text.Equals(txtMatKhau.Text) == false)
                {
                    txtNhapLai.Focus();
                    MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if(txtMatKhau.Text.Length < 6 || txtMatKhau.Text.Length > 16)
            {
                txtMatKhau.Focus();
                MessageBox.Show("Vui lòng nhập Mật Khẩu >=6 && <= 16 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng nhập SĐT là 10 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if (txtCMND.Text.Length != 9 && txtCMND.Text.Length != 12)
            {
                txtCMND.Focus();
                MessageBox.Show("Vui lòng nhập CMND 9 hoặc 12 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals("") || txtTaiKhoan.Text.Length < 3)
            {
                txtTaiKhoan.Focus();
                MessageBox.Show("Vui lòng nhập Tài khoản lớn hơn 3 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(txtTaiKhoan.Text.Length > 16)
            {
                txtTaiKhoan.Focus();
                MessageBox.Show("Vui lòng nhập Tài khoản >=3 && <=16 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Equals(""))
            {
                txtHoTen.Focus();
                MessageBox.Show("Vui lòng nhập họ tên! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtHoTen.Text.Length > 16)
            {
                txtTaiKhoan.Focus();
                MessageBox.Show("Vui lòng nhập họ tên >=1 && <=16 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text.Equals(""))
            {
                txtDiachi.Focus();
                MessageBox.Show("Vui lòng nhập địa chỉ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
