namespace QuanLyBanHang
{
    partial class QuanLyHoaDon
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
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TENNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaylap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Giolap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChiTietHoaDon = new System.Windows.Forms.ListView();
            this.SoTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labIDHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.IDHD,
            this.TENNV,
            this.IDKH,
            this.Ngaylap,
            this.Giolap,
            this.TongTien});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(13, 57);
            this.lvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(839, 206);
            this.lvHoaDon.TabIndex = 2;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.Click += new System.EventHandler(this.lvHoaDon_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 40;
            // 
            // IDHD
            // 
            this.IDHD.Text = "IDHD";
            this.IDHD.Width = 50;
            // 
            // TENNV
            // 
            this.TENNV.Text = "Tên nhân viên";
            this.TENNV.Width = 180;
            // 
            // IDKH
            // 
            this.IDKH.Text = "Tên Khách Hàng";
            this.IDKH.Width = 180;
            // 
            // Ngaylap
            // 
            this.Ngaylap.Text = "Ngày lập";
            this.Ngaylap.Width = 110;
            // 
            // Giolap
            // 
            this.Giolap.Text = "Giờ lập";
            this.Giolap.Width = 100;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Thành tiền";
            this.TongTien.Width = 150;
            // 
            // lvChiTietHoaDon
            // 
            this.lvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoTT,
            this.TenSP,
            this.DonGia,
            this.Soluong,
            this.Thanhtien});
            this.lvChiTietHoaDon.FullRowSelect = true;
            this.lvChiTietHoaDon.HideSelection = false;
            this.lvChiTietHoaDon.Location = new System.Drawing.Point(13, 310);
            this.lvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.lvChiTietHoaDon.Name = "lvChiTietHoaDon";
            this.lvChiTietHoaDon.Size = new System.Drawing.Size(839, 227);
            this.lvChiTietHoaDon.TabIndex = 3;
            this.lvChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvChiTietHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // SoTT
            // 
            this.SoTT.Text = "STT";
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên sản phẩm";
            this.TenSP.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.Width = 140;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Số lượng";
            this.Soluong.Width = 120;
            // 
            // Thanhtien
            // 
            this.Thanhtien.Text = "Tổng tiền";
            this.Thanhtien.Width = 290;
            // 
            // labIDHD
            // 
            this.labIDHD.AutoSize = true;
            this.labIDHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labIDHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIDHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labIDHD.Location = new System.Drawing.Point(12, 280);
            this.labIDHD.Name = "labIDHD";
            this.labIDHD.Size = new System.Drawing.Size(204, 17);
            this.labIDHD.TabIndex = 28;
            this.labIDHD.Text = "Thông tin chi tiết của hóa đơn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labIDHD);
            this.Controls.Add(this.lvChiTietHoaDon);
            this.Controls.Add(this.lvHoaDon);
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ListView lvChiTietHoaDon;
        private System.Windows.Forms.ColumnHeader IDHD;
        private System.Windows.Forms.ColumnHeader TENNV;
        private System.Windows.Forms.ColumnHeader Ngaylap;
        private System.Windows.Forms.ColumnHeader Giolap;
        private System.Windows.Forms.ColumnHeader TongTien;
        private System.Windows.Forms.ColumnHeader SoTT;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader Soluong;
        private System.Windows.Forms.ColumnHeader Thanhtien;
        private System.Windows.Forms.Label labIDHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader IDKH;
    }
}