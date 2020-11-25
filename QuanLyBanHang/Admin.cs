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
    public partial class Admin : Form
    {
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
    }
}
