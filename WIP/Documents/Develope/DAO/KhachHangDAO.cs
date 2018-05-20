using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.DAO
{
    public class KhachHangDAO
    {
        QuanLySoTietKiemEntities db = new QuanLySoTietKiemEntities();

        public void themKH(KHACHHANG kh)
        {
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e; // Bao loi neu them KH that bai
            }
        }

        // Tìm KH theo CMND
        public KHACHHANG timKH(string cmnd)
        {
            try
            {
                return db.KHACHHANGs.SingleOrDefault(x => x.CMND.Equals(cmnd));
            }
            catch
            {
                return null;
            }
        }
    }
}
