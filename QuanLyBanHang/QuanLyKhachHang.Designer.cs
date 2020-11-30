namespace QuanLyBanHang
{
    partial class QuanLyKhachHang
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
            this.lvKhachHang = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radKhoa = new System.Windows.Forms.RadioButton();
            this.radMoKhoa = new System.Windows.Forms.RadioButton();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKhachHang
            // 
            this.lvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDKH,
            this.Hoten,
            this.Dienthoai,
            this.Gioitinh,
            this.Trangthai});
            this.lvKhachHang.FullRowSelect = true;
            this.lvKhachHang.HideSelection = false;
            this.lvKhachHang.Location = new System.Drawing.Point(13, 296);
            this.lvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.lvKhachHang.Name = "lvKhachHang";
            this.lvKhachHang.Size = new System.Drawing.Size(618, 225);
            this.lvKhachHang.TabIndex = 4;
            this.lvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvKhachHang.View = System.Windows.Forms.View.Details;
            this.lvKhachHang.Click += new System.EventHandler(this.lvKhachHang_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 40;
            // 
            // IDKH
            // 
            this.IDKH.Text = "IDKH";
            this.IDKH.Width = 45;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Họ tên Khách hàng";
            this.Hoten.Width = 180;
            // 
            // Dienthoai
            // 
            this.Dienthoai.Text = "Số Điện Thoại";
            this.Dienthoai.Width = 140;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Text = "Giới Tính";
            this.Gioitinh.Width = 103;
            // 
            // Trangthai
            // 
            this.Trangthai.Text = "Trạng Thái";
            this.Trangthai.Width = 87;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(13, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(618, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN NHÂN VIÊN-TÀI KHOẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID khách hàng:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(170, 33);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 26);
            this.txtID.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.groupBox1.Controls.Add(this.radKhoa);
            this.groupBox1.Controls.Add(this.radMoKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(25, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(390, 67);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRẠNG THÁI";
            // 
            // radKhoa
            // 
            this.radKhoa.AutoSize = true;
            this.radKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radKhoa.Location = new System.Drawing.Point(188, 29);
            this.radKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.radKhoa.Name = "radKhoa";
            this.radKhoa.Size = new System.Drawing.Size(61, 23);
            this.radKhoa.TabIndex = 7;
            this.radKhoa.TabStop = true;
            this.radKhoa.Text = "Khóa";
            this.radKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radKhoa.UseVisualStyleBackColor = false;
            // 
            // radMoKhoa
            // 
            this.radMoKhoa.AutoSize = true;
            this.radMoKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radMoKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMoKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMoKhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radMoKhoa.Location = new System.Drawing.Point(57, 29);
            this.radMoKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.radMoKhoa.Name = "radMoKhoa";
            this.radMoKhoa.Size = new System.Drawing.Size(83, 23);
            this.radMoKhoa.TabIndex = 6;
            this.radMoKhoa.TabStop = true;
            this.radMoKhoa.Text = "Mở khóa";
            this.radMoKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radMoKhoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(423, 70);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(176, 37);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(423, 153);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(176, 45);
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giới tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(253, 144);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(48, 23);
            this.radNu.TabIndex = 15;
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
            this.radNam.Location = new System.Drawing.Point(170, 144);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 23);
            this.radNam.TabIndex = 14;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radNam.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(423, 108);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(176, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên Khách Hàng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(170, 70);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 26);
            this.txtHoTen.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(170, 104);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 26);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(324, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(399, 262);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(232, 26);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvKhachHang);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ListView lvKhachHang;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader Dienthoai;
        private System.Windows.Forms.ColumnHeader Gioitinh;
        private System.Windows.Forms.ColumnHeader Trangthai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radKhoa;
        private System.Windows.Forms.RadioButton radMoKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ColumnHeader IDKH;
    }
}