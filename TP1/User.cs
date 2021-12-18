using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class User
    {
        public string _username;
        public string _password;

        public string Username
        {
            set { _username = value; }
            get { return _username; }
        }

        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
    }
}
