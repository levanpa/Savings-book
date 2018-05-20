namespace WindowsFormsApplication9.GUI
{
    partial class Quanlysotietkiem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mosotietkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuiKhongKyHan = new System.Windows.Forms.ToolStripMenuItem();
            this.GuiCoKyHan = new System.Windows.Forms.ToolStripMenuItem();
            this.rútTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútTiềnSổCóKỳHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútTiềnSôToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútLãiCóKỳHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútLãiKhôngKỳHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinSổTiếtKiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 43);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mosotietkiem,
            this.gửiTiềnToolStripMenuItem,
            this.rútTiềnToolStripMenuItem,
            this.rútLãiToolStripMenuItem,
            this.traCứuToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Mosotietkiem
            // 
            this.Mosotietkiem.BackColor = System.Drawing.Color.Crimson;
            this.Mosotietkiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mosotietkiem.Image = global::WindowsFormsApplication9.Properties.Resources.images1;
            this.Mosotietkiem.Name = "Mosotietkiem";
            this.Mosotietkiem.Size = new System.Drawing.Size(211, 36);
            this.Mosotietkiem.Text = "Mở sổ tiết kiệm";
            this.Mosotietkiem.Click += new System.EventHandler(this.mởSổTiếtKiệmToolStripMenuItem_Click);
            // 
            // gửiTiềnToolStripMenuItem
            // 
            this.gửiTiềnToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.gửiTiềnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuiKhongKyHan,
            this.GuiCoKyHan});
            this.gửiTiềnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gửiTiềnToolStripMenuItem.Image = global::WindowsFormsApplication9.Properties.Resources.tải_xuống__2_;
            this.gửiTiềnToolStripMenuItem.Name = "gửiTiềnToolStripMenuItem";
            this.gửiTiềnToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.gửiTiềnToolStripMenuItem.Text = "Gửi tiền";
            // 
            // GuiKhongKyHan
            // 
            this.GuiKhongKyHan.Name = "GuiKhongKyHan";
            this.GuiKhongKyHan.Size = new System.Drawing.Size(358, 36);
            this.GuiKhongKyHan.Text = "Gửi tiền sổ không kỳ hạn";
            this.GuiKhongKyHan.Click += new System.EventHandler(this.GuiKhongKyHan_Click);
            // 
            // GuiCoKyHan
            // 
            this.GuiCoKyHan.Name = "GuiCoKyHan";
            this.GuiCoKyHan.Size = new System.Drawing.Size(358, 36);
            this.GuiCoKyHan.Text = "Gửi tiền sổ có kỳ hạn";
            this.GuiCoKyHan.Click += new System.EventHandler(this.GuiCoKyHan_Click);
            // 
            // rútTiềnToolStripMenuItem
            // 
            this.rútTiềnToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.rútTiềnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rútTiềnSổCóKỳHạnToolStripMenuItem,
            this.rútTiềnSôToolStripMenuItem});
            this.rútTiềnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rútTiềnToolStripMenuItem.Image = global::WindowsFormsApplication9.Properties.Resources.images2;
            this.rútTiềnToolStripMenuItem.Name = "rútTiềnToolStripMenuItem";
            this.rútTiềnToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.rútTiềnToolStripMenuItem.Text = "Rút tiền";
            this.rútTiềnToolStripMenuItem.Click += new System.EventHandler(this.rútTiềnToolStripMenuItem_Click);
            // 
            // rútTiềnSổCóKỳHạnToolStripMenuItem
            // 
            this.rútTiềnSổCóKỳHạnToolStripMenuItem.Name = "rútTiềnSổCóKỳHạnToolStripMenuItem";
            this.rútTiềnSổCóKỳHạnToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.rútTiềnSổCóKỳHạnToolStripMenuItem.Text = "Rút tiền sổ có kỳ hạn";
            this.rútTiềnSổCóKỳHạnToolStripMenuItem.Click += new System.EventHandler(this.rútTiềnSổCóKỳHạnToolStripMenuItem_Click);
            // 
            // rútTiềnSôToolStripMenuItem
            // 
            this.rútTiềnSôToolStripMenuItem.Name = "rútTiềnSôToolStripMenuItem";
            this.rútTiềnSôToolStripMenuItem.Size = new System.Drawing.Size(358, 36);
            this.rútTiềnSôToolStripMenuItem.Text = "Rút tiền sổ không kỳ hạn";
            // 
            // rútLãiToolStripMenuItem
            // 
            this.rútLãiToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.rútLãiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rútLãiCóKỳHạnToolStripMenuItem,
            this.rútLãiKhôngKỳHạnToolStripMenuItem});
            this.rútLãiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rútLãiToolStripMenuItem.Image = global::WindowsFormsApplication9.Properties.Resources.images__1_;
            this.rútLãiToolStripMenuItem.Name = "rútLãiToolStripMenuItem";
            this.rútLãiToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.rútLãiToolStripMenuItem.Text = "Rút lãi";
            // 
            // rútLãiCóKỳHạnToolStripMenuItem
            // 
            this.rútLãiCóKỳHạnToolStripMenuItem.Name = "rútLãiCóKỳHạnToolStripMenuItem";
            this.rútLãiCóKỳHạnToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.rútLãiCóKỳHạnToolStripMenuItem.Text = "Rút lãi sổ có kỳ hạn";
            this.rútLãiCóKỳHạnToolStripMenuItem.Click += new System.EventHandler(this.rútLãiCóKỳHạnToolStripMenuItem_Click);
            // 
            // rútLãiKhôngKỳHạnToolStripMenuItem
            // 
            this.rútLãiKhôngKỳHạnToolStripMenuItem.Name = "rútLãiKhôngKỳHạnToolStripMenuItem";
            this.rútLãiKhôngKỳHạnToolStripMenuItem.Size = new System.Drawing.Size(341, 36);
            this.rútLãiKhôngKỳHạnToolStripMenuItem.Text = "Rút lãi sổ không kỳ hạn";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traCứuThôngTinSổTiếtKiểmToolStripMenuItem,
            this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem});
            this.traCứuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuToolStripMenuItem.Image = global::WindowsFormsApplication9.Properties.Resources.tải_xuống__3_;
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.traCứuToolStripMenuItem.Text = "Tra cứu";
            // 
            // traCứuThôngTinSổTiếtKiểmToolStripMenuItem
            // 
            this.traCứuThôngTinSổTiếtKiểmToolStripMenuItem.Name = "traCứuThôngTinSổTiếtKiểmToolStripMenuItem";
            this.traCứuThôngTinSổTiếtKiểmToolStripMenuItem.Size = new System.Drawing.Size(405, 36);
            this.traCứuThôngTinSổTiếtKiểmToolStripMenuItem.Text = "Tra cứu thông tin sổ tiết kiểm";
            // 
            // cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem
            // 
            this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem.Name = "cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem";
            this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(405, 36);
            this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem.Text = "Cập nhật loại sổ tiết kiệm";
            this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.báoCáoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.báoCáoToolStripMenuItem.Image = global::WindowsFormsApplication9.Properties.Resources.tải_xuống__1_1;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApplication9.Properties.Resources._32939031_1031664010305350_7788098935532290048_n;
            this.pictureBox2.Location = new System.Drawing.Point(0, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1206, 434);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.tải_xuống__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quanlysotietkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1206, 477);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Quanlysotietkiem";
            this.Text = "Quản lý sổ tiết kiệm";
            this.Load += new System.EventHandler(this.Quanlysotietkiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mosotietkiem;
        private System.Windows.Forms.ToolStripMenuItem gửiTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútTiềnSổCóKỳHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútTiềnSôToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútLãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútLãiCóKỳHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútLãiKhôngKỳHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinSổTiếtKiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuiKhongKyHan;
        private System.Windows.Forms.ToolStripMenuItem GuiCoKyHan;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}