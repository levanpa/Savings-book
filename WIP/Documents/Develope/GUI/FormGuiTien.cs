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
    public partial class FormGuiTien : Form
    {
        SoTietKiemBUS busSTK = new SoTietKiemBUS();

        public FormGuiTien()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            STK stk = busSTK.timSTK(txtCMND.Text.Trim());

            if (stk != null)
            {   // Mình chưa bắt lỗi ô CMND bị bỏ trống nhé
                this.Hide();
               // new GuiTietKiemCoKyHan(stk.MASTK).ShowDialog();  // Truyền MaTK vào form mới
                this.Close();
            }
            else
            {
                //lblError.Visible = true;
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
