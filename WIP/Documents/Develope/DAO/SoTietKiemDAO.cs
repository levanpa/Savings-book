using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.DAO
{
    public class SoTietKiemDAO
    {
        QuanLySoTietKiemEntities db = new QuanLySoTietKiemEntities();
        public List<STK> layDsSTK()
        {
            // Co khai bao QuanlyhocvienEntities la co dung data trong SQL, vi day la tang DAO, con BUS thi khong
            db = new QuanLySoTietKiemEntities();//Chỉ khai báo trong DTO, không khai báo trong ham click button
            return db.STKs.ToList();
        }
        public void themSTK(STK stk)
        {
            try
            {
                db.STKs.Add(stk);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Cập nhật STK
        public void suaSTK(string MaSTK)
        {
            try
            {
                STK stk = db.STKs.SingleOrDefault(x => x.MASTK.Equals(MaSTK));
                db.Entry(stk).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Tìm STK theo MaSTK, đặt đại tên này để phân biệt 2 cái tìm nhé
        public STK timSTK(string MaSTK)
        {
            try
            {
                return db.STKs.SingleOrDefault(x => x.MASTK.Equals(MaSTK));
            }
            catch
            {
                return null;
            }
        }
    }
}
