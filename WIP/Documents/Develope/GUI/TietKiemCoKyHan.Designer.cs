namespace WindowsFormsApplication9.GUI
{
    partial class FormGuiTienThu
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
            this.cbxLoaiTraCuu = new System.Windows.Forms.ComboBox();
            this.lblLoi = new System.Windows.Forms.Label();
            this.txtNgayDH = new System.Windows.Forms.TextBox();
            this.lbNgayDH = new System.Windows.Forms.Label();
            this.txtNgayBD = new System.Windows.Forms.TextBox();
            this.lbNgayBD = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lbMaSTK = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.txtTienGui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSTK = new System.Windows.Forms.DataGridView();
            this.MaSTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaiSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaoHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTienGui = new System.Windows.Forms.Label();
            this.lbNhapCMND = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxLoaiTraCuu);
            this.panel1.Controls.Add(this.lblLoi);
            this.panel1.Controls.Add(this.txtNgayDH);
            this.panel1.Controls.Add(this.lbNgayDH);
            this.panel1.Controls.Add(this.txtNgayBD);
            this.panel1.Controls.Add(this.lbNgayBD);
            this.panel1.Controls.Add(this.btnKiemTra);
            this.panel1.Controls.Add(this.txtTuKhoa);
            this.panel1.Controls.Add(this.lbMaSTK);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGui);
            this.panel1.Controls.Add(this.txtTienGui);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbTienGui);
            this.panel1.Controls.Add(this.lbNhapCMND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 624);
            this.panel1.TabIndex = 0;
            // 
            // cbxLoaiTraCuu
            // 
            this.cbxLoaiTraCuu.FormattingEnabled = true;
            this.cbxLoaiTraCuu.Items.AddRange(new object[] {
            "CMND",
            "Mã STK"});
            this.cbxLoaiTraCuu.Location = new System.Drawing.Point(335, 196);
            this.cbxLoaiTraCuu.Name = "cbxLoaiTraCuu";
            this.cbxLoaiTraCuu.Size = new System.Drawing.Size(225, 30);
            this.cbxLoaiTraCuu.TabIndex = 18;
            this.cbxLoaiTraCuu.Text = "CMND";
            // 
            // lblLoi
            // 
            this.lblLoi.AutoSize = true;
            this.lblLoi.Font = new System.Drawing.Font("Arial", 14F);
            this.lblLoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoi.Location = new System.Drawing.Point(116, 287);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(208, 22);
            this.lblLoi.TabIndex = 17;
            this.lblLoi.Text = "Vui lòng bấm \"Kiểm tra\"";
            this.lblLoi.Visible = false;
            // 
            // txtNgayDH
            // 
            this.txtNgayDH.Location = new System.Drawing.Point(335, 457);
            this.txtNgayDH.Name = "txtNgayDH";
            this.txtNgayDH.Size = new System.Drawing.Size(225, 29);
            this.txtNgayDH.TabIndex = 16;
            // 
            // lbNgayDH
            // 
            this.lbNgayDH.AutoSize = true;
            this.lbNgayDH.Location = new System.Drawing.Point(116, 456);
            this.lbNgayDH.Name = "lbNgayDH";
            this.lbNgayDH.Size = new System.Drawing.Size(162, 22);
            this.lbNgayDH.TabIndex = 15;
            this.lbNgayDH.Text = "Ngày đáo hạn mới";
            // 
            // txtNgayBD
            // 
            this.txtNgayBD.Location = new System.Drawing.Point(335, 409);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.Size = new System.Drawing.Size(225, 29);
            this.txtNgayBD.TabIndex = 14;
            // 
            // lbNgayBD
            // 
            this.lbNgayBD.AutoSize = true;
            this.lbNgayBD.Location = new System.Drawing.Point(116, 416);
            this.lbNgayBD.Name = "lbNgayBD";
            this.lbNgayBD.Size = new System.Drawing.Size(157, 22);
            this.lbNgayBD.TabIndex = 13;
            this.lbNgayBD.Text = "Ngày bắt đầu mới";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(458, 284);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(102, 28);
            this.btnKiemTra.TabIndex = 12;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(335, 236);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(225, 29);
            this.txtTuKhoa.TabIndex = 9;
            // 
            // lbMaSTK
            // 
            this.lbMaSTK.AutoSize = true;
            this.lbMaSTK.Location = new System.Drawing.Point(116, 243);
            this.lbMaSTK.Name = "lbMaSTK";
            this.lbMaSTK.Size = new System.Drawing.Size(149, 22);
            this.lbMaSTK.TabIndex = 8;
            this.lbMaSTK.Text = "CMND / Mã STK";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(458, 506);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(335, 506);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(108, 29);
            this.btnGui.TabIndex = 6;
            this.btnGui.Text = "Thực hiện";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtTienGui
            // 
            this.txtTienGui.Location = new System.Drawing.Point(335, 363);
            this.txtTienGui.Name = "txtTienGui";
            this.txtTienGui.Size = new System.Drawing.Size(225, 29);
            this.txtTienGui.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(213, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gửi tiền tiết kiệm có kỳ hạn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvSTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(647, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 624);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin sổ tiết kiểm";
            // 
            // dgvSTK
            // 
            this.dgvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSTK,
            this.HoTen,
            this.LoaiTK,
            this.LaiSuat,
            this.BatDau,
            this.DaoHan,
            this.SoDu});
            this.dgvSTK.Location = new System.Drawing.Point(32, 199);
            this.dgvSTK.Name = "dgvSTK";
            this.dgvSTK.RowHeadersVisible = false;
            this.dgvSTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSTK.Size = new System.Drawing.Size(670, 200);
            this.dgvSTK.TabIndex = 0;
            this.dgvSTK.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSTK_RowsAdded);
            // 
            // MaSTK
            // 
            this.MaSTK.HeaderText = "Mã STK";
            this.MaSTK.Name = "MaSTK";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // LoaiTK
            // 
            this.LoaiTK.HeaderText = "Loại TK";
            this.LoaiTK.Name = "LoaiTK";
            this.LoaiTK.Width = 200;
            // 
            // LaiSuat
            // 
            this.LaiSuat.HeaderText = "Lãi suất";
            this.LaiSuat.Name = "LaiSuat";
            // 
            // BatDau
            // 
            this.BatDau.HeaderText = "Bắt đầu";
            this.BatDau.Name = "BatDau";
            // 
            // DaoHan
            // 
            this.DaoHan.HeaderText = "Đáo hạn";
            this.DaoHan.Name = "DaoHan";
            // 
            // SoDu
            // 
            this.SoDu.HeaderText = "Số dư";
            this.SoDu.Name = "SoDu";
            // 
            // lbTienGui
            // 
            this.lbTienGui.AutoSize = true;
            this.lbTienGui.Location = new System.Drawing.Point(116, 370);
            this.lbTienGui.Name = "lbTienGui";
            this.lbTienGui.Size = new System.Drawing.Size(122, 22);
            this.lbTienGui.TabIndex = 1;
            this.lbTienGui.Text = "Nhập tiền gửi";
            // 
            // lbNhapCMND
            // 
            this.lbNhapCMND.AutoSize = true;
            this.lbNhapCMND.Location = new System.Drawing.Point(116, 199);
            this.lbNhapCMND.Name = "lbNhapCMND";
            this.lbNhapCMND.Size = new System.Drawing.Size(110, 22);
            this.lbNhapCMND.TabIndex = 0;
            this.lbNhapCMND.Text = "Loại tra cứu";
            // 
            // FormGuiTienThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 624);
            this.Controls.Add(this.panel1);
            this.Name = "FormGuiTienThu";
            this.Text = "FormGuiTienThu";
            this.Load += new System.EventHandler(this.FormGuiTienThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTienGui;
        private System.Windows.Forms.Label lbNhapCMND;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTienGui;
        private System.Windows.Forms.DataGridView dgvSTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lbMaSTK;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lbNgayDH;
        private System.Windows.Forms.TextBox txtNgayBD;
        private System.Windows.Forms.Label lbNgayBD;
        private System.Windows.Forms.TextBox txtNgayDH;
        private System.Windows.Forms.Label lblLoi;
        private System.Windows.Forms.ComboBox cbxLoaiTraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaiSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaoHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDu;
    }
}