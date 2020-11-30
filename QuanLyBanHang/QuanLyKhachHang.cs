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
    public partial class QuanLyKhachHang : Form
    {
        public BEL_KHACHHANG bel_kh = new BEL_KHACHHANG();
        List<BEL_KHACHHANG> listKhachHang = new List<BEL_KHACHHANG>();
        public QuanLyKhachHang()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
            HienThiLView();
            radMoKhoa.Checked = true;
            txtID.Enabled = false;
        }
        public void HienThiLView()
        {
            BAL_KHACHHANG kh = new BAL_KHACHHANG();

            listKhachHang = kh.HienThiLView(1);

            List<BEL_KHACHHANG> listKhachHangTemp = new List<BEL_KHACHHANG>();
            listKhachHangTemp = kh.HienThiLView(0);

            foreach(BEL_KHACHHANG value in listKhachHangTemp)
            {
                this.listKhachHang.Add(value);
            }

            lvKhachHang.Items.Clear();
            int i = 0;
            foreach (BEL_KHACHHANG khachhang in listKhachHang)
            {
                lvKhachHang.Items.Add((i + 1).ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.IDKH.ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.HoTen.ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.DienThoai.ToString());
                lvKhachHang.Items[i].SubItems.Add(khachhang.GioiTinh.ToString());
                if (khachhang.Trangthai == 1)
                {
                    lvKhachHang.Items[i].SubItems.Add("Mở Khóa");
                }
                else
                {
                    lvKhachHang.Items[i].SubItems.Add("Khóa");
                }
                i++;
            }
        }
        public void HienThiLView(string timkiem)
        {
            lvKhachHang.Items.Clear();
            int i = 0;
            foreach (BEL_KHACHHANG khachhang in listKhachHang)
            {
                if (khachhang.DienThoai.ToLower().Contains(timkiem.ToLower()))
                {
                    lvKhachHang.Items.Add((i + 1).ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.IDKH.ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.HoTen.ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.DienThoai.ToString());
                    lvKhachHang.Items[i].SubItems.Add(khachhang.GioiTinh.ToString());

                    if (khachhang.Trangthai == 1)
                    {
                        lvKhachHang.Items[i].SubItems.Add("Mở Khóa");
                    }
                    else
                    {
                        lvKhachHang.Items[i].SubItems.Add("Khóa");
                    }
                    i++;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            HienThiLView(txtTimKiem.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtTimKiem.Text = "";
            radMoKhoa.Checked = true;
            radNam.Checked = true;
        }

        private void lvKhachHang_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvKhachHang.SelectedItems)
                {
                    BEL_KHACHHANG kh = new BEL_KHACHHANG(this.KhachHangTheoID(item.SubItems[1].Text));
                    
                    txtID.Text = kh.IDKH;
                    txtHoTen.Text = kh.HoTen;
                    txtSDT.Text = kh.DienThoai;
                    if (kh.GioiTinh == "Nam")
                    {
                        radNam.Checked = true;
                    }
                    else
                    {
                        radNu.Checked = true;
                    }
                    if (kh.Trangthai == 0)
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
        private BEL_KHACHHANG KhachHangTheoID(string id)
        {
            for (int i = 0; i < this.listKhachHang.Count; i++)
            {
                if (this.listKhachHang[i].IDKH.Equals(id))
                {
                    return this.listKhachHang[i];
                }
            }
            return null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Equals("") || txtSDT.Text.Length != 10 || txtSDT.Text.Equals(""))
            {
                if (txtHoTen.Text.Equals(""))
                {
                    txtHoTen.Focus();
                    MessageBox.Show("Vui lòng nhập họ tên! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSDT.Text.Equals(""))
                {
                    txtSDT.Focus();
                    MessageBox.Show("Vui lòng nhập SĐT! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtSDT.Text.Length != 10)
                {
                    txtSDT.Focus();
                    MessageBox.Show("Vui lòng nhập SĐT là 10 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                BAL_KHACHHANG bAL_KHACHHANG = new BAL_KHACHHANG();
                bel_kh = new BEL_KHACHHANG();
                bel_kh.HoTen = txtHoTen.Text.ToString();
                bel_kh.DienThoai = txtSDT.Text;
                if (radNam.Checked == true)
                {
                    bel_kh.GioiTinh = "Nam";
                }
                else
                {
                    bel_kh.GioiTinh = "Nữ";
                }
                if (radMoKhoa.Checked == true)
                {
                    bel_kh.Trangthai = 1;
                }
                else
                {
                    bel_kh.Trangthai = 0;
                }
                if (bAL_KHACHHANG.KiemTraTrungKH(this.bel_kh))
                {
                    MessageBox.Show("Số điện đã đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bAL_KHACHHANG.ThemKhachHang(this.bel_kh))
                    {
                        HienThiLView();
                        btnLamMoi_Click(sender, e);
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (txtSDT.Text.Length != 10)
            {
                txtSDT.Focus();
                MessageBox.Show("Vui lòng nhập SĐT là 10 số! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BAL_KHACHHANG bAL_KHACHHANG = new BAL_KHACHHANG();
                bel_kh = new BEL_KHACHHANG();
                bel_kh.IDKH = txtID.Text;
                bel_kh.HoTen = txtHoTen.Text.ToString();
                bel_kh.DienThoai = txtSDT.Text;
                if (radNam.Checked == true)
                {
                    bel_kh.GioiTinh = "Nam";
                }
                else
                {
                    bel_kh.GioiTinh = "Nữ";
                }
                if (radMoKhoa.Checked == true)
                {
                    bel_kh.Trangthai = 1;
                }
                else
                {
                    bel_kh.Trangthai = 0;
                }
                if(bel_kh.Trangthai == 0)
                {
                    if (bAL_KHACHHANG.KiemTraTrungKHID(txtSDT.Text) == null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắn chắn thực hiện thao tác này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (bAL_KHACHHANG.CapNhatKH(this.bel_kh))
                            {
                                HienThiLView();
                                btnLamMoi_Click(sender, e);
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        
                    }
                    else if (bAL_KHACHHANG.KiemTraTrungKHID(txtSDT.Text).Equals(txtID.Text) == false)
                    {
                        MessageBox.Show("Số điện đã đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắn chắn thực hiện thao tác này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (bAL_KHACHHANG.CapNhatKH(this.bel_kh))
                            {
                                HienThiLView();
                                btnLamMoi_Click(sender, e);
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    
                }
                else
                {
                    if (bAL_KHACHHANG.KiemTraTrungKHID(txtSDT.Text) == null)
                    {
                        if (bAL_KHACHHANG.CapNhatKH(this.bel_kh))
                        {
                            HienThiLView();
                            btnLamMoi_Click(sender, e);
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (bAL_KHACHHANG.KiemTraTrungKHID(txtSDT.Text).Equals(txtID.Text) == false)
                    {
                        MessageBox.Show("Số điện đã đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (bAL_KHACHHANG.CapNhatKH(this.bel_kh))
                        {
                            HienThiLView();
                            btnLamMoi_Click(sender, e);
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
