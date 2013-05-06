using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Login
    {
        public string Authenticate(string str1,string str2)
        {
            string usertype = "";
            if (str1 == "doctor" && str2 == "doctor")
            {
                return usertype = "doc";

            }
            else
            {
                if (str1 == "staff" && str2 == "staff")
                {
                    return usertype = "staff";

                }
                else
                {
                    return usertype="Invalid User";

                }

            }
           
        }
    }
}
