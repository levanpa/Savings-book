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

    public partial class DangNhap : Form
    {
        TaiKhoanBUS bus = new TaiKhoanBUS();
        public DangNhap()
        {
            InitializeComponent();

        }
       
            private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (var ac in bus.layaccount())
            {
                if( ac.TAIKHOAN == txtTAIKHOAN.Text)
                {
                    if (ac.MATKHAU == txtMATKHAU.Text)
                    {
                        //MessageBox.Show("Ban co the truy cap!", "Login");
                        new Quanlysotietkiem().ShowDialog();
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        loi.Text = "Sai mat khau";
                        loi.Visible = true;
                    }
                }
                else
                {
                    loi.Text = "Tai khoan khong ton tai";
                    loi.Visible = true;
                }
            }
        }

        private void txtMATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loi_Click(object sender, EventArgs e)
        {

        }
    }
}
