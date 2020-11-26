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
            this.CenterToScreen();
        }


        private void btnChuyenPhaiALL_Click(object sender, EventArgs e)
        {

        }

        private void btnSangPhai_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void form_BANHANG_Load(object sender, EventArgs e)
        {

        }

        private void btnQLLoaiSanPham_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang danhSachKhachHang = new DanhSachKhachHang();
            this.Hide();
            danhSachKhachHang.ShowDialog();
            this.Show();
        }
    }
}
