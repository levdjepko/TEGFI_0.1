using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEGFI_1
{
    public class LoginHelper
    {
        public string Username {get; set; }
        public string Password { get; set; }

        public LoginHelper(string username, string password)
        {
            //checks that there's no nulls in name and password, otherwise throws an exception
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}
