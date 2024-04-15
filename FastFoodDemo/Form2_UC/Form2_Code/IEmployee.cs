using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Form2_UC.Form2_Code
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Ten { get; set; }
        string Password { get; set; }
        string QuyenTruyCap { get; set; }
        DateTime NgayVaoLam { get; set; }

        void DoiMatKhau();
        void LichSuDangNhap();
        void BaoCaoVanDe();
        void BaoCaoDoanhThu();
        void _QLNV();
        void XuatHang();
        void NhapHang();
        void QLKH();
        void QLDH();
        void QuanLyDoiTra();
        void QuanLyDichVuHoTro();
        void QuanLyKhuyenMai();
    }
}
