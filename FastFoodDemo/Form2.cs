using FastFoodDemo.Form2_UC.Form2_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form2 : Form, IEmployee
    {
        #region Variable Form2_UC
        Form2_UC.DoiMatKhau _doiMK = new Form2_UC.DoiMatKhau();
        Form2_UC.LGHistory _lgHistory = new Form2_UC.LGHistory();
        Form2_UC.QLNV qLNV = new Form2_UC.QLNV();
        Form2_UC.BaoCaoVanDe BaoCaoVanDe = new Form2_UC.BaoCaoVanDe();
        Form2_UC.BaoCaoDoanhThu BaoCaoDoanhThu = new Form2_UC.BaoCaoDoanhThu();
        Form2_UC2.Inventory_UC inventory_ = new Form2_UC2.Inventory_UC();
        Form2_UC2.Product_UC product_ = new Form2_UC2.Product_UC();
        Form2_UC3.CustomerManagementForm customer = new Form2_UC3.CustomerManagementForm();
        Form2_UC3.OrderManagementForm order = new Form2_UC3.OrderManagementForm();
        Form2_UC4.Form2_UC4_Code.Return_Management_Form return1 = new Form2_UC4.Form2_UC4_Code.Return_Management_Form();
        Form2_UC4.Form2_UC4_Code.SupportService support = new Form2_UC4.Form2_UC4_Code.SupportService();
        Form2_UC4.Form2_UC4_Code.Promotion_Management promotion = new Form2_UC4.Form2_UC4_Code.Promotion_Management();
        #endregion
        #region Variable Employee
        public int ID { get; set; }
        public string Ten { get; set; }
        public string QuyenTruyCap { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string Password { get; set; }
        #endregion
        private ThuNgan thuNgan;
        private BaoVe baoVe;
        private Admin admin;
        public static string token;
        public Form2()
        {
            InitializeComponent();
            SidePanel.Height = DoiMKbtn.Height;
            SidePanel.Top = DoiMKbtn.Top;
            string[] fields = token.Split(',');
            ID = Convert.ToInt32(fields[0]);
            Password = fields[2];
            Ten = fields[1];
            QuyenTruyCap = fields[3];
        }
        private void LoginHisbtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsLoginHistory();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsLoginHistory();
            }
            else
            {
                baoVe.IsLoginHistory();
            }
        }

        private void DoiMKbtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsDoiMK();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsDoiMK();
            }
            else
            {
                baoVe.IsDoiMK();
            }
        }

        private void Problembtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsProblem();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsProblem();
            }
            else
            {
                baoVe.IsProblem();
            }
        }

        private void Doanhthubtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsProfit();
            }
            else
            {
                thuNgan.IsProfit();
            }
        }

        private void QLNVbtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsQLNV();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsQLNV();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(_doiMK);
            List<Button> buttons = new List<Button>()
            {
                DoiMKbtn,
                LoginHisbtn,
                Problembtn,
                Doanhthubtn,
                XuatHangbtn,
                NhapHangbtn,
                QLNVbtn,
                btnQLKH,
                btnQLDH,
                btnQuanLyDoiTra,
                btnQuanLyDichVuHoTro,
                btnQuanLyKhuyenMai
            };

            if (QuyenTruyCap == "0")
            {
                admin = new Admin(this);
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Visible = true;
                }
            }
            else if (QuyenTruyCap == "1")
            {
                thuNgan = new ThuNgan(this);
                for (int i = 0; i < buttons.Count - 7; i++)
                {
                    buttons[i].Visible = true;
                }
            }
            else
            {
                baoVe = new BaoVe(this);
                for (int i = 0; i < buttons.Count - 9; i++)
                {
                    buttons[i].Visible = true;
                }
            }
        }
        public void DoiMatKhau()
        {
            SidePanel.Height = DoiMKbtn.Height;
            SidePanel.Top = DoiMKbtn.Top;
            Rightpanel.Controls.Clear();
            _doiMK.SetId(ID);
            _doiMK.SetPass(Password);
            Rightpanel.Controls.Add(_doiMK);
        }

        public void LichSuDangNhap()
        {
            SidePanel.Height = LoginHisbtn.Height;
            SidePanel.Top = LoginHisbtn.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(_lgHistory);
        }

        void IEmployee.BaoCaoVanDe()
        {
            SidePanel.Height = Problembtn.Height;
            SidePanel.Top = Problembtn.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(BaoCaoVanDe);
        }

        void IEmployee.BaoCaoDoanhThu()
        {
            SidePanel.Height = Doanhthubtn.Height;
            SidePanel.Top = Doanhthubtn.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(BaoCaoDoanhThu);
        }

        public void _QLNV()
        {
            SidePanel.Height = QLNVbtn.Height;
            SidePanel.Top = QLNVbtn.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(qLNV);
        }

        private void NhapHangbtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsNhapHang();
            }
            if (thuNgan != null)
            {
                thuNgan.IsNhapHang();
            }
        }

        private void XuatHangbtn_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsXuatHang();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsXuatHang();
            }
        }

        public void XuatHang()
        {
            SidePanel.Height = XuatHangbtn.Height;
            SidePanel.Top = XuatHangbtn.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(product_);
        }

        public void NhapHang()
        {
            SidePanel.Height = NhapHangbtn.Height;
            SidePanel.Top = NhapHangbtn.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(inventory_);
        }

        public void QLKH()
        {
            SidePanel.Height = btnQLKH.Height;
            SidePanel.Top = btnQLKH.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(customer);
        }

        public void QLDH()
        {
            SidePanel.Height = btnQLDH.Height;
            SidePanel.Top = btnQLDH.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(order);
        }
        public void QuanLyDoiTra()
        {
            SidePanel.Height = btnQuanLyDoiTra.Height;
            SidePanel.Top = btnQuanLyDoiTra.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(return1);
        }
        public void QuanLyDichVuHoTro()
        {
            SidePanel.Height = btnQuanLyDichVuHoTro.Height;
            SidePanel.Top = btnQuanLyDichVuHoTro.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(support);
        }
        public void QuanLyKhuyenMai()
        {
            SidePanel.Height = btnQuanLyKhuyenMai.Height;
            SidePanel.Top = btnQuanLyKhuyenMai.Top;
            Rightpanel.Controls.Clear();
            Rightpanel.Controls.Add(promotion);
        }
        private void btnQLKH_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsQLKH();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsQLKH();
            }
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsQLDH();
            }
            else if (thuNgan != null)
            {
                thuNgan.IsQLDH();
            }
        }
        private void btnQuanLyDoiTra_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsReturnManagement();
            }
        }

        private void btnQuanLyDichVuHoTro_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsSupportService();
            }
        }

        private void btnQuanLyKhuyenMai_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                admin.IsPromotionManagement();
            }
        }
    }
}
