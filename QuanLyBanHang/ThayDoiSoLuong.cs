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
    public partial class ThayDoiSoLuong : Form
    {
        private string ten;
        private List<BEL_SANPHAM> _sp;
        private int _SoLuong;
        private int _ViTri;
        public ThayDoiSoLuong()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        public ThayDoiSoLuong(string tensp, List<BEL_SANPHAM> sp)
        {
            InitializeComponent();
            this.ten = tensp;
            this._sp = sp;
            this.CenterToParent();
        }
        public int SoLuong
        {
            get { return this._SoLuong; }
            set { this._SoLuong = value; }
        }
        public int ViTri
        {
            get { return this._ViTri; }
            set { this._ViTri = value; }
        }

        private void cboSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ThayDoiSoLuong_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < this._sp.Count; i++)
            {
                if (this._sp[i].TenSP.Equals(this.ten))
                {
                    labTenSP.Text = this._sp[i].TenSP;
                    labDonGia.Text = this._sp[i].DonGia.ToString("#,##0" + " VNĐ");
                    labThanhTien.Text = this._sp[i].TongTien.ToString("#,##0" + " VNĐ");
                    this.SoLuong = this._sp[i].SoLuong;
                    cboSoLuong.Text = this.SoLuong.ToString();
                    this._ViTri = i;
                    break;
                }
            }
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
        private void cboSoLuong_Leave(object sender, EventArgs e)
        {
            if (cboSoLuong.Text.Length > 1)
            {
                if (IsNumberInt(cboSoLuong.Text) && double.Parse(cboSoLuong.Text) > 1000)
                {
                    cboSoLuong.Text = "1000";
                    cboSoLuong.Focus();
                }
                else if ((IsNumberInt(cboSoLuong.Text) && double.Parse(cboSoLuong.Text) < 1))
                {
                    cboSoLuong.Text = "1";
                }
            }
            else if (cboSoLuong.Text.Length < 1)
            {
                cboSoLuong.Text = "1";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (int.Parse(cboSoLuong.Text) > 0)
            {
                this._SoLuong = int.Parse(cboSoLuong.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
}
