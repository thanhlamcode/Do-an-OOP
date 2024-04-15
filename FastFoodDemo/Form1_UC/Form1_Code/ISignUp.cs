using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Form1_UC.Form1_Code
{
    internal interface ISignUp
    {
        bool Validate_SignUp(string id, string password);
        void SignUp_ToWriteFile(string id, string username, string password);
    }
}
