namespace QuanLyBanHang
{
    partial class ThayDoiSoLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSoLuong = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.labThanhTien = new System.Windows.Forms.Label();
            this.labDonGia = new System.Windows.Forms.Label();
            this.labTenSP = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab0 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labLuuY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THAY ĐỔI SỐ LƯỢNG";
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.Items.AddRange(new object[] {
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
            this.cboSoLuong.Location = new System.Drawing.Point(163, 158);
            this.cboSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(145, 21);
            this.cboSoLuong.TabIndex = 1;
            this.cboSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSoLuong_KeyPress);
            this.cboSoLuong.Leave += new System.EventHandler(this.cboSoLuong_Leave);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Image = global::QuanLyBanHang.Properties.Resources.Log_Out_32x32;
            this.btnThoat.Location = new System.Drawing.Point(198, 221);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Image = global::QuanLyBanHang.Properties.Resources.Save_32x32;
            this.btnLuu.Location = new System.Drawing.Point(72, 221);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 49);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labThanhTien
            // 
            this.labThanhTien.AutoSize = true;
            this.labThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labThanhTien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labThanhTien.Location = new System.Drawing.Point(168, 129);
            this.labThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labThanhTien.Name = "labThanhTien";
            this.labThanhTien.Size = new System.Drawing.Size(54, 13);
            this.labThanhTien.TabIndex = 0;
            this.labThanhTien.Text = "thành tiền";
            // 
            // labDonGia
            // 
            this.labDonGia.AutoSize = true;
            this.labDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labDonGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDonGia.Location = new System.Drawing.Point(168, 96);
            this.labDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDonGia.Name = "labDonGia";
            this.labDonGia.Size = new System.Drawing.Size(21, 13);
            this.labDonGia.TabIndex = 0;
            this.labDonGia.Text = "giá";
            // 
            // labTenSP
            // 
            this.labTenSP.AutoSize = true;
            this.labTenSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labTenSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTenSP.Location = new System.Drawing.Point(168, 62);
            this.labTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTenSP.Name = "labTenSP";
            this.labTenSP.Size = new System.Drawing.Size(71, 13);
            this.labTenSP.TabIndex = 0;
            this.labTenSP.Text = "tên sản phẩm";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab3.Location = new System.Drawing.Point(15, 161);
            this.lab3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(52, 13);
            this.lab3.TabIndex = 0;
            this.lab3.Text = "Số lượng:";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab2.Location = new System.Drawing.Point(15, 129);
            this.lab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(61, 13);
            this.lab2.TabIndex = 0;
            this.lab2.Text = "Thành tiền:";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab1.Location = new System.Drawing.Point(15, 96);
            this.lab1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(26, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Giá:";
            // 
            // lab0
            // 
            this.lab0.AutoSize = true;
            this.lab0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab0.Location = new System.Drawing.Point(15, 62);
            this.lab0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab0.Name = "lab0";
            this.lab0.Size = new System.Drawing.Size(78, 13);
            this.lab0.TabIndex = 0;
            this.lab0.Text = "Tên sản phẩm:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labLuuY
            // 
            this.labLuuY.AutoSize = true;
            this.labLuuY.BackColor = System.Drawing.Color.Yellow;
            this.labLuuY.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuuY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labLuuY.Location = new System.Drawing.Point(12, 191);
            this.labLuuY.Name = "labLuuY";
            this.labLuuY.Size = new System.Drawing.Size(192, 17);
            this.labLuuY.TabIndex = 11;
            this.labLuuY.Text = "Lưu ý: số lượng tối đa 1000!";
            // 
            // ThayDoiSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.background_diachi;
            this.ClientSize = new System.Drawing.Size(357, 274);
            this.Controls.Add(this.labLuuY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSoLuong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labThanhTien);
            this.Controls.Add(this.labDonGia);
            this.Controls.Add(this.labTenSP);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lab0);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ThayDoiSoLuong";
            this.Text = "ThayDoiSoLuong";
            this.Load += new System.EventHandler(this.ThayDoiSoLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSoLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label labThanhTien;
        private System.Windows.Forms.Label labDonGia;
        private System.Windows.Forms.Label labTenSP;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labLuuY;
    }
}