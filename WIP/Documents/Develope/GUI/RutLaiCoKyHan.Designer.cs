namespace WindowsFormsApplication9.GUI
{
    partial class RutLaiCoKyHan
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.lbLaiSuat = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRutLai = new System.Windows.Forms.Button();
            this.txtTongLai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMaSTK = new System.Windows.Forms.ComboBox();
            this.lbTenLoai = new System.Windows.Forms.Label();
            this.txtNgayGD = new System.Windows.Forms.TextBox();
            this.lbNgayGD = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaSTK = new System.Windows.Forms.Label();
            this.lbRutLai = new System.Windows.Forms.Label();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.txtLoaiTK);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtLaiSuat);
            this.panel1.Controls.Add(this.lbLaiSuat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnRutLai);
            this.panel1.Controls.Add(this.txtTongLai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxMaSTK);
            this.panel1.Controls.Add(this.lbTenLoai);
            this.panel1.Controls.Add(this.txtNgayGD);
            this.panel1.Controls.Add(this.lbNgayGD);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.lbMaSTK);
            this.panel1.Controls.Add(this.lbRutLai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 710);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(446, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Location = new System.Drawing.Point(273, 255);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.Size = new System.Drawing.Size(167, 29);
            this.txtLaiSuat.TabIndex = 15;
            // 
            // lbLaiSuat
            // 
            this.lbLaiSuat.AutoSize = true;
            this.lbLaiSuat.Location = new System.Drawing.Point(145, 262);
            this.lbLaiSuat.Name = "lbLaiSuat";
            this.lbLaiSuat.Size = new System.Drawing.Size(75, 22);
            this.lbLaiSuat.TabIndex = 14;
            this.lbLaiSuat.Text = "Lãi suất";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(380, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 30);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnRutLai
            // 
            this.btnRutLai.Location = new System.Drawing.Point(273, 410);
            this.btnRutLai.Name = "btnRutLai";
            this.btnRutLai.Size = new System.Drawing.Size(92, 30);
            this.btnRutLai.TabIndex = 12;
            this.btnRutLai.Text = "Rút Lãi";
            this.btnRutLai.UseVisualStyleBackColor = true;
            this.btnRutLai.Click += new System.EventHandler(this.btnRutLai_Click);
            // 
            // txtTongLai
            // 
            this.txtTongLai.Location = new System.Drawing.Point(273, 309);
            this.txtTongLai.Name = "txtTongLai";
            this.txtTongLai.Size = new System.Drawing.Size(210, 29);
            this.txtTongLai.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền lãi";
            // 
            // cbxMaSTK
            // 
            this.cbxMaSTK.FormattingEnabled = true;
            this.cbxMaSTK.Location = new System.Drawing.Point(273, 145);
            this.cbxMaSTK.Name = "cbxMaSTK";
            this.cbxMaSTK.Size = new System.Drawing.Size(129, 30);
            this.cbxMaSTK.TabIndex = 9;
            this.cbxMaSTK.TextChanged += new System.EventHandler(this.cbxMaSTK_TextChanged);
            // 
            // lbTenLoai
            // 
            this.lbTenLoai.AutoSize = true;
            this.lbTenLoai.Location = new System.Drawing.Point(145, 206);
            this.lbTenLoai.Name = "lbTenLoai";
            this.lbTenLoai.Size = new System.Drawing.Size(82, 22);
            this.lbTenLoai.TabIndex = 7;
            this.lbTenLoai.Text = "Tên loại ";
            // 
            // txtNgayGD
            // 
            this.txtNgayGD.Location = new System.Drawing.Point(775, 203);
            this.txtNgayGD.Name = "txtNgayGD";
            this.txtNgayGD.Size = new System.Drawing.Size(188, 29);
            this.txtNgayGD.TabIndex = 6;
            // 
            // lbNgayGD
            // 
            this.lbNgayGD.AutoSize = true;
            this.lbNgayGD.Location = new System.Drawing.Point(604, 210);
            this.lbNgayGD.Name = "lbNgayGD";
            this.lbNgayGD.Size = new System.Drawing.Size(134, 22);
            this.lbNgayGD.TabIndex = 5;
            this.lbNgayGD.Text = "Ngày giao dịch";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(775, 145);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(188, 29);
            this.txtHoTen.TabIndex = 4;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(604, 153);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(89, 22);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // lbMaSTK
            // 
            this.lbMaSTK.AutoSize = true;
            this.lbMaSTK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSTK.Location = new System.Drawing.Point(145, 153);
            this.lbMaSTK.Name = "lbMaSTK";
            this.lbMaSTK.Size = new System.Drawing.Size(78, 22);
            this.lbMaSTK.TabIndex = 1;
            this.lbMaSTK.Text = "Mã STK";
            // 
            // lbRutLai
            // 
            this.lbRutLai.AutoSize = true;
            this.lbRutLai.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutLai.ForeColor = System.Drawing.Color.Navy;
            this.lbRutLai.Location = new System.Drawing.Point(472, 35);
            this.lbRutLai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRutLai.Name = "lbRutLai";
            this.lbRutLai.Size = new System.Drawing.Size(192, 27);
            this.lbRutLai.TabIndex = 0;
            this.lbRutLai.Text = "Rút lãi có kỳ hạn";
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Location = new System.Drawing.Point(273, 203);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.Size = new System.Drawing.Size(188, 29);
            this.txtLoaiTK.TabIndex = 23;
            // 
            // RutLaiCoKyHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 710);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RutLaiCoKyHan";
            this.Text = "RutLaiCoKyHan";
            this.Load += new System.EventHandler(this.RutLaiCoKyHan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMaSTK;
        private System.Windows.Forms.Label lbRutLai;
        private System.Windows.Forms.Label lbTenLoai;
        private System.Windows.Forms.TextBox txtNgayGD;
        private System.Windows.Forms.Label lbNgayGD;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.ComboBox cbxMaSTK;
        private System.Windows.Forms.Button btnRutLai;
        private System.Windows.Forms.TextBox txtTongLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtLaiSuat;
        private System.Windows.Forms.Label lbLaiSuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLoaiTK;
    }
}