﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication9.DAO;
using WindowsFormsApplication9.DTO;

namespace WindowsFormsApplication9.BUS
{
    public class ACCOUNT_BUS
    {
        ACCOUNT_DAO dao = new ACCOUNT_DAO();
        public List<ACCOUNT>layaccount()
        {
            return dao.layaccount();
        }

    }
}