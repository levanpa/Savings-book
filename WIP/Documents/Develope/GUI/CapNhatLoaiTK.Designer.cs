namespace WindowsFormsApplication9.GUI
{
    partial class CapNhatLoaiTK
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
            this.lblLoi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLoaiTK = new System.Windows.Forms.DataGridView();
            this.lbBangLoaiTK = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.cbxTenLoai = new System.Windows.Forms.ComboBox();
            this.lbCapNhat = new System.Windows.Forms.Label();
            this.lbChonLoaiTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtLaiSuat);
            this.panel1.Controls.Add(this.cbxTenLoai);
            this.panel1.Controls.Add(this.lbCapNhat);
            this.panel1.Controls.Add(this.lbChonLoaiTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblLoi
            // 
            this.lblLoi.AutoSize = true;
            this.lblLoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoi.Location = new System.Drawing.Point(351, 356);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(237, 22);
            this.lblLoi.TabIndex = 27;
            this.lblLoi.Text = "Bạn chưa nhập lãi suất mới";
            this.lblLoi.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLoaiTK);
            this.panel2.Controls.Add(this.lbBangLoaiTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(667, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 749);
            this.panel2.TabIndex = 26;
            // 
            // dgvLoaiTK
            // 
            this.dgvLoaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTK.Location = new System.Drawing.Point(139, 248);
            this.dgvLoaiTK.Name = "dgvLoaiTK";
            this.dgvLoaiTK.Size = new System.Drawing.Size(458, 178);
            this.dgvLoaiTK.TabIndex = 1;
            this.dgvLoaiTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbBangLoaiTK
            // 
            this.lbBangLoaiTK.AutoSize = true;
            this.lbBangLoaiTK.Location = new System.Drawing.Point(273, 189);
            this.lbBangLoaiTK.Name = "lbBangLoaiTK";
            this.lbBangLoaiTK.Size = new System.Drawing.Size(164, 22);
            this.lbBangLoaiTK.TabIndex = 0;
            this.lbBangLoaiTK.Text = "Thông tin cập nhật";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(469, 399);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 28);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(351, 399);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 28);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(546, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.Location = new System.Drawing.Point(351, 310);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.Size = new System.Drawing.Size(170, 29);
            this.txtLaiSuat.TabIndex = 4;
            // 
            // cbxTenLoai
            // 
            this.cbxTenLoai.FormattingEnabled = true;
            this.cbxTenLoai.Items.AddRange(new object[] {
            "Tiet kiem co ky han 3 thang",
            "Tiet kiem co ky han 6 thang",
            "Tiet kiem co ky han 12 thang",
            "Tiet kiem khong ky han"});
            this.cbxTenLoai.Location = new System.Drawing.Point(351, 248);
            this.cbxTenLoai.Name = "cbxTenLoai";
            this.cbxTenLoai.Size = new System.Drawing.Size(232, 30);
            this.cbxTenLoai.TabIndex = 3;
            this.cbxTenLoai.Text = "Tiet kiem co ky han 3 thang";
            // 
            // lbCapNhat
            // 
            this.lbCapNhat.AutoSize = true;
            this.lbCapNhat.Location = new System.Drawing.Point(169, 317);
            this.lbCapNhat.Name = "lbCapNhat";
            this.lbCapNhat.Size = new System.Drawing.Size(112, 22);
            this.lbCapNhat.TabIndex = 2;
            this.lbCapNhat.Text = "Lãi suất mới";
            // 
            // lbChonLoaiTK
            // 
            this.lbChonLoaiTK.AutoSize = true;
            this.lbChonLoaiTK.Location = new System.Drawing.Point(169, 249);
            this.lbChonLoaiTK.Name = "lbChonLoaiTK";
            this.lbChonLoaiTK.Size = new System.Drawing.Size(119, 22);
            this.lbChonLoaiTK.TabIndex = 1;
            this.lbChonLoaiTK.Text = "Chọn loại TK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(259, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật loại tiết kiệm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CapNhatLoaiTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CapNhatLoaiTK";
            this.Text = "CapNhatLoaiTK";
            this.Load += new System.EventHandler(this.CapNhatLoaiTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCapNhat;
        private System.Windows.Forms.Label lbChonLoaiTK;
        private System.Windows.Forms.TextBox txtLaiSuat;
        private System.Windows.Forms.ComboBox cbxTenLoai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLoaiTK;
        private System.Windows.Forms.Label lbBangLoaiTK;
        private System.Windows.Forms.Label lblLoi;
    }
}