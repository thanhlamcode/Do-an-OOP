using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FastFoodDemo.Form2_UC.Form2_Code
{
    public class ThuNgan
    {
        private IEmployee _employee;

        public ThuNgan(IEmployee employee)
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
        public void IsProfit()
        {
            _employee.BaoCaoDoanhThu();
        }
        public void IsXuatHang()
        {
            _employee.XuatHang();
        }
        public void IsNhapHang()
        {
            _employee.NhapHang();
        }
        public void IsQLKH()
        {
            _employee.QLKH();
        }

        public void IsQLNV()
        {
            _employee._QLNV();
        }

        public void IsQLDH()
        {
            _employee.QLDH();
        }
    }
}
