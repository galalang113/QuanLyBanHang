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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            HienThiLView();
            txtIDSP.Enabled = false;
            radMoKhoa.Checked = true;
        }
        List<BEL_SANPHAM> listSanPham = new List<BEL_SANPHAM>();
        public void HienThiLView()
        {
            BAL_SANPHAM sp = new BAL_SANPHAM();
            //trạng thái = 1
            listSanPham = sp.HienThiLView(1);
            //trạng thái = 0
            List<BEL_SANPHAM> listSanPhamTemp = new List<BEL_SANPHAM>();
            listSanPhamTemp = sp.HienThiLView(0);
            foreach (BEL_SANPHAM value in listSanPhamTemp)
            {
                this.listSanPham.Add(value);
            }

            lvSanPham.Items.Clear();
            int i = 0;
            foreach (BEL_SANPHAM sanpham in listSanPham)
            {
                lvSanPham.Items.Add((i + 1).ToString());
                lvSanPham.Items[i].SubItems.Add(sanpham.IDSP.ToString());
                lvSanPham.Items[i].SubItems.Add(sanpham.TenSP.ToString());
                lvSanPham.Items[i].SubItems.Add(sanpham.DonGia.ToString("#,##0") + " VNĐ");
                if(sanpham.TrangThai == 1)
                {
                    lvSanPham.Items[i].SubItems.Add("Mở khóa");
                }
                else
                {
                    lvSanPham.Items[i].SubItems.Add("Khóa");
                }
                
                i++;
            }

        }
        public void HienThiLView(string timkiem)
        {
            BAL_SANPHAM sp = new BAL_SANPHAM();
            lvSanPham.Items.Clear();
            int i = 0;
            foreach (BEL_SANPHAM sanpham in this.listSanPham)
            {
                if (sanpham.TenSP.ToLower().Contains(timkiem.ToLower()))
                {
                    lvSanPham.Items.Add((i + 1).ToString());
                    lvSanPham.Items[i].SubItems.Add(sanpham.IDSP.ToString());
                    lvSanPham.Items[i].SubItems.Add(sanpham.TenSP.ToString());
                    lvSanPham.Items[i].SubItems.Add(sanpham.DonGia.ToString("#,##0") + " VNĐ");
                    if (sanpham.TrangThai == 1)
                    {
                        lvSanPham.Items[i].SubItems.Add("Mở khóa");
                    }
                    else
                    {
                        lvSanPham.Items[i].SubItems.Add("Khóa");
                    }
                    i++;
                }
            }
        }
        public bool KiemTraTrungTen(string ten)
        {
            foreach (BEL_SANPHAM sanpham in this.listSanPham)
            {
                if (sanpham.TenSP.ToLower().Contains(ten.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.HienThiLView(txtTimKiem.Text);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lvSanPham_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvSanPham.SelectedItems)
                {
                    BEL_SANPHAM sp = new BEL_SANPHAM(this.SanPhamTheoID(item.SubItems[1].Text));
                    txtIDSP.Text = sp.IDSP;
                    txtTenSP.Text = sp.TenSP;
                    txtDonGia.Text = sp.DonGia.ToString();
                    if (sp.TrangThai == 0)
                    {
                        radKhoa.Checked = true;
                    }
                    else
                    {
                        radMoKhoa.Checked = true;
                    }
                    break;
                }
            }
        }
        private BEL_SANPHAM SanPhamTheoID(string id)
        {
            for(int i = 0; i < this.listSanPham.Count; i++)
            {
                if (this.listSanPham[i].IDSP.Equals(id))
                {
                    return this.listSanPham[i];
                }
            }
            return null;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            radMoKhoa.Checked = true;
            txtTimKiem.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Equals("") || txtDonGia.Text.Equals("") || double.Parse(txtDonGia.Text) > 100000)
            {
                if (txtTenSP.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenSP.Focus();
                }
                else if (txtDonGia.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDonGia.Focus();
                }
                else if (double.Parse(txtDonGia.Text) > 100000)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá < 100,000 vnđ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDonGia.Focus();
                }
            }
            else
            {
                BAL_SANPHAM bAL_SANPHAM = new BAL_SANPHAM();
                BEL_SANPHAM bel_sp = new BEL_SANPHAM();
                bel_sp.TenSP = txtTenSP.Text;
                bel_sp.DonGia = int.Parse(txtDonGia.Text);
                if(radMoKhoa.Checked == true)
                {
                    bel_sp.TrangThai = 1;
                }
                else
                {
                    bel_sp.TrangThai = 0;
                }
                if (KiemTraTrungTen(txtTenSP.Text))
                {
                    MessageBox.Show("Đã có sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    if (bAL_SANPHAM.ThemSanPham(bel_sp))
                    {
                        HienThiLView();
                        btnLamMoi_Click(sender, e);

                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtIDSP.Text.Equals(""))
            {
                if (txtIDSP.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenSP.Focus();
                }
            }
            else
            {
                BAL_SANPHAM bAL_SANPHAM = new BAL_SANPHAM();
                BEL_SANPHAM bel_sp = new BEL_SANPHAM();
                bel_sp.IDSP = txtIDSP.Text;
                bel_sp.TenSP = txtTenSP.Text;
                bel_sp.DonGia = int.Parse(txtDonGia.Text);
                if (radMoKhoa.Checked == true)
                {
                    bel_sp.TrangThai = 1;
                }
                else
                {
                    bel_sp.TrangThai = 0;
                }
                if (bel_sp.TrangThai == 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắn chắn thực hiện tha tác này!","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        if (bAL_SANPHAM.CapNhatSanPham(bel_sp))
                        {
                            HienThiLView();
                            btnLamMoi_Click(sender, e);

                            MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (bAL_SANPHAM.CapNhatSanPham(bel_sp))
                    {
                        HienThiLView();
                        btnLamMoi_Click(sender, e);

                        MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                

            }
        }
    }
}
