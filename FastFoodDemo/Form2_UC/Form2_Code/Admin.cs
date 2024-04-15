using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Form2_UC.Form2_Code
{
    public class Admin
    {
        private IEmployee _employee;

        public Admin(IEmployee employee)
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
        public void IsQLNV()
        {
            _employee._QLNV();
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
        public void IsQLDH()
        {
            _employee.QLDH();
        }
        public void IsReturnManagement()
        {
            _employee.QuanLyDoiTra();
        }
        public void IsSupportService()
        {
            _employee.QuanLyDichVuHoTro();
        }
        public void IsPromotionManagement()
        {
            _employee.QuanLyKhuyenMai();
        }
    }
}
