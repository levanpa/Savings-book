﻿namespace WindowsFormsApplication9.GUI
{
    partial class FormNhapRutLai
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblLoi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.lblLoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTiep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 256);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(104, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng nhập rút lãi";
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(122, 167);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(116, 32);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp theo";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập số CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(200, 96);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(185, 29);
            this.txtCMND.TabIndex = 6;
            // 
            // lblLoi
            // 
            this.lblLoi.AutoSize = true;
            this.lblLoi.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoi.Location = new System.Drawing.Point(42, 136);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(181, 18);
            this.lblLoi.TabIndex = 9;
            this.lblLoi.Text = "Số CMND không tồn tại !";
            this.lblLoi.Visible = false;
            // 
            // FormNhapRutLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 256);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhapRutLai";
            this.Text = "FormNhapRutLai";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblLoi;
    }
}