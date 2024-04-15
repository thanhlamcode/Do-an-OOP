using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Form2_UC.Form2_Code
{
    internal class BaoVe
    {
        private IEmployee _employee;

        public BaoVe(IEmployee employee)
        {
            _employee = employee;
        }

        public void IsDoiMK()
        {
            _employee.DoiMatKhau();
        }

        public void IsLoginHistory()
        {
            _employee.LichSuDangNhap();
        }

        public void IsProblem()
        {
            _employee.BaoCaoVanDe();
        }
    }
}
