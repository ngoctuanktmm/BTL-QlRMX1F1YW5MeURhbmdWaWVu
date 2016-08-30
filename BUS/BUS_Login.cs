using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login dal_Login = new DAL_Login();

        public int getLogin(string user, string password)
        {
            return dal_Login.getLogin(user, password);
        }

        public bool createAccount(string maDV)
        {
            return dal_Login.createAccount(maDV);
        }
    }
}
