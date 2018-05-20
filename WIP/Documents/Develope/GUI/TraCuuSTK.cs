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
    public partial class TraCuuSTK : Form
    {
        SoTietKiemBUS busSTK = new SoTietKiemBUS();

        public TraCuuSTK()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {


            if (txtNhapCMND.Text.Equals("CMND"))  // 1 CMND có nhiều STK
            {
                foreach (STK stk in busSTK.layDsSTK())
                {
                    if (stk.KHACHHANG.CMND.Equals(txtNhapCMND.Text.Trim()))
                        dgvSTK.Rows.Add(stk.KHACHHANG.HOTEN, stk.LOAITK.TENLOAI, stk.LOAITK.LAISUAT, stk.NGAYBD, stk.NGAYDH, stk.SODU, stk.MASTK);
                }
            }

        }
    }
}
