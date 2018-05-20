using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.DAO
{
    public class LoaiTietKiemDAO
    {
        QuanLySoTietKiemEntities db = new QuanLySoTietKiemEntities();  // Cái db này chỉ khai báo trong lớp DAO

        public List<LOAITK> layLoaiTK()
        {
            return db.LOAITKs.ToList();
        }

        public LOAITK timLoaiTK(string tenloai)
        {
            try
            {
                return db.LOAITKs.SingleOrDefault(x => x.TENLOAI.Equals(tenloai));
            }
            catch
            {
                return null;
            }
        }

        public void suaLoaiTK(string MaLoai)
        {
            try
            {
                LOAITK loaitk = db.LOAITKs.SingleOrDefault(x => x.MALOAITK.Equals(MaLoai));
                db.Entry(loaitk).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
