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
    public partial class FormNhapRutLai : Form
    {
        KhachHangBUS busKH = new KhachHangBUS();

        public FormNhapRutLai()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = busKH.timKH(txtCMND.Text.Trim());

            if (kh != null)
            {
                this.Hide();
                new RutLaiCoKyHan(kh.CMND).ShowDialog();
                this.Close();
            }
            else  // Chua rang buoc de trong o CMND
                lblLoi.Visible = true;
        }
    }
}
