namespace QuanLyBanHang
{
    partial class QuanLyTaiKhoan
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
            this.radKhoa = new System.Windows.Forms.RadioButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labMKMatDinh = new System.Windows.Forms.Label();
            this.radMoKhoa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKhoiPhucMatKhau = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radNhanVien = new System.Windows.Forms.RadioButton();
            this.radQuanLy = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtDiachiNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // radKhoa
            // 
            this.radKhoa.AutoSize = true;
            this.radKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhoa.Location = new System.Drawing.Point(179, 27);
            this.radKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.radKhoa.Name = "radKhoa";
            this.radKhoa.Size = new System.Drawing.Size(61, 23);
            this.radKhoa.TabIndex = 12;
            this.radKhoa.TabStop = true;
            this.radKhoa.Text = "Khóa";
            this.radKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radKhoa.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(170, 33);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(275, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(880, 130);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox3.Controls.Add(this.radNu);
            this.groupBox3.Controls.Add(this.radNam);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(467, 66);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(305, 60);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GIỚI TÍNH";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(180, 26);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(48, 23);
            this.radNu.TabIndex = 8;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radNu.UseVisualStyleBackColor = false;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(32, 26);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 23);
            this.radNam.TabIndex = 7;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radNam.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID Nhân Viên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(464, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mật Khẩu Mặc Định: ";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDNV,
            this.Hoten,
            this.Dienthoai,
            this.Ngaysinh,
            this.CMND,
            this.Gioitinh,
            this.LoaiNV,
            this.Trangthai,
            this.Diachi});
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(16, 342);
            this.lvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(1239, 224);
            this.lvNhanVien.TabIndex = 1;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.Click += new System.EventHandler(this.lvNhanVien_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 42;
            // 
            // IDNV
            // 
            this.IDNV.Text = "ID Nhân Viên";
            this.IDNV.Width = 125;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Họ tên Nhân Viên";
            this.Hoten.Width = 147;
            // 
            // Dienthoai
            // 
            this.Dienthoai.Text = "Số Điện Thoại";
            this.Dienthoai.Width = 104;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Text = "Ngày Sinh";
            this.Ngaysinh.Width = 107;
            // 
            // CMND
            // 
            this.CMND.Text = "CMND/CCCD";
            this.CMND.Width = 168;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Text = "Giới Tính";
            this.Gioitinh.Width = 107;
            // 
            // LoaiNV
            // 
            this.LoaiNV.Text = "Chức Vụ";
            this.LoaiNV.Width = 80;
            // 
            // Trangthai
            // 
            this.Trangthai.Text = "Trạng Thái";
            this.Trangthai.Width = 82;
            // 
            // Diachi
            // 
            this.Diachi.Text = "Địa Chỉ";
            this.Diachi.Width = 250;
            // 
            // labMKMatDinh
            // 
            this.labMKMatDinh.AutoSize = true;
            this.labMKMatDinh.BackColor = System.Drawing.Color.Red;
            this.labMKMatDinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMKMatDinh.ForeColor = System.Drawing.Color.Yellow;
            this.labMKMatDinh.Location = new System.Drawing.Point(669, 36);
            this.labMKMatDinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMKMatDinh.Name = "labMKMatDinh";
            this.labMKMatDinh.Size = new System.Drawing.Size(70, 22);
            this.labMKMatDinh.TabIndex = 0;
            this.labMKMatDinh.Text = "123123";
            // 
            // radMoKhoa
            // 
            this.radMoKhoa.AutoSize = true;
            this.radMoKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radMoKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMoKhoa.Location = new System.Drawing.Point(31, 27);
            this.radMoKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.radMoKhoa.Name = "radMoKhoa";
            this.radMoKhoa.Size = new System.Drawing.Size(87, 23);
            this.radMoKhoa.TabIndex = 11;
            this.radMoKhoa.TabStop = true;
            this.radMoKhoa.Text = "Mở Khóa";
            this.radMoKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radMoKhoa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(456, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btnKhoiPhucMatKhau);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.labMKMatDinh);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHoTenNV);
            this.groupBox2.Controls.Add(this.txtDiachiNV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(16, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1239, 284);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN NHÂN VIÊN-TÀI KHOẢN";
            // 
            // btnKhoiPhucMatKhau
            // 
            this.btnKhoiPhucMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKhoiPhucMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhucMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhucMatKhau.Location = new System.Drawing.Point(880, 178);
            this.btnKhoiPhucMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoiPhucMatKhau.Name = "btnKhoiPhucMatKhau";
            this.btnKhoiPhucMatKhau.Size = new System.Drawing.Size(255, 45);
            this.btnKhoiPhucMatKhau.TabIndex = 17;
            this.btnKhoiPhucMatKhau.Text = "KHÔI PHỤC LẠI MẬT KHẨU";
            this.btnKhoiPhucMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKhoiPhucMatKhau.UseVisualStyleBackColor = false;
            this.btnKhoiPhucMatKhau.Click += new System.EventHandler(this.btnKhoiPhucMatKhau_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(1009, 130);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(126, 45);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(880, 81);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(255, 45);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox4.Controls.Add(this.radNhanVien);
            this.groupBox4.Controls.Add(this.radQuanLy);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(468, 134);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(304, 62);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHỨC VỤ";
            // 
            // radNhanVien
            // 
            this.radNhanVien.AutoSize = true;
            this.radNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhanVien.Location = new System.Drawing.Point(179, 27);
            this.radNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(91, 23);
            this.radNhanVien.TabIndex = 10;
            this.radNhanVien.TabStop = true;
            this.radNhanVien.Text = "Nhân Viên";
            this.radNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radNhanVien.UseVisualStyleBackColor = false;
            // 
            // radQuanLy
            // 
            this.radQuanLy.AutoSize = true;
            this.radQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radQuanLy.Location = new System.Drawing.Point(31, 27);
            this.radQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.radQuanLy.Name = "radQuanLy";
            this.radQuanLy.Size = new System.Drawing.Size(80, 23);
            this.radQuanLy.TabIndex = 9;
            this.radQuanLy.TabStop = true;
            this.radQuanLy.Text = "Quản Lý";
            this.radQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radQuanLy.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox5.Controls.Add(this.radKhoa);
            this.groupBox5.Controls.Add(this.radMoKhoa);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(468, 204);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(304, 69);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TRẠNG THÁI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên Nhân Viên:";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNV.Location = new System.Drawing.Point(170, 66);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(275, 26);
            this.txtHoTenNV.TabIndex = 2;
            // 
            // txtDiachiNV
            // 
            this.txtDiachiNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachiNV.Location = new System.Drawing.Point(170, 204);
            this.txtDiachiNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachiNV.Multiline = true;
            this.txtDiachiNV.Name = "txtDiachiNV";
            this.txtDiachiNV.Size = new System.Drawing.Size(275, 69);
            this.txtDiachiNV.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(170, 100);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(275, 26);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(170, 134);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(275, 26);
            this.txtCMND.TabIndex = 4;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "CMND/CCCD: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ: ";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Location = new System.Drawing.Point(170, 170);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(275, 26);
            this.dtNgaySinh.TabIndex = 5;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 583);
            this.Controls.Add(this.lvNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radKhoa;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader IDNV;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader Dienthoai;
        private System.Windows.Forms.ColumnHeader Ngaysinh;
        private System.Windows.Forms.ColumnHeader CMND;
        private System.Windows.Forms.ColumnHeader Gioitinh;
        private System.Windows.Forms.ColumnHeader LoaiNV;
        private System.Windows.Forms.ColumnHeader Trangthai;
        private System.Windows.Forms.ColumnHeader Diachi;
        private System.Windows.Forms.Label labMKMatDinh;
        private System.Windows.Forms.RadioButton radMoKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKhoiPhucMatKhau;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radNhanVien;
        private System.Windows.Forms.RadioButton radQuanLy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtDiachiNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}