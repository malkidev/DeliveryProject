using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Model
{
    class LoginModel
    {
        public string identifier { get; set; }
        public string password { get; set; }

        internal bool CheckPassword()
        {
            if (identifier=="sabenzaq" && password == "1234")
                return true;
            return false;
        }
    }
}

