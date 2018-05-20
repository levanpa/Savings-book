using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DAO;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.BUS
{
    public class SoTietKiemBUS
    {
        SoTietKiemDAO dao = new SoTietKiemDAO();

        public void themSTK(STK stk)
        {
            try
            {
                dao.themSTK(stk);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public List<STK> layDsSTK()
        {
            dao = new SoTietKiemDAO();
            return dao.layDsSTK();
        }

        // Cập nhật STK
        public void suaSTK(string MaSTK)
        {
            try
            {
                dao.suaSTK(MaSTK);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Tìm STK theo MaSTK, đặt đại tên này để phân biệt 2 cái tìm nhé
        public STK timSTK(string MaSTK)
        {
            return dao.timSTK(MaSTK);
        }
    }
}
