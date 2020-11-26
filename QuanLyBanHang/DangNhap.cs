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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            form_BANHANG bg = new form_BANHANG();
            this.Hide();
            bg.ShowDialog();
            this.Show();

            //Admin admin = new Admin();
            //this.Hide();
            //admin.ShowDialog();
            //this.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
