using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.DAO
{
    public class TaiKhoanDAO
    {
        QuanLySoTietKiemEntities db;
        public List<ACCOUNT>layaccount()
        {
            db = new QuanLySoTietKiemEntities();
            return db.ACCOUNTs.ToList();
        }
       
    }
}
