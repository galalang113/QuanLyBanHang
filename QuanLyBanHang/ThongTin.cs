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
    public partial class ThongTin : Form
    {
        public BEL_NHANVIEN bel_nv = new BEL_NHANVIEN();
        public ThongTin()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            labHoTen.Text = this.bel_nv.Hoten;
            labGioiTinh.Text = this.bel_nv.GioiTinh;
            labSDT.Text = this.bel_nv.DienThoai;
            labDiaChi.Text = this.bel_nv.DiaChi;
        }
    }
}
