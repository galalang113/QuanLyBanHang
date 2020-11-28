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
    public partial class DangNhap : Form
    {
        private BAL_NHANVIEN bal_nv = new BAL_NHANVIEN();
        public DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtMatKhau.UseSystemPasswordChar = true;
            txtTaiKhoan.Text = "nv1";
            txtMatKhau.Text = "123123";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {


            if (txtTaiKhoan.Text.Equals("") || txtMatKhau.Text.Equals(""))
            {
                if (txtTaiKhoan.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaiKhoan.Focus();
                }
                else if (txtMatKhau.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                if ( (txtTaiKhoan.Text.Length < 3 || txtTaiKhoan.Text.Length > 16) || (txtMatKhau.Text.Length < 6 || txtMatKhau.Text.Length > 16))
                {
                    if ((txtTaiKhoan.Text.Length < 3 || txtTaiKhoan.Text.Length > 16))
                    {
                        MessageBox.Show("Vui lòng nhập tài khoản >= 3 và < 16 kí tự?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaiKhoan.Focus();
                    }
                    else if ((txtMatKhau.Text.Length < 6 || txtMatKhau.Text.Length > 16))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu >= 6 và < 16 kí tự?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    BEL_NHANVIEN bEL_NHANVIEN = new BEL_NHANVIEN();
                    bEL_NHANVIEN.TaiKhoan = txtTaiKhoan.Text;
                    bEL_NHANVIEN.MatKhau = txtMatKhau.Text;

                    if (bal_nv.KiemTraTaiKhoan(bEL_NHANVIEN))
                    {
                        BEL_NHANVIEN bel_nv = new BEL_NHANVIEN(bal_nv.ThongTinTaiKhoan(bal_nv.LayIDNV(bEL_NHANVIEN)));

                        form_BANHANG bg = new form_BANHANG();
                        bg.bel_nv = new BEL_NHANVIEN(bel_nv);
                        if (bel_nv.LoaiNV.Equals("1"))
                        {
                            this.Hide();
                            bg.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            Admin admin = new Admin();
                            this.Hide();
                            admin.ShowDialog();
                            this.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }



            



            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHienMatKhau_Click(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.ShowDialog();
            this.Show();
        }
    }
}
