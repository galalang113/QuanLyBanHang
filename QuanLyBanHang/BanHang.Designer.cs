namespace QuanLyBanHang
{
    partial class form_BANHANG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBanHang = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTenKH = new System.Windows.Forms.Button();
            this.labLuuY = new System.Windows.Forms.Label();
            this.lvBill = new System.Windows.Forms.ListView();
            this.BillSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labLich = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboChonSoLuongSP = new System.Windows.Forms.ComboBox();
            this.btnChuyenPhaiALL = new System.Windows.Forms.Button();
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labTenNV = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoaChonBill = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBanHang
            // 
            this.pictureBanHang.BackgroundImage = global::QuanLyBanHang.Properties.Resources.kteatime;
            this.pictureBanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBanHang.Location = new System.Drawing.Point(12, 12);
            this.pictureBanHang.Name = "pictureBanHang";
            this.pictureBanHang.Size = new System.Drawing.Size(197, 126);
            this.pictureBanHang.TabIndex = 1;
            this.pictureBanHang.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.lvSanPham);
            this.groupBox4.Controls.Add(this.txtTimKiemSP);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(215, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 368);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenSP,
            this.DonGia});
            this.lvSanPham.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(11, 63);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(394, 299);
            this.lvSanPham.TabIndex = 0;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 40;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên sản phẩm";
            this.TenSP.Width = 185;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 145;
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSP.Location = new System.Drawing.Point(138, 32);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(267, 25);
            this.txtTimKiemSP.TabIndex = 1;
            this.txtTimKiemSP.TextChanged += new System.EventHandler(this.txtTKTenSP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Sản Phẩm:";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.btnTenKH);
            this.groupBox3.Controls.Add(this.labLuuY);
            this.groupBox3.Controls.Add(this.lvBill);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.labTime);
            this.groupBox3.Controls.Add(this.labLich);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTenKH);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(714, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 452);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ĐẶT HÀNG SẢN PHẨM";
            // 
            // btnTenKH
            // 
            this.btnTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTenKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTenKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenKH.Location = new System.Drawing.Point(358, 58);
            this.btnTenKH.Name = "btnTenKH";
            this.btnTenKH.Size = new System.Drawing.Size(146, 35);
            this.btnTenKH.TabIndex = 11;
            this.btnTenKH.Text = "Chọn khách hàng";
            this.btnTenKH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTenKH.UseVisualStyleBackColor = false;
            this.btnTenKH.Click += new System.EventHandler(this.btnTenKH_Click);
            // 
            // labLuuY
            // 
            this.labLuuY.BackColor = System.Drawing.Color.Yellow;
            this.labLuuY.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuuY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labLuuY.Location = new System.Drawing.Point(10, 388);
            this.labLuuY.Name = "labLuuY";
            this.labLuuY.Size = new System.Drawing.Size(363, 36);
            this.labLuuY.TabIndex = 10;
            this.labLuuY.Text = "Lưu ý: - Nhấp đúp vào sản phẩm để thay đổi số lượng!              - Chọn khách hà" +
    "ng trước khi thanh toán!";
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BillSTT,
            this.BillTenSP,
            this.BillSoLuong,
            this.BillDonGia,
            this.BillTongTien});
            this.lvBill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.FullRowSelect = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(9, 139);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(495, 246);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            this.lvBill.DoubleClick += new System.EventHandler(this.lvBill_DoubleClick);
            // 
            // BillSTT
            // 
            this.BillSTT.Text = "STT";
            this.BillSTT.Width = 42;
            // 
            // BillTenSP
            // 
            this.BillTenSP.Text = "Tên sản phẩm";
            this.BillTenSP.Width = 140;
            // 
            // BillSoLuong
            // 
            this.BillSoLuong.Text = "Số lượng";
            this.BillSoLuong.Width = 78;
            // 
            // BillDonGia
            // 
            this.BillDonGia.Text = "Đơn giá";
            this.BillDonGia.Width = 90;
            // 
            // BillTongTien
            // 
            this.BillTongTien.Text = "Tổng tiền";
            this.BillTongTien.Width = 120;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(146, 108);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(204, 25);
            this.txtThanhTien.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thành tiền:";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(324, 30);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(63, 17);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "Thời gian";
            // 
            // labLich
            // 
            this.labLich.AutoSize = true;
            this.labLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labLich.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLich.Location = new System.Drawing.Point(149, 30);
            this.labLich.Name = "labLich";
            this.labLich.Size = new System.Drawing.Size(105, 17);
            this.labLich.TabIndex = 0;
            this.labLich.Text = "Ngày tháng năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(358, 95);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(146, 42);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(146, 65);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(204, 25);
            this.txtTenKH.TabIndex = 7;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(646, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số Lượng";
            // 
            // cboChonSoLuongSP
            // 
            this.cboChonSoLuongSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChonSoLuongSP.FormattingEnabled = true;
            this.cboChonSoLuongSP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboChonSoLuongSP.Location = new System.Drawing.Point(636, 271);
            this.cboChonSoLuongSP.Name = "cboChonSoLuongSP";
            this.cboChonSoLuongSP.Size = new System.Drawing.Size(72, 21);
            this.cboChonSoLuongSP.TabIndex = 8;
            this.cboChonSoLuongSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboChonSoLuongSP_KeyPress);
            this.cboChonSoLuongSP.Leave += new System.EventHandler(this.cboChonSoLuongSP_Leave);
            // 
            // btnChuyenPhaiALL
            // 
            this.btnChuyenPhaiALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChuyenPhaiALL.BackgroundImage = global::QuanLyBanHang.Properties.Resources.doublearrow32x32;
            this.btnChuyenPhaiALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChuyenPhaiALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenPhaiALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhaiALL.Location = new System.Drawing.Point(636, 350);
            this.btnChuyenPhaiALL.Name = "btnChuyenPhaiALL";
            this.btnChuyenPhaiALL.Size = new System.Drawing.Size(74, 44);
            this.btnChuyenPhaiALL.TabIndex = 10;
            this.btnChuyenPhaiALL.UseVisualStyleBackColor = false;
            this.btnChuyenPhaiALL.Click += new System.EventHandler(this.btnChuyenPhaiALL_Click);
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSangPhai.BackgroundImage = global::QuanLyBanHang.Properties.Resources.Next_32x32;
            this.btnSangPhai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSangPhai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSangPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSangPhai.Location = new System.Drawing.Point(636, 302);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(74, 42);
            this.btnSangPhai.TabIndex = 9;
            this.btnSangPhai.UseVisualStyleBackColor = false;
            this.btnSangPhai.Click += new System.EventHandler(this.btnSangPhai_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nhân Viên:";
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTenNV.Location = new System.Drawing.Point(6, 82);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(103, 19);
            this.labTenNV.TabIndex = 12;
            this.labTenNV.Text = "Tên nhân viên";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(714, 459);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 41);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "HỦY ĐẶT HÀNG";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoaChonBill
            // 
            this.btnXoaChonBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaChonBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaChonBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaChonBill.Location = new System.Drawing.Point(819, 459);
            this.btnXoaChonBill.Name = "btnXoaChonBill";
            this.btnXoaChonBill.Size = new System.Drawing.Size(98, 41);
            this.btnXoaChonBill.TabIndex = 15;
            this.btnXoaChonBill.Text = "XÓA SẢN PHẨM";
            this.btnXoaChonBill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaChonBill.UseVisualStyleBackColor = false;
            this.btnXoaChonBill.Click += new System.EventHandler(this.btnXoaChonBill_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongTin.Location = new System.Drawing.Point(1042, 459);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(90, 41);
            this.btnThongTin.TabIndex = 16;
            this.btnThongTin.Text = "THÔNG TIN";
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(1132, 459);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 41);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "ĐĂNG XUẤT";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.labTenNV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 355);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hotline: (+088) 64 0254";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÍ QUÁN CAFE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ: 65, Huỳnh Thúc Kháng, Phường Bến Nghé";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Quận 1, TP. HCM";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form_BANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 504);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoaChonBill);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboChonSoLuongSP);
            this.Controls.Add(this.btnChuyenPhaiALL);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBanHang);
            this.Name = "form_BANHANG";
            this.Text = "BÁN HÀNG";
            this.Load += new System.EventHandler(this.form_BANHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBanHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader BillSTT;
        private System.Windows.Forms.ColumnHeader BillTenSP;
        private System.Windows.Forms.ColumnHeader BillSoLuong;
        private System.Windows.Forms.ColumnHeader BillDonGia;
        private System.Windows.Forms.ColumnHeader BillTongTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labLich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboChonSoLuongSP;
        private System.Windows.Forms.Button btnChuyenPhaiALL;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labTenNV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoaChonBill;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labLuuY;
        private System.Windows.Forms.Button btnTenKH;
    }
}

