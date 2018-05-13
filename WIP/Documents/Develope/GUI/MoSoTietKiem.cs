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
    public partial class MoSoTietKiem : Form
    {
        KhachHangBUS busKH = new KhachHangBUS();
        SoTietKiemBUS busSTK = new SoTietKiemBUS();
        private object dataGridView1;
       // private object dgvtSTK;

        public DateTime StartTime { get; private set; }

        public MoSoTietKiem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime StartTime = new DateTime(2000, 1, 1);

            KHACHHANG kh = new KHACHHANG();
            TimeSpan key = DateTime.Now - StartTime;
            kh.MAKH = "KH" + key.TotalMilliseconds.ToString().Substring(4,8);
            kh.HOTEN = txtHoTen.Text;
            kh.DIACHI = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            kh.NGAYSINH = DateTime.ParseExact(txtNgaySinh.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            kh.CMND = txtCMND.Text;
            if (rdbNam.Checked)
            {
                kh.GIOITINH = "Nam";
            }
            if (rdbNu.Checked)
            {
                kh.GIOITINH = "Nữ";
            }
            busKH.themKH(kh);

            STK stk = new STK();
            stk.MASTK = "STK" + key.TotalMilliseconds.ToString().Substring(4, 7);
            stk.MAKH = kh.MAKH;
            stk.NGAYMO = DateTime.ParseExact(txtNgayMo.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            stk.NGAYBD = DateTime.ParseExact(txtNgayBD.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            stk.SODU = 0; // Thêm mới
            
            switch (cbxLoaiTK.Text)
            {
                case "Tiết kiệm có kỳ hạn 3 tháng":
                    stk.MALOAITK = "LTK01";
                    stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "Tiết kiệm có kỳ hạn 6 tháng":
                    stk.MALOAITK = "LTK02";
                    stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "Tiết kiệm có kỳ hạn 12 tháng":
                    stk.MALOAITK = "LTK04";
                    stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "Tiết kiệm không kỳ hạn":
                    stk.MALOAITK = "LTK03";
                    break;
                default:
                    stk.MALOAITK = "LTK03"; // Mặc định
                    break;
            }

            busSTK.themSTK(stk);
            MessageBox.Show("Thêm STK thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuiTien_Click(object sender, EventArgs e)
        {
            DateTime StartTime = new DateTime(2000, 1, 1);

            KHACHHANG kh = new KHACHHANG();
            TimeSpan key = DateTime.Now - StartTime;
            kh.MAKH = "KH" + key.TotalMilliseconds.ToString().Substring(4, 8);
            kh.HOTEN = txtHoTen.Text;
            kh.DIACHI = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            kh.NGAYSINH = DateTime.ParseExact(txtNgaySinh.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            kh.CMND = txtCMND.Text;

            //if (ckbNam.Checked)
            //    kh.GIOITINH = "Nam";
            //else if (ckbNu.Checked)
            //    kh.GIOITINH = "Nữ";
            if(rdbNam.Checked)
            {
                kh.GIOITINH = "Nam";
            }
            if(rdbNu.Checked)
            {
                kh.GIOITINH = "Nữ";
            }
            busKH.themKH(kh);

            STK stk = new STK();
            stk.MASTK = "STK" + key.TotalMilliseconds.ToString().Substring(4, 7);
            stk.MAKH = kh.MAKH;
            stk.NGAYMO = DateTime.ParseExact(txtNgayMo.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            stk.NGAYBD = DateTime.ParseExact(txtNgayBD.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
            stk.SODU = decimal.Parse(txtSoDu.Text);
         
         
            switch (cbxLoaiTK.Text)
            {
                case "Tiết kiệm có kỳ hạn 3 tháng":
                    stk.MALOAITK = "LTK01";
                    stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "Tiết kiệm có kỳ hạn 6 tháng":
                    stk.MALOAITK = "LTK02";
                    stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "Tiết kiệm có kỳ hạn 12 tháng":
                    stk.MALOAITK = "LTK04";
                    stk.NGAYDH = DateTime.ParseExact(txtNgayDH.Text, "dd/M/yyyy", CultureInfo.InvariantCulture);
                    break;
                case "Tiết kiệm không kỳ hạn":
                    stk.MALOAITK = "LTK03";
                    break;
                default:
                    stk.MALOAITK = "LTK03"; // Mặc định
                    break;
            }

            busSTK.themSTK(stk);
            MessageBox.Show("Gửi tiền thành công");

        }
        
        private void cbxLoaiTK_TextChanged(object sender, EventArgs e)
        {
            
            switch (cbxLoaiTK.Text)
            {
                case "Tiết kiệm có kỳ hạn 3 tháng":
                    txtLaiSuat.Text = "1";
                    break;
                case "Tiết kiệm có kỳ hạn 6 tháng": 
                    txtLaiSuat.Text = "2";
                    break;
                case "Tiết kiệm có kỳ hạn 12 tháng":
                    txtLaiSuat.Text = "3";
                    break;
                case "Tiết kiệm không kỳ hạn":
                    txtLaiSuat.Text = "4";
                    break;
                default:
                    txtLaiSuat.Text = "4";
                    break;
            }
          
           
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgvSTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
           
        }

        private void MoSoTietKiem_Load_1(object sender, EventArgs e)
        {
            busSTK = new SoTietKiemBUS();
            dtgvSTK.DataSource = busSTK.layDsSTK();
        }
    }
}
