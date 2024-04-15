using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Form1_UC.Form1_Code
{
    internal interface ILogin
    {
        bool Validate_Login(string id, string password);
        void Write_ToLoginHistory(string id);
    }
}
