using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication9.BUS;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.GUI
{
    public partial class FormGuiTienThu : Form
    {
        SoTietKiemBUS busSTK = new SoTietKiemBUS();

        public FormGuiTienThu()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (dgvSTK.Rows.Count > 0) // User đã click "Kiểm tra" và có dữ liệu phù hợp
            {
                STK stk = busSTK.timSTK(dgvSTK.CurrentRow.Cells["MaSTK"].Value.ToString());
                stk.NGAYBD = DateTime.ParseExact(txtNgayBD.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                
                switch (stk.MALOAITK.Trim())
                {
                    case "LTK01":
                        stk.SODU += double.Parse(txtTienGui.Text) + stk.SODU * stk.LOAITK.LAISUAT * 3;
                        break;
                    case "LTK02":
                        stk.SODU += double.Parse(txtTienGui.Text) + stk.SODU * stk.LOAITK.LAISUAT * 6;
                        break;
                    case "LTK03":
                        stk.SODU += double.Parse(txtTienGui.Text) + stk.SODU * stk.LOAITK.LAISUAT * 12;
                        break;
                }

                busSTK.suaSTK(stk.MASTK);
                MessageBox.Show("Gửi tiền thành công");
                dgvSTK.Rows.Clear();
                btnKiemTra_Click(sender, e);
            }
            else
                lblLoi.Visible = true;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            dgvSTK.Rows.Clear();

            if (!string.IsNullOrEmpty(txtTuKhoa.Text))
            {
                if (cbxLoaiTraCuu.Text.Equals("CMND"))  // 1 CMND có nhiều STK
                {
                    foreach(STK stk in busSTK.layDsSTK())
                    {
                        if (stk.KHACHHANG.CMND.Equals(txtTuKhoa.Text.Trim()))
                            dgvSTK.Rows.Add(stk.MASTK, stk.KHACHHANG.HOTEN, stk.LOAITK.TENLOAI, stk.LOAITK.LAISUAT, stk.NGAYBD, stk.NGAYDH, stk.SODU);
                    }
                }
                else  // 1 Mã STK chỉ thuộc về 1 STK
                {
                    STK stk = busSTK.timSTK(txtTuKhoa.Text.Trim());
                    dgvSTK.Rows.Add(stk.MASTK, stk.KHACHHANG.HOTEN, stk.LOAITK.TENLOAI, stk.LOAITK.LAISUAT, stk.NGAYBD, stk.NGAYDH, stk.SODU);
                }

                if(dgvSTK.Rows.Count == 0)
                {
                    lblLoi.Text = "Tài khoản không tồn tại !";
                    lblLoi.Visible = true;
                }
            }
            else
            {
                lblLoi.Text = "Bạn chưa nhập từ khóa !";
                lblLoi.Visible = true;
            }
        }

        private void FormGuiTienThu_Load(object sender, EventArgs e)
        {
            dgvSTK.AutoGenerateColumns = false;
            dgvSTK.AllowUserToAddRows = false;
        }

        private void dgvSTK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblLoi.Visible = false;
        }
    }
}
