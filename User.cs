using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class User
    {
        public String u_name = "Sirisha";
        public String pswd = "Sirisha@123";


        public int Autherizing(String username, String password)
        {
            if ((username == u_name) && (password == pswd))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}