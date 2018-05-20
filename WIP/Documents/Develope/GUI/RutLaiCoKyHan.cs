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
    public partial class RutLaiCoKyHan : Form
    {
        string cmnd = "";
        SoTietKiemBUS busSTK = new SoTietKiemBUS();

        public RutLaiCoKyHan(string cmnd)
        {
            InitializeComponent();
            this.cmnd = cmnd;
        }

        private void btnRutLai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rút lãi thành công !");
        }

        private void RutLaiCoKyHan_Load(object sender, EventArgs e)
        {
            foreach(STK stk in busSTK.layDsSTK())
            {
                if (stk.KHACHHANG.CMND.Equals(this.cmnd))
                    cbxMaSTK.Items.Add(stk.MASTK);
            }
        }

        private void cbxMaSTK_TextChanged(object sender, EventArgs e)
        {
            STK stk = busSTK.timSTK(cbxMaSTK.Text.Trim());

            txtLoaiTK.Text = stk.LOAITK.TENLOAI;
            txtLaiSuat.Text = stk.LOAITK.LAISUAT.ToString();
            txtHoTen.Text = stk.KHACHHANG.HOTEN;

            switch (stk.MALOAITK.Trim())
            {
                case "LTK01":
                    txtTongLai.Text =  (stk.SODU * stk.LOAITK.LAISUAT * 3).ToString();
                    break;
                case "LTK02":
                    txtTongLai.Text = (stk.SODU * stk.LOAITK.LAISUAT * 6).ToString();
                    break;
                case "LTK03":
                    txtTongLai.Text = (stk.SODU * stk.LOAITK.LAISUAT * 12).ToString();
                    break;
                default:    // Không kỳ hạn
                    txtTongLai.Text = "";
                    break;
            }
        }
    }
}
