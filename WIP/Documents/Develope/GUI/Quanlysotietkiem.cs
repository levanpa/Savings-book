using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication9.GUI;

namespace WindowsFormsApplication9.GUI
{
    public partial class Quanlysotietkiem : Form
    {
        public Quanlysotietkiem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mởSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoSoTietKiem f = new MoSoTietKiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Quanlysotietkiem_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuiKhongKyHan_Click(object sender, EventArgs e)
        {
            GuiTietKiemKhongKyHan f = new GuiTietKiemKhongKyHan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void GuiCoKyHan_Click(object sender, EventArgs e)
        {
            FormGuiTienThu f = new FormGuiTienThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rútLãiCóKỳHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapRutLai f = new FormNhapRutLai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void rútTiềnSổCóKỳHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cậpNhậtLoạiSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CapNhatLoaiTK().ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }

    
}
