using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9.GUI
{
    public partial class FormNhapRutTien : Form
    {
        public FormNhapRutTien()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            GuiTietKiemCoKyHan f = new GuiTietKiemCoKyHan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
