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

namespace QuanLyBanHang
{
    public partial class Admin : Form
    {
        public BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
        public Admin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            QuanLySanPham quanLySanPham = new QuanLySanPham();
            this.Hide();
            quanLySanPham.ShowDialog();
            this.Show();
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            this.Hide();
            quanLyTaiKhoan.bel_nv = new BEL_NHANVIEN(bel_nv);
            quanLyTaiKhoan.ShowDialog();
            this.Show();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            this.Hide();
            quanLyKhachHang.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon quanLyHoaDon = new QuanLyHoaDon();
            this.Hide();
            quanLyHoaDon.ShowDialog();
            this.Show();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
