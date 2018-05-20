namespace WindowsFormsApplication9.GUI
{
    partial class TraCuuSTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNhapCMND = new System.Windows.Forms.TextBox();
            this.lbNhap = new System.Windows.Forms.Label();
            this.lbTraCuuSTK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSTK = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.dgvSTK = new System.Windows.Forms.DataGridView();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTraCuu);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txtNhapCMND);
            this.panel1.Controls.Add(this.lbNhap);
            this.panel1.Controls.Add(this.lbTraCuuSTK);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 459);
            this.panel1.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(181, 251);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(86, 30);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(273, 252);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNhapCMND
            // 
            this.txtNhapCMND.Location = new System.Drawing.Point(181, 155);
            this.txtNhapCMND.Name = "txtNhapCMND";
            this.txtNhapCMND.Size = new System.Drawing.Size(180, 29);
            this.txtNhapCMND.TabIndex = 3;
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap.Location = new System.Drawing.Point(3, 162);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(141, 22);
            this.lbNhap.TabIndex = 2;
            this.lbNhap.Text = "Nhập số CMND";
            // 
            // lbTraCuuSTK
            // 
            this.lbTraCuuSTK.AutoSize = true;
            this.lbTraCuuSTK.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraCuuSTK.ForeColor = System.Drawing.Color.Navy;
            this.lbTraCuuSTK.Location = new System.Drawing.Point(158, 23);
            this.lbTraCuuSTK.Name = "lbTraCuuSTK";
            this.lbTraCuuSTK.Size = new System.Drawing.Size(153, 27);
            this.lbTraCuuSTK.TabIndex = 1;
            this.lbTraCuuSTK.Text = "Tra Cứu STK";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbSTK);
            this.panel2.Controls.Add(this.lbKhachHang);
            this.panel2.Controls.Add(this.dgvSTK);
            this.panel2.Controls.Add(this.dgvKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(518, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 459);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbSTK
            // 
            this.lbSTK.AutoSize = true;
            this.lbSTK.Location = new System.Drawing.Point(142, 251);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(189, 22);
            this.lbSTK.TabIndex = 3;
            this.lbSTK.Text = "Thông tin sổ tiết kiểm";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Location = new System.Drawing.Point(143, 55);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(188, 22);
            this.lbKhachHang.TabIndex = 2;
            this.lbKhachHang.Text = "Thông tin khách hàng";
            // 
            // dgvSTK
            // 
            this.dgvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLoai,
            this.MaSTK,
            this.SoDu,
            this.NgayMo,
            this.NgayBD,
            this.NgayDH});
            this.dgvSTK.Location = new System.Drawing.Point(20, 280);
            this.dgvSTK.Name = "dgvSTK";
            this.dgvSTK.Size = new System.Drawing.Size(508, 150);
            this.dgvSTK.TabIndex = 1;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.Name = "TenLoai";
            // 
            // MaSTK
            // 
            this.MaSTK.HeaderText = "Mã STK";
            this.MaSTK.Name = "MaSTK";
            // 
            // SoDu
            // 
            this.SoDu.HeaderText = "Số dư";
            this.SoDu.Name = "SoDu";
            // 
            // NgayMo
            // 
            this.NgayMo.HeaderText = "Ngày mở";
            this.NgayMo.Name = "NgayMo";
            // 
            // NgayBD
            // 
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.Name = "NgayBD";
            // 
            // NgayDH
            // 
            this.NgayDH.HeaderText = "Ngày đáo hạn";
            this.NgayDH.Name = "NgayDH";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.DiaChi,
            this.SDT,
            this.GioiTinh,
            this.NgaySinh});
            this.dgvKhachHang.Location = new System.Drawing.Point(20, 96);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(508, 114);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TraCuuSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1084, 459);
            this.Controls.Add(this.panel1);
            this.Name = "TraCuuSTK";
            this.Text = "TraCuuSTK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNhapCMND;
        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.Label lbTraCuuSTK;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvSTK;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label lbSTK;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
    }
}