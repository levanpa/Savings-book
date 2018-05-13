using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DAO;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO dao = new KhachHangDAO();

        public void themKH(KHACHHANG kh)
        {
            try
            {
                dao.themKH(kh);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
