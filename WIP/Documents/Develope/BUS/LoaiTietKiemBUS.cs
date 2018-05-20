using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DAO;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.BUS
{
    public class LoaiTietKiemBUS // T nhớ là 1 table sẽ tạo 1 DAO & 1 BUS tương ứng nhé
    {
        LoaiTietKiemDAO dao = new LoaiTietKiemDAO();

        public List<LOAITK> layLoaiTK()
        {
            return dao.layLoaiTK();
        }

        public LOAITK timLoaiTK(string tenloai)
        {
            return dao.timLoaiTK(tenloai);
        }

        public void suaLoaiTK(string MaLoai)
        {
            try
            {
                dao.suaLoaiTK(MaLoai);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
