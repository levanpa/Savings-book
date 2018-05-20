using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication9.BUS;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.GUI
{
    public partial class CapNhatLoaiTK : Form
    {
        LoaiTietKiemBUS busLoaiTK = new LoaiTietKiemBUS();

        public CapNhatLoaiTK()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatLoaiTK_Load(object sender, EventArgs e)
        {
            dgvLoaiTK.DataSource = busLoaiTK.layLoaiTK();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLaiSuat.Text.Trim()))
            {
                LOAITK loaitk = busLoaiTK.timLoaiTK(cbxTenLoai.Text.Trim());
                loaitk.LAISUAT = double.Parse(txtLaiSuat.Text.Trim());

                switch (cbxTenLoai.Text)
                {
                    case "Tiet kiem co ky han 3 thang":
                        busLoaiTK.suaLoaiTK("LTK01");
                        break;
                    case "Tiet kiem co ky han 6 thang":
                        busLoaiTK.suaLoaiTK("LTK02");
                        break;
                    case "Tiet kiem co ky han 12 thang":
                        busLoaiTK.suaLoaiTK("LTK03");
                        break;
                    case "Tiet kiem khong ky han":
                        busLoaiTK.suaLoaiTK("LTK04");
                        break;
                }

                MessageBox.Show("Cập nhật lãi suất thành công");
                dgvLoaiTK.DataSource = busLoaiTK.layLoaiTK();
            }
            else
                lblLoi.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
